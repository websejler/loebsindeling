using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loebsindeling
{
    internal class Grouping
    {
        public static List<Boat> jst_grouping(List<Boat> boatList, int numberOfGroups)
        {
            double min, max, step;
            min = boatList[0].score;
            max = boatList[boatList.Count-1].score;
            step = (max - min)/numberOfGroups;
            double current = min + step;
            int i = 1;
            foreach(Boat boat in boatList)
            {
                boat.GroupeId = i;
                if(boat.score > current)
                {
                    current += step;
                    i++;
                }
            }
            return boatList;
        }
    }
}
