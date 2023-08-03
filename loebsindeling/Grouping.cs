using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loebsindeling
{
    internal class Grouping
    {
        public static List<Boat> scoreStepGruppering(List<Boat> boatList, int numberOfGroups)
        {
            if(boatList.Count== 0) throw new InvalidDataException("No data");
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
        public static List<Boat> scoreStepGruppering(List<Boat> boatList, int numberOfGroups, int startGroupeNr)
        {
            if (boatList.Count == 0) throw new InvalidDataException("No data");
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
            if (boats.Count == 0) throw new InvalidDataException("No data");
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
            scoreStepGruppering(flyingSailsGroupe, nrOfFlyingSailsGroups);
            scoreStepGruppering(noFlyingSailsGroupe, nrOfNoFlyingSailsGroups, nrOfFlyingSailsGroups+1);

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
            scoreStepGruppering(spinnakerAndGennakerGroupe, nrOfSpinnakerAndGennakerSailsGroups);
            scoreStepGruppering(gennakerGroupe, nrOfGennakerSailsGroups, nextGroupeID);
            nextGroupeID += nrOfGennakerSailsGroups;
            scoreStepGruppering(spinnakerGroupe, nrOfSpinnakerSailsGroups, nextGroupeID);
            nextGroupeID += nrOfSpinnakerSailsGroups;
            scoreStepGruppering(noFlyingSailsGroupe, nrOfNoFlyingSailsGroups, nextGroupeID);

            return;
        }
    }
}
