using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ulstuEgov
{
    class MultiLevelParking
    {
        List<BusTerminal<ITransport>> terminalStages;

        private const int countPlaces = 10;

        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            terminalStages = new List<BusTerminal<ITransport>>();
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
    }
}
