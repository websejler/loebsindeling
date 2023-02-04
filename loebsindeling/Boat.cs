using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loebsindeling
{
    internal class Boat
    {   
        public static List<Boat> boats = new List<Boat>();

        private int certifikat;
        private string baadNavn;
        private string nation;
        private int sejlNummer;
        private double sv;

        public Boat(string data) {
            string newdata = "";
            bool inQuotation = false;
            for (int i = 0; i < data.Length; i++){
               if (data[i] == '"') inQuotation = !inQuotation;

               if (inQuotation) {
                    if (data[i] == ',') {
                        newdata += '.';
                    }else {
                        if (data[i] != '"') newdata += data[i];
                    }
                } else {
                    if (data[i] != '"') newdata += data[i];
                }
            }
            
            string[] dataArray = newdata.Split(',');
            for(int i = 0; i < dataArray.Length; i++) {
                dataArray[i] = dataArray[i].Replace('.', ',');
            }

            Int32.TryParse(dataArray[0], out certifikat);
            baadNavn = dataArray[1];
            nation = dataArray[2];
            Int32.TryParse(dataArray[3], out sejlNummer);
            Double.TryParse(dataArray[83], out sv);
        }

        public int Certifikat { get { return certifikat; } set { certifikat = value; } }
        public string BaadNavn { get { return baadNavn; } set { baadNavn = value; } }
        public string Nation { get { return nation; } set { nation = value; } }
        public int SejlNummer { get { return sejlNummer; } set { sejlNummer = value; } }
        public double Sv { get { return sv;} set { sv = value; } }

        public static void loadBoatsFromFile(string path) {
            boats.Clear();
            string[] lines = System.IO.File.ReadAllLines(path);
            
            foreach (string line in lines) {
                if (line[0] == 'C') {
                    continue;
                }
                Boat boat = new Boat(line);
                boats.Add(boat);
            }
        }

        public static string boatsToStringSimpel(List<Boat> boats) {
            string text = "";
            foreach (Boat boat in Boat.boats) {
                text += boat.Certifikat + "  -  " + boat.BaadNavn + "  -  " + boat.Nation + " " +boat.SejlNummer + "\r\n";
            }
            return text;
        }

        public static string boatsToStringAll(List<Boat> boats) {
            string text = "";
            foreach (Boat boat in Boat.boats) {
                text += boat.Certifikat + "  -  " + boat.BaadNavn + "  -  " + boat.Nation + " " + boat.SejlNummer + "  -  " + boat.Sv + "\r\n";
            }
            return text;
        }

        public static string boatsToCsvString(List<Boat> boats) {
            string text = "";
            foreach(Boat boat in Boat.boats) {
                text += boat.Certifikat + ";";
                text += boat.BaadNavn + ";";
                text += boat.Nation + ";";
                text += boat.SejlNummer + ";";
                text += boat.Sv.ToString() + ";";

                text += "\r\n";
            }
            return text;
        }
    }
}
