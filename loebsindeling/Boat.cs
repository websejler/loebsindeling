using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Excel = Microsoft.Office.Interop.Excel;

namespace loebsindeling
{
    internal class Boat
    {

        public static List<string> standartDisplayVars = new List<string> { "certifikat", "baadtypenavn", "nation", "sejlnummer", "baadnavn", "sorterings score", "loeb nr" };
        public static int nrOfBoatsWithNoFlyingSails;
        public static int nrOfBoatsWithSpinnakerAndGennaker;
        public static int nrOfBoatsWithSpinnaker;
        public static int nrOfBoatsWithGennaker;
        public static int nrOfBoatsWithSpinnakerOrGennaker;


        public static List<Boat> boats = new List<Boat>();
        //only variables that are not doubles are listed.
        public static List<string> valuesThatIsInt = new List<string> { "certifikat", "sejlnummer", "byggeaar", "klassestatusid", "rigsejlid", "propelid", "propelid1", "skrogid", "specielid", "kfid", "propelid2", "kfid1", "baadid", "wmin", "loeb nr" };
        public static List<string> valuesThatIsString = new List<string> { "baadnavn", "baadtypenavn", "nation", "propelnavn", "propelnavn1", "kftekst" };
        public static List<string> valuesThatIsBool = new List<string> { "rf", "mf", "hf", "kontrolvejet", "kontrolmaalt", "kontrolkrenget" };

        private static Dictionary<string, int> dataLocationIndex = new Dictionary<string, int>();

        private Dictionary<string, double> doubleData;
        private Dictionary<string, int> intData;
        private Dictionary<string, string> stringData;
        private Dictionary<string, bool> boolData;

        public List<int> ints;
        public double score;
        private int groupeId;


        public Boat(string data)
        {
            doubleData = new Dictionary<string, double>();
            intData = new Dictionary<string, int>();
            intData.Add("groupeid", 0);
            stringData = new Dictionary<string, string>();
            boolData = new Dictionary<string, bool>();
            
            string newdata = "";
            bool inQuotation = false;

            int tempInt = 0;
            double tempDouble = 0;
            string tempString = "";
            bool tempBool = false;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == '"') inQuotation = !inQuotation;

                if (inQuotation)
                {
                    if (data[i] == ',')
                    {
                        newdata += '.';
                    }
                    else
                    {
                        if (data[i] != '"') newdata += data[i];
                    }
                }
                else
                {
                    if (data[i] != '"') newdata += data[i];
                }
            }
            newdata = newdata.Replace(';', ',');
            string[] dataArray = newdata.Split(',');
            for (int i = 0; i < dataArray.Length; i++)
            {
                dataArray[i] = dataArray[i].Replace('.', ',');
            }
            try
            {
                foreach (string value in dataLocationIndex.Keys){
                    if (valuesThatIsInt.Any(value.Contains))
                    {
                        int temp;
                        try { Int32.TryParse(dataArray[dataLocationIndex[value]], out temp); } catch (KeyNotFoundException e) { temp = -1; };
                        intData.Add(value, temp);
                    } else if (valuesThatIsString.Any(value.Contains))
                    {
                        string temp;
                        try { temp = dataArray[dataLocationIndex[value]]; } catch (KeyNotFoundException e) { temp = "N/A"; };
                        stringData.Add(value, temp);
                    } else if (valuesThatIsBool.Any(value.Contains))
                    {
                        bool temp;
                        try { Boolean.TryParse(dataArray[dataLocationIndex[value]], out temp); } catch (KeyNotFoundException e) { temp = false; };
                        boolData.Add(value, temp);
                    } else
                    {
                        double temp;
                        try { Double.TryParse(dataArray[dataLocationIndex[value]], out temp); } catch (KeyNotFoundException e) { temp = -1; };
                        doubleData.Add(value, temp);
                    }
                }
            }
            catch (System.IndexOutOfRangeException e)
            {
                throw new InvalidDataException("Data can not be read by programe");
            }

