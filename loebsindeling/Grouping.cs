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
        public static List<Boat> jst_grouping(List<Boat> boatList, int numberOfGroups, int startGroupeNr)
        {
            double min, max, step;
            min = boatList[0].score;
            max = boatList[boatList.Count - 1].score;
            step = (max - min) / numberOfGroups;
            double current = min + step;
            int i = startGroupeNr;
            foreach (Boat boat in boatList)
            {
                boat.GroupeId = i;
                if (boat.score > current)
                {
                    current += step;
                    i++;
                }
            }
            return boatList;
        }

        public static void flyvergruppering2(List<Boat> boats, int nrOfNoFlyingSailsGroups, int nrOfFlyingSailsGroups)
        {
            List<Boat> noFlyingSailsGroupe = new List<Boat>();
            List<Boat> flyingSailsGroupe = new List<Boat>();
            foreach(Boat boat in boats)
            {
                if(boat.SL == 0 && boat.SLU == 0)
                {
                    noFlyingSailsGroupe.Add(boat);
                } else
                {
                    flyingSailsGroupe.Add(boat);
                }
            }
            jst_grouping(flyingSailsGroupe, nrOfFlyingSailsGroups);
            jst_grouping(noFlyingSailsGroupe, nrOfNoFlyingSailsGroups, nrOfFlyingSailsGroups+1);

            return;
        }

        internal static void flyvergruppering4(List<Boat> boats, int nrOfNoFlyingSailsGroups, int nrOfSpinnakerSailsGroups, int nrOfGennakerSailsGroups, int nrOfSpinnakerAndGennakerSailsGroups)
        {
            List<Boat> noFlyingSailsGroupe = new List<Boat>();
            List<Boat> spinnakerGroupe = new List<Boat>();
            List<Boat> gennakerGroupe = new List<Boat>();
            List<Boat> spinnakerAndGennakerGroupe = new List<Boat>();

            foreach (Boat boat in boats)
            {
                if (boat.SL == 0 && boat.SLU == 0)
                {
                    noFlyingSailsGroupe.Add(boat);
                }
                else if(boat.SLU != 0 && boat.SL == 0)
                {
                    gennakerGroupe.Add(boat);
                } 
                else if(boat.SLU == 0 && boat.SL != 0)
                {
                    spinnakerGroupe.Add(boat);
                } 
                else
                {
                    spinnakerAndGennakerGroupe.Add(boat);
                }
            }
            int nextGroupeID = nrOfSpinnakerAndGennakerSailsGroups+1;
            jst_grouping(spinnakerAndGennakerGroupe, nrOfSpinnakerAndGennakerSailsGroups);
            jst_grouping(gennakerGroupe, nrOfGennakerSailsGroups, nextGroupeID);
            nextGroupeID += nrOfGennakerSailsGroups;
            jst_grouping(spinnakerGroupe, nrOfSpinnakerSailsGroups, nextGroupeID);
            nextGroupeID += nrOfSpinnakerSailsGroups;
            jst_grouping(noFlyingSailsGroupe, nrOfNoFlyingSailsGroups, nextGroupeID);

            return;
        }
    }
}
