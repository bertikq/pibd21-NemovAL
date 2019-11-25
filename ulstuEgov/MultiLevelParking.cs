using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ulstuEgov
{
    class MultiLevelParking
    {
        List<BusTerminal<ITransport>> terminalStages;

        private const int countPlaces = 10;

        private int pictureWidth;
        private int pictureHeight;

        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            terminalStages = new List<BusTerminal<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; i++)
            {
                terminalStages.Add(new BusTerminal<ITransport>(countPlaces, pictureWidth, pictureHeight));
            }
        }

        public BusTerminal<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < terminalStages.Count)
                {
                    return terminalStages[ind];
                }
                return null;
            }
        }

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter fs = new StreamWriter(filename, false))
            {
                fs.WriteLine("CountLeveles:" + terminalStages.Count);
                foreach (var level in terminalStages)
                {
                    fs.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var bus = level[i];
                        if (bus != null)
                        {
                            if (bus.GetType().Name == "BaseBus")
                            {
                                fs.Write(i + ":BaseBus:");
                            }
                            if (bus.GetType().Name == "BusWithAccord")
                            {
                                fs.Write(i + ":BusWithAccord:");
                            }
                            fs.WriteLine(bus);
                        }
                    }
                }
            }
            return true;
        }

        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader fs = new StreamReader(filename))
            {
                string line = fs.ReadLine();
                if (line.Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(line.Split(':')[1]);
                    if (terminalStages != null)
                    {
                        terminalStages.Clear();
                    }
                    terminalStages = new List<BusTerminal<ITransport>>(count);
                }
                else
                {
                    return false;
                }
                int counter = -1;
                ITransport bus = null;
                while ((line = fs.ReadLine()) != null)
                {
                    if (line == "Level")
                    {
                        counter++;
                        terminalStages.Add(new BusTerminal<ITransport>(countPlaces, pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    if (line.Split(':')[1] == "BaseBus")
                    {
                        bus = new BaseBus(line.Split(':')[2]);
                    }
                    else if (line.Split(':')[1] == "BusWithAccord")
                    {
                        bus = new BusWithAccord(line.Split(':')[2]);
                    }
                    terminalStages[counter][Convert.ToInt32(line.Split(':')[0])] = bus;
                }
            }
            return true;
        }
    }
}
