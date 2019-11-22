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
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                WriteToFile("CountLeveles:" + terminalStages.Count +
               Environment.NewLine, fs);
                foreach (var level in terminalStages)
                {
                    WriteToFile("Level" + Environment.NewLine, fs);
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var bus = level[i];
                        if (bus != null)
                        {
                            if (bus.GetType().Name == "BaseBus")
                            {
                                WriteToFile(i + ":BaseBus:", fs);
                            }
                            if (bus.GetType().Name == "BusWithAccord")
                            {
                                WriteToFile(i + ":BusWithAccord:", fs);
                            }
                            WriteToFile(bus + Environment.NewLine, fs);
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
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                byte[] b = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    bufferTextFromFile += temp.GetString(b);
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("CountLeveles"))
            {
                int count = Convert.ToInt32(strs[0].Split(':')[1]);
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
            for (int i = 1; i < strs.Length; ++i)
            {
                if (strs[i] == "Level")
                {
                    counter++;
                    terminalStages.Add(new BusTerminal<ITransport>(countPlaces, pictureWidth, pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }
                if (strs[i].Split(':')[1] == "BaseBus")
                {
                    bus = new BaseBus(strs[i].Split(':')[2]);
                }
                else if (strs[i].Split(':')[1] == "BusWithAccord")
                {
                    bus = new BusWithAccord(strs[i].Split(':')[2]);
                }
                terminalStages[counter][Convert.ToInt32(strs[i].Split(':')[0])] = bus;
            }
            return true;
        }
    }
}