            ints = new List<int>();
            groupeId = 0;
            if(this.SL == 0 && this.SLU == 0)
            {
                nrOfBoatsWithNoFlyingSails++;
            } 
            else if (this.SL != 0 && this.SLU != 0)
            {
                nrOfBoatsWithSpinnakerAndGennaker++;
                nrOfBoatsWithSpinnakerOrGennaker++;
            }
            else if (this.SLU != 0 && this.SL == 0)
            {
                nrOfBoatsWithGennaker++;
                nrOfBoatsWithSpinnakerOrGennaker++;
            }
            else if (this.SLU == 0 && this.SL != 0)
            {
                nrOfBoatsWithSpinnaker++;
                nrOfBoatsWithSpinnakerOrGennaker++;
            }
            
        }



        public int Certifikat { get { return intData["certifikat"]; } set { intData["certifikat"] = value; } }
        public string BaadNavn { get { return stringData["baadnavn"]; } set { stringData["baadnavn"] = value; } }
        public string Nation { get { return stringData["nation"]; } set { stringData["nation"] = value; } }
        public int SejlNummer { get { return intData["sejlnummer"]; } set { intData["sejlnummer"] = value; } }
        public int GroupeId { get { return intData["groupeid"]; } set { intData["groupeid"] = value; } }
        public string BaadType { get { return stringData["baadtypenavn"]; } set { stringData["baadtypenavn"] = value; } }
        public int ByggeAar { get { return intData["byggeaar"]; } set { intData["byggeaar"] = value; } }
        public int KlasseStatusId { get { return intData["klassestatusid"]; } set { intData["klassestatusid"] = value; } }
        public int RigSejlId { get { return intData["rigsejlid"]; } set { intData["rigsejlid"] = value; } }
        public double E { get { return doubleData["e"]; } set { doubleData["e"] = value; } }
        public double P { get { return doubleData["p"]; } set { doubleData["p"] = value; } }
        public double HB { get { return doubleData["hb"]; } set { doubleData["hb"] = value; } }
        public double MGM { get { return doubleData["mgm"]; } set { doubleData["mgm"] = value; } }
        public double MGU { get { return doubleData["mgu"]; } set { doubleData["mgu"] = value; } }
        public double Tmax { get { return doubleData["tmax"]; } set { doubleData["tmax"] = value; } }
        public double LP { get { return doubleData["lp"]; } set { doubleData["lp"] = value; } }
        public double FSP { get { return doubleData["fsp"]; } set { doubleData["fsp"] = value; } }
        public double SPL { get { return doubleData["spl"]; } set { doubleData["spl"] = value; } }
        public double J { get { return doubleData["j"]; } set { doubleData["j"] = value; } }
        public double TPS { get { return doubleData["tps"]; } set { doubleData["tps"] = value; } }
        public double JHW { get { return doubleData["jhw"]; } set { doubleData["jhw"] = value; } }
        public double ISP { get { return doubleData["isp"]; } set { doubleData["isp"] = value; } }
        public double SL { get { return doubleData["sl"]; } set { doubleData["sl"] = value; } }
        public double SLU { get { return doubleData["slu"]; } set { doubleData["slu"] = value; } }
        public double SLE { get { return doubleData["sle"]; } set { doubleData["sle"] = value; } }
        public double SF { get { return doubleData["sf"]; } set { doubleData["sf"] = value; } }
        public double SMG { get { return doubleData["smg"]; } set { doubleData["smg"] = value; } }
        public double SFA { get { return doubleData["sfa"]; } set { doubleData["sfa"] = value; } }
        public double SMGA { get { return doubleData["smga"]; } set { doubleData["smga"] = value; } }
        public int PropelId { get { return intData["propelid"]; } set { intData["propelid"] = value; } }
        public bool RF { get { return boolData["rf"]; } set { boolData["rf"] = value; } }
        public bool MF { get { return boolData["mf"]; } set { boolData["mf"] = value; } }
        public bool HF { get { return boolData["hf"]; } set { boolData["hf"] = value; } }
        public int PropelId1 { get { return intData["propelid1"]; } set { intData["propelid1"] = value; } }
        public string PropelNavn { get { return stringData["propelnavn"]; } set { stringData["propelnavn"] = value; } }
        public int SkrogId { get { return intData["skrogid"]; } set { intData["skrogid"] = value; } }
        public double Gmax { get { return doubleData["gmax"]; } set { doubleData["gmax"] = value; } }
        public double SGmax { get { return doubleData["sgmax"]; } set { doubleData["sgmax"] = value; } }
        public double FBSB { get { return doubleData["fbsb"]; } set { doubleData["fbsb"] = value; } }
        public double FBBB { get { return doubleData["fbbb"]; } set { doubleData["fbbb"] = value; } }
        public double SBmax { get { return doubleData["sbmax"]; } set { doubleData["sbmax"] = value; } }
        public double UDFSB { get { return doubleData["udfsb"]; } set { doubleData["udfsb"] = value; } }
        public double UDFBB { get { return doubleData["udfbb"]; } set { doubleData["udfbb"] = value; } }
        public double OF { get { return doubleData["of"]; } set { doubleData["of"] = value; } }
        public double OA { get { return doubleData["oa"]; } set { doubleData["oa"] = value; } }
        public double UDHBmax { get { return doubleData["udhbmax"]; } set { doubleData["udhbmax"] = value; } }
        public double UDHmax { get { return doubleData["udhmax"]; } set { doubleData["udhmax"] = value; } }
        public double STF { get { return doubleData["stf"]; } set { doubleData["stf"] = value; } }
        public double AF { get { return doubleData["af"]; } set { doubleData["af"] = value; } }
        public int SpecielId { get { return intData["specielid"]; } set { intData["specielid"] = value; } }
        public double Bmax { get { return doubleData["bmax"]; } set { doubleData["bmax"] = value; } }
        public double LOA { get { return doubleData["loa"]; } set { doubleData["loa"] = value; } }
        public double D { get { return doubleData["d"]; } set { doubleData["d"] = value; } }
        public double K { get { return doubleData["k"]; } set { doubleData["k"] = value; } }
        public double KC { get { return doubleData["kc"]; } set { doubleData["kc"] = value; } }
        public double WBF { get { return doubleData["wbf"]; } set { doubleData["wbf"] = value; } }
        public double WBL { get { return doubleData["wbl"]; } set { doubleData["wbl"] = value; } }
        public double WBT { get { return doubleData["wbt"]; } set { doubleData["wbt"] = value; } }
        public double WBV { get { return doubleData["wbv"]; } set { doubleData["wbv"] = value; } }
        public double SSC { get { return doubleData["ssc"]; } set { doubleData["ssc"] = value; } }
        public double SST { get { return doubleData["sst"]; } set { doubleData["sst"] = value; } }
        public int KFId { get { return intData["kfid"]; } set { intData["kfid"] = value; } }
        public bool KontrolVejet { get { return boolData["kontrolvejet"]; } set { boolData["kontrolvejet"] = value; } }
        public bool KontrolMaalt { get { return boolData["kontrolmaalt"]; } set { boolData["kontrolmaalt"] = value; } }
        public bool KontrolKrenget { get { return boolData["kontrolkrenget"]; } set { boolData["kontrolkrenget"] = value; } }
        public int PropelId2 { get { return intData["propelid2"]; } set { intData["propelid2"] = value; } }
        public string PropelNavn1 { get { return stringData["propelnavn1"]; } set { stringData["propelnavn1"] = value; } }
        public int KFId1 { get { return intData["kfid1"]; } set { intData["kfid1"] = value; } }
        public string KFTekst { get { return stringData["kftekst"]; } set { stringData["kftekst"] = value; } }
        public int BaadId { get { return intData["baadid"]; } set { intData["baadid"] = value; } }
        public double SSA { get { return doubleData["ssa"]; } set { doubleData["ssa"] = value; } }
        public double FA1 { get { return doubleData["fa1"]; } set { doubleData["fa1"] = value; } }
        public double FA2 { get { return doubleData["fa2"]; } set { doubleData["fa2"] = value; } }
        public double FA3 { get { return doubleData["fa3"]; } set { doubleData["fa3"] = value; } }
        public double SA { get { return doubleData["sa"]; } set { doubleData["sa"] = value; } }
        public double S { get { return doubleData["s"]; } set { doubleData["s"] = value; } }
        public double L { get { return doubleData["l"]; } set { doubleData["l"] = value; } }
        public double B { get { return doubleData["b"]; } set { doubleData["b"] = value; } }
        public double G { get { return doubleData["g"]; } set { doubleData["g"] = value; } }
        public double BogG { get { return doubleData["bogg"]; } set { doubleData["bogg"] = value; } }
        public double DHK { get { return doubleData["dhk"]; } set { doubleData["dhk"] = value; } }
        public double WS { get { return doubleData["ws"]; } set { doubleData["ws"] = value; } }
        public double Dp { get { return doubleData["dp"]; } set { doubleData["dp"] = value; } }
        public int Wmin { get { return intData["wmin"]; } set { intData["wmin"] = value; } }
        public double Sv { get { return doubleData["sv"]; } set { doubleData["sv"] = value; } }
        public double TCC { get { return doubleData["tcc"]; } set { doubleData["tcc"] = value; } }
        public double GPH { get { return doubleData["gph"]; } set { doubleData["gph"] = value; } }
        public double TACIL { get { return doubleData["tacil"]; } set { doubleData["tacil"] = value; } }
        public double TACIM { get { return doubleData["tacim"]; } set { doubleData["tacim"] = value; } }
        public double TACIH { get { return doubleData["tacih"]; } set { doubleData["tacih"] = value; } }
        public double TAUDL { get { return doubleData["taudl"]; } set { doubleData["taudl"] = value; } }
        public double TAUDM { get { return doubleData["taudm"]; } set { doubleData["taudm"] = value; } }
        public double TAUDH { get { return doubleData["taudh"]; } set { doubleData["taudh"] = value; } }
        public double SAS { get { return doubleData["sas"]; } set { doubleData["sas"] = value; } }
        public double SAA { get { return doubleData["saa"]; } set { doubleData["saa"] = value; } }
        public double CW { get { return doubleData["cw"]; } set { doubleData["cw"] = value; } }
        public double TAU3 { get { return doubleData["tau3"]; } set { doubleData["tau3"] = value; } }
        public double TAU4 { get { return doubleData["tau4"]; } set { doubleData["tau4"] = value; } }
        public double TAU5 { get { return doubleData["tau5"]; } set { doubleData["tau5"] = value; } }
        public double TAU6 { get { return doubleData["tau6"]; } set { doubleData["tau6"] = value; } }
        public double TAU7 { get { return doubleData["tau7"]; } set { doubleData["tau7"] = value; } }
        public double TAU8 { get { return doubleData["tau8"]; } set { doubleData["tau8"] = value; } }
        public double TAU10 { get { return doubleData["tau10"]; } set { doubleData["tau10"] = value; } }
        public double TAD3 { get { return doubleData["tad3"]; } set { doubleData["tad3"] = value; } }
        public double TAD4 { get { return doubleData["tad4"]; } set { doubleData["tad4"] = value; } }
        public double TAD5 { get { return doubleData["tad5"]; } set { doubleData["tad5"] = value; } }
        public double TAD6 { get { return doubleData["tad6"]; } set { doubleData["tad6"] = value; } }
        public double TAD7 { get { return doubleData["tad7"]; } set { doubleData["tad7"] = value; } }
        public double TAD8 { get { return doubleData["tad8"]; } set { doubleData["tad8"] = value; } }
        public double TAD10 { get { return doubleData["tad10"]; } set { doubleData["tad10"] = value; } }
        public double TACI3 { get { return doubleData["taci3"]; } set { doubleData["taci3"] = value; } }
        public double TACI4 { get { return doubleData["taci4"]; } set { doubleData["taci4"] = value; } }
        public double TACI5 { get { return doubleData["taci5"]; } set { doubleData["taci5"] = value; } }
        public double TACI6 { get { return doubleData["taci6"]; } set { doubleData["taci6"] = value; } }
        public double TACI7 { get { return doubleData["taci7"]; } set { doubleData["taci7"] = value; } }
        public double TACI8 { get { return doubleData["taci8"]; } set { doubleData["taci8"] = value; } }
        public double TACI10 { get { return doubleData["taci10"]; } set { doubleData["taci10"] = value; } }
        public double PLTCI { get { return doubleData["pltci"]; } set { doubleData["pltci"] = value; } }
        public double PLCDI { get { return doubleData["pldci"]; } set { doubleData["pldci"] = value; } }
        public double ECI { get { return doubleData["eci"]; } set { doubleData["eci"] = value; } }
        public double PLTUD { get { return doubleData["pltud"]; } set { doubleData["pltud"] = value; } }
        public double PLDUD { get { return doubleData["pldud"]; } set { doubleData["pldud"] = value; } }
        public double EUD { get { return doubleData["eud"]; } set { doubleData["eud"] = value; } }
        public double Score { get { return score; } set { score = value; } }


        public static void loadBoatsFromFile(string path)
        {
            boats.Clear();
            nrOfBoatsWithNoFlyingSails = 0;
            nrOfBoatsWithSpinnakerAndGennaker = 0;
            nrOfBoatsWithSpinnaker = 0;
            nrOfBoatsWithGennaker = 0;
            nrOfBoatsWithSpinnakerOrGennaker = 0;
            string[] lines = { "" };
            if (path.EndsWith(".csv"))
            {
                lines = System.IO.File.ReadAllLines(path);

            }
            else if (path.EndsWith(".xlsx"))
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbooks xlWorkbookS = xlApp.Workbooks;
                Excel.Workbook xlWorkbook = xlWorkbookS.Open(path);
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Excel.Range xlRange = xlWorksheet.UsedRange;
                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;
                lines = new string[rowCount];
                //reads all values from sheet 1
                object[,] values = xlRange.Value2;
                //cleanup
                GC.Collect();
                GC.WaitForPendingFinalizers();

                //rule of thumb for releasing com objects:
                //  never use two dots, all COM objects must be referenced and released individually
                //  ex: [somthing].[something].[something] is bad

                //release com objects to fully kill excel process from running in the background
                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);

                //close and release
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);
                Marshal.ReleaseComObject(xlWorkbookS);

                //quit and release
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
                string temp = "";
                for (int i = 1; i <= rowCount; i++)
                {
                    string line = "";
                    for (int j = 1; j <= colCount; j++)
                    {
                        //new line
                        if (j == 1)
                            Console.Write(i + "\n\r");

                        //write the value to the console
                        if (values[i, j] != null)
                        {
                            temp = values[i, j].ToString();
                            if (temp.Contains(","))
                            {
                                temp = "\"" + temp + "\"";
                            }
                            temp += ",";
                        }
                        else
                        {
                            temp = ",";
                        }
                        line += temp;

                        //add useful things here!   
                    }
                    lines[i - 1] = line;
                }
            }
            foreach (string line in lines)
            {
                if (line[0] == 'C' || line[0] == 'c')
                {
                    initDataLocationIndex(line);
                    continue;
                }
                Boat boat;
                try
                {
                    boat = new Boat(line);
                }
                catch (InvalidDataException e)
                {
                    throw e;
                }
                boats.Add(boat);
            }
        }


        private static void initDataLocationIndex(string line)
        {
            dataLocationIndex.Clear();
            line = line.Replace(';', ',');
            string[] dataArray = line.Split(',');
            for (int i = 0; i < dataArray.Length; i++)
            {
                dataLocationIndex.Add(dataArray[i].ToLower(), i);
            }
        }


        public static string boatsToStringSimpel(List<Boat> boats)
        {
            string text = "";
            foreach (Boat boat in Boat.boats)
            {
                text += boat.Certifikat + "  -  " + boat.BaadType + "  -  " + boat.Nation + " " + boat.SejlNummer + " - " + boat.BaadNavn + "\r\n";
            }
            return text;
        }

        public static object[,] boatsToDataGridViewString(List<Boat> boats)
        {
            object[,] text = new object[boats.Count, 5];
            for (int i = 0; i < boats.Count; i++)
            {
                text[i, 0] = boats[i].Certifikat;
                text[i, 1] = boats[i].BaadType;
                text[i, 2] = boats[i].Nation;
                text[i, 3] = boats[i].SejlNummer;
                text[i, 4] = boats[i].BaadNavn;
            }
            return text;
        }
        public static object[,] boatsToDataGridViewString(List<Boat> boats, List<string> vars)
        {
            object[,] text = new object[boats.Count, vars.Count];
            for (int i = 0; i < boats.Count; i++)
            {
                for(int j = 0; j<vars.Count; j++)
                {
                    if (vars[j].Equals("sorterings score"))
                    {
                        text[i,j] = boats[i].Score;
                    }
                    else if (vars[j].Equals("loeb nr"))
                    {
                        text[i,j] = boats[i].GroupeId;
                    }
                    else if (valuesThatIsInt.Any(vars[j].Contains))
                    {
                        text[i,j] = boats[i].intData[vars[j]];
                    }
                    else if (valuesThatIsString.Any(vars[j].Contains))
                    {
                        text[i,j] = boats[i].stringData[vars[j]];
                    }
                    else if (valuesThatIsBool.Any(vars[j].Contains))
                    {
                        text[i,j] = boats[i].boolData[vars[j]];
                    }
                    else
                    {
                        text[i,j] = boats[i].doubleData[vars[j]];
                    }
                }
            }
            return text;
        }

        public static string boatsToStringSort(List<Boat> boats)
        {
            string text = "";
            foreach (Boat boat in Boat.boats)
            {
                text += boat.Certifikat + "  -  " + boat.BaadNavn + "  -  " + boat.Nation + " " + boat.SejlNummer + "\r\n";
            }
            return text;
        }

        public static string boatsToStringGrouping(List<Boat> boats)
        {
            string text = "";
            foreach (Boat boat in Boat.boats)
            {
                text += boat.Certifikat + "  -  " + boat.BaadNavn + "  -  " + boat.Nation + " " + boat.SejlNummer + " - " + boat.GroupeId + "\r\n";
            }
            return text;
        }


        public static string boatsToCsvString(List<Boat> boats, List<string> vars)
        {
            string text = "";
            foreach (string s in vars)
            {
                text += s + ";";
            }
            text += "\r\n";

            foreach (Boat boat in Boat.boats)
            {
                foreach(string s in vars)
                {
                    if (s.Equals("sorterings score"))
                    {
                        text += boat.score + ";";
                    }
                    else if (s.Equals("loeb nr"))
                    {
                        text += boat.GroupeId + ";";
                    }
                    else if (valuesThatIsInt.Any(s.Contains))
                    {
                        int temp;
                        temp = boat.intData[s];
                        text += temp + ";";
                    }
                    else if (valuesThatIsString.Any(s.Contains))
                    {
                        string temp;
                        temp = boat.stringData[s];
                        text += temp + ";";
                    }
                    else if (valuesThatIsBool.Any(s.Contains))
                    {
                        bool temp;
                        temp = boat.boolData[s];
                        text += temp + ";";
                    }
                    else
                    {
                        double temp;
                        temp = boat.doubleData[s];
                        text += temp + ";";
                    }
                }
                
                text += "\r\n";
            }
            return text;
        }

        public static Dictionary<string, int> getDataLocationIndex()
        {
            return dataLocationIndex;
        }

        internal static void displayDataGridView(List<Boat> boats, DataGridView dataGridView, List<string> vars)
        {
            
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            if(boats.Count <= 0 )
            {
                return;
            }
            dataGridView.ColumnCount = vars.Count;
            int i = 0;
            //inits datagridview
            foreach (string s in vars)
            {
                dataGridView.Columns[i].Name = s;
                if (valuesThatIsInt.Any(s.Contains))
                {
                    dataGridView.Columns[i].ValueType = typeof(int);
                    
                }
                else if (valuesThatIsString.Any(s.Contains))
                {
                }
                else if (valuesThatIsBool.Any(s.Contains))
                {
                    dataGridView.Columns[i].ValueType = typeof(bool);
                }
                else
                {
                    dataGridView.Columns[i].ValueType = typeof(double);
                }
                i++;
            }
            //loads data to datagridview
            
            object[,] data = Boat.boatsToDataGridViewString(boats, vars);
            object[] temp = new object[data.GetLength(1)];
            for (int j = 0; j < Boat.boats.Count; j++)
            {
                for (int n= 0; n < data.GetLength(1); n++)
                {
                    temp[n] = data[j, n];
                }
                dataGridView.Rows.Add(temp);
            }
        }
    }
}
