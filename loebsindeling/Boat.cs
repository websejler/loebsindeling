using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loebsindeling
{
    internal class Boat
    {   
        public static List<Boat> boats = new List<Boat>();

        private int certifikat;
        private string baadNavn;
        private string baadType;
        private string nation;
        private int sejlNummer;
        private int aar;
        private int klasseStatusId;
        private int rigSejlId;
        private double e;
        private double p;
        private double hB;
        private double mGM;
        private double mGU;
        private double tmax;
        private double lP;
        private double fSP;
        private double sPL;
        private double j;
        private double tPS;
        private double jHW;
        private double iSP;
        private double sL;
        private double sLU;
        private double sLE;
        private double sFA;
        private double sF;
        private double sMG;
        private double sMGA;
        private int propelId;
        private bool rF;
        private bool mF;
        private bool hF;
        private int propelId1;
        private string propelNavn;
        private int skrogId;
        private double gmax;
        private double sGmax;
        private double fBSB;
        private double fBBB;
        private double sBmax;
        private double uDFSB;
        private double uDFBB;
        private double oF;
        private double oA;
        private double uDHBmax;
        private double uDHmax;
        private double sTF;
        private double aF;
        private int specielId;
        private double bmax;
        private double lOA;
        private double d;
        private double k;
        private double kC;
        private double wBF;
        private double wBL;
        private double wBT;
        private double wBV;
        private double sSC;
        private double sST;
        private int kFId;
        private bool kontrolVejet;
        private bool kontrolMaalt;
        private bool kontrolKrenget;
        private int propelId2;
        private string propelNavn1;
        private int kFId1;
        private string kFTekst;
        private int baadId;
        private double sSA;
        private double fA1;
        private double fA2;
        private double fA3;
        private double sA;
        private double s;
        private double l;
        private double b;
        private double g;
        private double bogG;
        private double dHK;
        private double wS;
        private double dp;
        private int wmin;
        private double sv;
        private double tCC;
        private double gPH;
        private double tACIL;
        private double tACIM;
        private double tACIH;
        private double tAUDL;
        private double tAUDM;
        private double tAUDH;
        private double sAS;
        private double sAA;
        private double cW;
        private double tAU3;
        private double tAU4;
        private double tAU5;
        private double tAU6;
        private double tAU7;
        private double tAU8;
        private double tAU10;
        private double tAD3;
        private double tAD4;
        private double tAD5;
        private double tAD6;
        private double tAD7;
        private double tAD8;
        private double tAD10;
        private double tACI3;
        private double tACI4;
        private double tACI5;
        private double tACI6;
        private double tACI7;
        private double tACI8;
        private double tACI10;
        private double pLTCI;
        private double pLDCI;
        private double eCI;
        private double pLTUD;
        private double pLDUD;
        private double eUD;


        public List<int> ints;
        public double score;
        private int groupeId;

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
            Int32.TryParse(dataArray[4], out aar);
            baadType = dataArray[5];
            Int32.TryParse(dataArray[6], out klasseStatusId);
            Int32.TryParse(dataArray[7], out rigSejlId);
            Double.TryParse(dataArray[8], out e);
            Double.TryParse(dataArray[9], out p);
            Double.TryParse(dataArray[10], out hB);
            Double.TryParse(dataArray[11], out mGM);
            Double.TryParse(dataArray[12], out mGU);
            Double.TryParse(dataArray[13], out tmax);
            Double.TryParse(dataArray[14], out lP);
            Double.TryParse(dataArray[15], out fSP);
            Double.TryParse(dataArray[16], out sPL);
            Double.TryParse(dataArray[17], out j);
            Double.TryParse(dataArray[18], out tPS);
            Double.TryParse(dataArray[19], out jHW);
            Double.TryParse(dataArray[20], out iSP);
            Double.TryParse(dataArray[21], out sL);
            Double.TryParse(dataArray[22], out sLU);
            Double.TryParse(dataArray[23], out sLE);
            Double.TryParse(dataArray[24], out sF);
            Double.TryParse(dataArray[25], out sMG);
            Double.TryParse(dataArray[26], out sFA);
            Double.TryParse(dataArray[27], out sMGA);
            Int32.TryParse(dataArray[28], out propelId);
            Boolean.TryParse(dataArray[29], out rF);
            Boolean.TryParse(dataArray[30], out mF);
            Boolean.TryParse(dataArray[31], out hF);
            Int32.TryParse(dataArray[32], out propelId1);
            propelNavn = dataArray[33];
            Int32.TryParse(dataArray[34], out skrogId);
            Double.TryParse(dataArray[35], out gmax);
            Double.TryParse(dataArray[36], out sGmax);
            Double.TryParse(dataArray[37], out fBSB);
            Double.TryParse(dataArray[38], out fBBB);
            Double.TryParse(dataArray[39], out sBmax);
            Double.TryParse(dataArray[40], out uDFSB);
            Double.TryParse(dataArray[41], out uDFBB);
            Double.TryParse(dataArray[42], out oF);
            Double.TryParse(dataArray[43], out oA);
            Double.TryParse(dataArray[44], out uDHBmax);
            Double.TryParse(dataArray[45], out uDHmax);
            Double.TryParse(dataArray[46], out sTF);
            Double.TryParse(dataArray[47], out aF);
            Int32.TryParse(dataArray[48], out specielId);
            Double.TryParse(dataArray[49], out bmax);
            Double.TryParse(dataArray[50], out lOA);
            Double.TryParse(dataArray[51], out d);
            Double.TryParse(dataArray[52], out k);
            Double.TryParse(dataArray[53], out kC);
            Double.TryParse(dataArray[54], out wBF);
            Double.TryParse(dataArray[55], out wBL);
            Double.TryParse(dataArray[56], out wBT);
            Double.TryParse(dataArray[57], out wBV);
            Double.TryParse(dataArray[58], out sSC);
            Double.TryParse(dataArray[59], out sST);
            Int32.TryParse(dataArray[60], out kFId);
            Boolean.TryParse(dataArray[61], out kontrolVejet);
            Boolean.TryParse(dataArray[62], out kontrolMaalt);
            Boolean.TryParse(dataArray[63], out kontrolKrenget);
            Int32.TryParse(dataArray[64], out propelId2);
            propelNavn1 = dataArray[65];
            Int32.TryParse(dataArray[66], out kFId1);
            kFTekst = dataArray[67];
            Int32.TryParse(dataArray[68], out baadId);
            Double.TryParse(dataArray[69], out sSA);
            Double.TryParse(dataArray[70], out fA1);
            Double.TryParse(dataArray[71], out fA2);
            Double.TryParse(dataArray[72], out fA3);
            Double.TryParse(dataArray[73], out sA);
            Double.TryParse(dataArray[74], out s);
            Double.TryParse(dataArray[75], out l);
            Double.TryParse(dataArray[76], out b);
            Double.TryParse(dataArray[77], out g);
            Double.TryParse(dataArray[78], out bogG);
            Double.TryParse(dataArray[79], out dHK);
            Double.TryParse(dataArray[80], out wS);
            Double.TryParse(dataArray[81], out dp);
            Int32.TryParse(dataArray[82], out wmin);
            Double.TryParse(dataArray[83], out sv);
            Double.TryParse(dataArray[84], out tCC);
            Double.TryParse(dataArray[85], out gPH);
            Double.TryParse(dataArray[86], out tACIL);
            Double.TryParse(dataArray[87], out tACIM);
            Double.TryParse(dataArray[88], out tACIH);
            Double.TryParse(dataArray[89], out tAUDL);
            Double.TryParse(dataArray[90], out tAUDM);
            Double.TryParse(dataArray[91], out tAUDH);
            Double.TryParse(dataArray[92], out sAS);
            Double.TryParse(dataArray[93], out sAA);
            Double.TryParse(dataArray[94], out cW);
            Double.TryParse(dataArray[95], out tAU3);
            Double.TryParse(dataArray[96], out tAU4);
            Double.TryParse(dataArray[97], out tAU5);
            Double.TryParse(dataArray[98], out tAU6);
            Double.TryParse(dataArray[99], out tAU7);
            Double.TryParse(dataArray[100], out tAU8);
            Double.TryParse(dataArray[101], out tAU10);
            Double.TryParse(dataArray[102], out tAD3);
            Double.TryParse(dataArray[103], out tAD4);
            Double.TryParse(dataArray[104], out tAD5);
            Double.TryParse(dataArray[105], out tAD6);
            Double.TryParse(dataArray[106], out tAD7);
            Double.TryParse(dataArray[107], out tAD8);
            Double.TryParse(dataArray[108], out tAD10);
            Double.TryParse(dataArray[109], out tACI3);
            Double.TryParse(dataArray[110], out tACI4);
            Double.TryParse(dataArray[111], out tACI5);
            Double.TryParse(dataArray[112], out tACI6);
            Double.TryParse(dataArray[113], out tACI7);
            Double.TryParse(dataArray[114], out tACI8);
            Double.TryParse(dataArray[115], out tACI10);
            Double.TryParse(dataArray[116], out pLTCI);
            Double.TryParse(dataArray[117], out pLDCI);
            Double.TryParse(dataArray[118], out eCI);
            Double.TryParse(dataArray[119], out pLTUD);
            Double.TryParse(dataArray[120], out pLDUD);
            Double.TryParse(dataArray[121], out eUD);

            ints = new List<int>();
            groupeId = 0;
        }

        public int Certifikat { get { return certifikat; } set { certifikat = value; } }
        public string BaadNavn { get { return baadNavn; } set { baadNavn = value; } }
        public string Nation { get { return nation; } set { nation = value; } }
        public int SejlNummer { get { return sejlNummer; } set { sejlNummer = value; } }
        public int GroupeId { get { return groupeId; } set { groupeId = value; } }
        public string BaadType { get { return baadType; } set { baadType = value;} }
        public int Aar { get { return aar; } set { aar = value; } }
        public int KlasseStatusId { get { return klasseStatusId; } set { klasseStatusId = value; } }
        public int RigSejlId { get { return rigSejlId;} set { rigSejlId = value; } }
        public double E { get { return e; } set { e = value; } }
        public double P { get { return p; } set { p = value; } }
        public double HB { get { return hB; } set { hB = value; } }
        public double MGM { get { return mGM; } set { mGM = value; } }
        public double MGU { get { return mGU; } set { mGU = value; } }
        public double Tmax { get { return tmax; } set { tmax = value; } }
        public double LP { get { return lP; } set { lP = value; } }
        public double FSP { get { return fSP; } set { fSP = value; } }
        public double SPL { get { return sPL; } set { sPL = value; } }
        public double J { get { return j; } set { j = value; } }
        public double TPS { get { return tPS; } set { tPS = value; } }
        public double JHW { get { return jHW; } set { jHW = value; } }
        public double ISP { get { return iSP; } set { iSP = value; } }
        public double SL { get { return sL; } set { sL = value; } }
        public double SLU { get { return sLU; } set { sLU = value; } }
        public double SLE { get { return sLE; } set { sLE = value; } }
        public double SF { get { return sF; } set { sF = value; } }
        public double SMG { get { return sMG; } set { sMG = value; } }
        public double SFA { get { return sFA; } set { sFA = value; } }
        public double SMGA { get { return sMGA; } set { sMGA = value; } }
        public int PropelId { get { return propelId; } set { propelId = value;} }
        public bool RF { get { return rF; } set { rF = value; } }
        public bool MF { get { return mF; } set { mF = value; } }
        public bool HF { get { return hF; } set { hF = value; } }
        public int PropelId1 { get { return propelId1; } set { propelId1 = value; } }
        public string PropelNavn { get { return propelNavn; } set { propelNavn = value; } }
        public int SkrogId { get { return skrogId; } set { skrogId = value; } }
        public double Gmax { get { return gmax; } set { gmax = value; } }
        public double SGmax { get { return sGmax; } set { sGmax = value;} }
        public double FBSB { get { return fBSB; } set { fBSB = value;} }
        public double FBBB { get { return fBBB; } set { fBBB = value; } }
        public double SBmax { get { return sBmax; } set { sBmax = value; } }
        public double UDFSB { get { return uDFSB; } set { uDFSB = value; } }
        public double UDFBB { get { return uDFBB; } set { uDFBB = value; } }
        public double OF { get { return oF; } set { oF = value; } }
        public double OA { get { return oA; } set { oA = value; } }
        public double UDHBmax { get { return uDHBmax; } set { uDHBmax = value; } }
        public double UDHmax { get { return uDHmax; } set { uDHmax = value; } }
        public double STF { get { return sTF; } set { sTF = value; } }
        public double AF { get { return aF; } set { aF = value; } }
        public int SpecielId { get { return specielId;} set { specielId = value;} }
        public double Bmax { get { return bmax; } set { bmax = value; } }
        public double LOA { get { return lOA; } set { lOA = value; } }
        public double D { get { return d; } set { d = value; } }
        public double K { get { return k; } set { k = value; } }
        public double KC { get { return kC; } set { kC = value; } } 
        public double WBF { get { return wBF; } set { wBF = value; } }
        public double WBL { get { return wBL; } set { wBL = value; } }
        public double WBT { get { return wBT; } set { wBT = value; } }
        public double WBV { get { return wBV; } set { wBV = value; } }
        public double SSC { get { return sSC; } set { sSC = value; } }
        public double SST { get { return sST; } set { sST = value; } }
        public int KFId { get { return kFId; } set { kFId = value; } }
        public bool KontrolVejet { get { return kontrolVejet;} set { kontrolVejet = value; } }
        public bool KontrolMaalt { get { return kontrolMaalt; } set { kontrolMaalt = value; } }
        public bool KontrolKrenget { get { return kontrolKrenget;} set { kontrolKrenget = value; } }
        public int PropelId2 { get { return propelId2; } set { propelId2 = value; } }
        public string PropelNavn1 { get { return propelNavn1; } set { propelNavn1 = value; } }
        public int KFId1 { get { return kFId1; } set { kFId1 = value; } }
        public string KFTekst { get { return kFTekst; } set { kFTekst = value; } }
        public int BaadId { get { return baadId; } set { baadId = value; } }
        public double SSA { get { return sSA; } set { sSA = value; } }
        public double FA1 { get { return fA1; } set { fA1 = value; } }
        public double FA2 { get { return fA2; } set { fA2 = value; } }
        public double FA3 { get { return fA3; } set { fA3 = value; } }
        public double SA { get { return sA; } set { sA = value; } }
        public double S { get { return s; } set { s = value; } }
        public double L { get { return l; } set { l = value; } }
        public double B { get { return b; } set { b = value; } }
        public double G { get { return g; } set { g = value; } }
        public double BogG { get { return bogG; } set { bogG = value; } }
        public double DHK { get { return dHK; } set { dHK = value; } }
        public double WS { get { return wS; } set { wS = value; } }
        public double Dp { get { return dp; } set { dp = value; } }
        public int Wmin { get { return wmin; } set { wmin = value; } }
        public double Sv { get { return sv; } set { sv = value; } }
        public double TCC { get { return tCC; } set { tCC = value; } }
        public double GPH { get { return gPH; } set { gPH = value; } }
        public double TACIL { get { return tACIL; } set { tACIL = value; } }
        public double TACIM { get { return tACIM; } set { tACIM = value; } }
        public double TACIH { get { return tACIH; } set { tACIH = value; } }
        public double TAUDL { get { return tAUDL; } set { tAUDL = value; } }
        public double TAUDM { get { return tAUDM; } set { tAUDM = value; } }
        public double TAUDH { get { return tAUDH; } set { tAUDH = value; } }
        public double SAS { get { return sAS; } set { sAS = value; } }
        public double SAA { get { return sAA; } set { sAA = value; } }
        public double CW { get { return cW; } set { cW = value; } }
        public double TAU3 { get { return tAU3; } set { tAU3 = value; } }
        public double TAU4 { get { return tAU4; } set { tAU4 = value; } }
        public double TAU5 { get { return tAU5; } set { tAU5 = value; } }
        public double TAU6 { get { return tAU6; } set { tAU6 = value; } }
        public double TAU7 { get { return tAU7; } set { tAU7 = value; } }
        public double TAU8 { get { return tAU8; } set { tAU8 = value; } }
        public double TAU10 { get { return tAU10; } set { tAU10 = value; } }
        public double TAD3 { get { return tAD3; } set { tAD3 = value; } }
        public double TAD4 { get { return tAD4; } set { tAD4 = value; } }
        public double TAD5 { get { return tAD5;} set { tAD5 = value; } }
        public double TAD6 { get { return tAD6; } set { tAD6 = value; } }
        public double TAD7 { get { return tAD7; } set { tAD7 = value; } }
        public double TAD8 { get { return tAD8; } set { tAD8 = value; } }
        public double TAD10 { get { return tAD10; } set { tAD10 = value; } }
        public double TACI3 { get { return tACI3; } set { tACI3 = value; } }
        public double TACI4 { get { return tACI4; } set { tACI4 = value; } }
        public double TACI5 { get { return tACI5; } set { tACI5 = value; } }
        public double TACI6 { get { return tACI6; } set { tACI6 = value; } }
        public double TACI7 { get { return tACI7; } set { tACI7 = value; } }
        public double TACI8 { get { return tACI8; } set { tACI8 = value; } }
        public double TACI10 { get { return tACI10; } set { tACI10 = value; } }
        public double PLTCI { get { return pLTCI; } set { pLTCI = value; } }
        public double PLCDI { get { return pLDCI; } set { pLDCI = value; } }
        public double ECI { get { return eCI; } set { eCI = value; } }
        public double PLTUD { get { return pLTUD; } set { pLTUD = value; } }
        public double PLDUD { get { return pLDUD; } set { pLDUD = value; } }
        public double EUD { get { return eUD; } set { eUD = value; } }

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
            int i = 1; //todo remove
        }

        public static string boatsToStringSimpel(List<Boat> boats) {
            string text = "";
            foreach (Boat boat in Boat.boats) {
                text += boat.Certifikat + "  -  " + boat.BaadType + "  -  " + boat.Nation + " " + boat.SejlNummer + " - " + boat.BaadNavn +"\r\n";
            }
            return text;
        }

        public static string boatsToStringSort(List<Boat> boats) {
            string text = "";
            foreach (Boat boat in Boat.boats) {
                text += boat.Certifikat + "  -  " + boat.BaadNavn + "  -  " + boat.Nation + " " + boat.SejlNummer + "\r\n";
            }
            return text;
        }

        public static string boatsToStringGrouping(List<Boat> boats)
        {
            string text = "";
            foreach (Boat boat in Boat.boats)
            {
                text += boat.Certifikat + "  -  " + boat.BaadNavn + "  -  " + boat.Nation + " " + boat.SejlNummer + " - " + boat.groupeId + "\r\n";
            }
            return text;
        }


        public static string boatsToCsvString(List<Boat> boats) {
            string text = "Certifikat;Baadnavn;Nation;SejlNummer;groupe;SV;\r\n";
            foreach(Boat boat in Boat.boats) {
                text += boat.Certifikat + ";";
                text += boat.BaadNavn + ";";
                text += boat.Nation + ";";
                text += boat.SejlNummer + ";";
                text += boat.groupeId + ";";
                text += boat.Sv.ToString() + ";";

                text += "\r\n";
            }
            return text;
        }
    }
}
