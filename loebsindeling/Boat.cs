using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Excel = Microsoft.Office.Interop.Excel;

namespace loebsindeling
{
    internal class Boat
    {   
        public static List<Boat> boats = new List<Boat>();

        private static Dictionary<string, int> dataLocationIndex = new Dictionary<string, int>();

        private int certifikat;
        private string baadNavn;
        private string baadType;
        private string nation;
        private int sejlNummer;
        private int byggeAar;
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
            newdata = newdata.Replace(';', ',');
            string[] dataArray = newdata.Split(',');
            for(int i = 0; i < dataArray.Length; i++) {
                dataArray[i] = dataArray[i].Replace('.', ',');
            }
            try
            {
                try { Int32.TryParse(dataArray[dataLocationIndex["certifikat"]], out certifikat); } catch (KeyNotFoundException e) { certifikat = -1; };
                try { baadNavn = dataArray[dataLocationIndex["baadnavn"]]; } catch (KeyNotFoundException e) { baadNavn = "N/A"; };
                try { nation = dataArray[dataLocationIndex["nation"]]; } catch (KeyNotFoundException e) { nation = "N/A"; };
                try { Int32.TryParse(dataArray[dataLocationIndex["sejlnummer"]], out sejlNummer); } catch (KeyNotFoundException e) { sejlNummer = -1; };
                try { Int32.TryParse(dataArray[dataLocationIndex["byggeaar"]], out byggeAar); } catch (KeyNotFoundException e) { byggeAar = -1; };
                try { baadType = dataArray[dataLocationIndex["baadtypenavn"]]; } catch (KeyNotFoundException e) { baadType = "N/A"; };
                try { Int32.TryParse(dataArray[dataLocationIndex["klassestatusid"]], out klasseStatusId); } catch (KeyNotFoundException e) { klasseStatusId = -1; };
                try { Int32.TryParse(dataArray[dataLocationIndex["rigsejlid"]], out rigSejlId); } catch (KeyNotFoundException e) { rigSejlId = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["e"]], out e); } catch (KeyNotFoundException ee) { e = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["p"]], out p); } catch (KeyNotFoundException e) { p = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["hb"]], out hB); } catch (KeyNotFoundException e) { hB = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["mgm"]], out mGM); } catch (KeyNotFoundException e) { mGM = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["mgu"]], out mGU); } catch (KeyNotFoundException e) { mGU = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["tmax"]], out tmax); } catch (KeyNotFoundException e) { tmax = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["lp"]], out lP); } catch (KeyNotFoundException e) { lP = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["fsp"]], out fSP); } catch (KeyNotFoundException e) { fSP = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["spl"]], out sPL); } catch (KeyNotFoundException e) { sPL = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["j"]], out j); } catch (KeyNotFoundException e) { j = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["tps"]], out tPS); } catch (KeyNotFoundException e) { tPS = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["jhw"]], out jHW); } catch (KeyNotFoundException e) { jHW = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["isp"]], out iSP); } catch (KeyNotFoundException e) { iSP = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["sl"]], out sL); } catch (KeyNotFoundException e) { sL = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["slu"]], out sLU); } catch (KeyNotFoundException e) { sLU = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["sle"]], out sLE); } catch (KeyNotFoundException e) { sLE = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["sf"]], out sF); } catch (KeyNotFoundException e) { sF = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["smg"]], out sMG); } catch (KeyNotFoundException e) { sMG = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["sfa"]], out sFA); } catch (KeyNotFoundException e) { sFA = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["smga"]], out sMGA); } catch (KeyNotFoundException e) { sMGA = -1; };
                try { Int32.TryParse(dataArray[dataLocationIndex["propelid"]], out propelId); } catch (KeyNotFoundException e) { propelId = -1; };
                try { Boolean.TryParse(dataArray[dataLocationIndex["rf"]], out rF); } catch (KeyNotFoundException e) { rF = false; };
                try { Boolean.TryParse(dataArray[dataLocationIndex["mf"]], out mF); } catch (KeyNotFoundException e) { mF = false; };
                try { Boolean.TryParse(dataArray[dataLocationIndex["hf"]], out hF); } catch (KeyNotFoundException e) { hF = false; };
                try { Int32.TryParse(dataArray[dataLocationIndex["propelid1"]], out propelId1); } catch (KeyNotFoundException e) { propelId1 = -1; };
                try { propelNavn = dataArray[dataLocationIndex["propelnavn"]]; } catch (KeyNotFoundException e) { propelNavn = "N/A"; };
                try { Int32.TryParse(dataArray[dataLocationIndex["skrogid"]], out skrogId); } catch (KeyNotFoundException e) { skrogId = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["gmax"]], out gmax); } catch (KeyNotFoundException e) { gmax = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["sgmax"]], out sGmax); } catch (KeyNotFoundException e) { sGmax = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["fbsb"]], out fBSB); } catch (KeyNotFoundException e) { fBSB = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["fbbb"]], out fBBB); } catch (KeyNotFoundException e) { fBBB = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["sbmax"]], out sBmax); } catch (KeyNotFoundException e) { sBmax = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["udfsb"]], out uDFSB); } catch (KeyNotFoundException e) { uDFSB = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["udfbb"]], out uDFBB); } catch (KeyNotFoundException e) { uDFBB = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["of"]], out oF); } catch (KeyNotFoundException e) { oF = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["oa"]], out oA); } catch (KeyNotFoundException e) { oA = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["udhbmax"]], out uDHBmax); } catch (KeyNotFoundException e) { uDHBmax = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["udhmax"]], out uDHmax); } catch (KeyNotFoundException e) { uDHmax = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["stf"]], out sTF); } catch (KeyNotFoundException e) { sTF = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["af"]], out aF); } catch (KeyNotFoundException e) { aF = -1; };
                try { Int32.TryParse(dataArray[dataLocationIndex["specielid"]], out specielId); } catch (KeyNotFoundException e) { specielId = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["bmax"]], out bmax); } catch (KeyNotFoundException e) { bmax = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["loa"]], out lOA); } catch (KeyNotFoundException e) { lOA = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["d"]], out d); } catch (KeyNotFoundException e) { d = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["k"]], out k); } catch (KeyNotFoundException e) { k = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["kc"]], out kC); } catch (KeyNotFoundException e) { kC = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["wbf"]], out wBF); } catch (KeyNotFoundException e) { wBF = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["wbl"]], out wBL); } catch (KeyNotFoundException e) { wBL = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["wbt"]], out wBT); } catch (KeyNotFoundException e) { wBT = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["wbv"]], out wBV); } catch (KeyNotFoundException e) { wBV = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["ssc"]], out sSC); } catch (KeyNotFoundException e) { sSC = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["sst"]], out sST); } catch (KeyNotFoundException e) { sST = -1; };
                try { Int32.TryParse(dataArray[dataLocationIndex["kfid"]], out kFId); } catch (KeyNotFoundException e) { kFId = -1; };
                try { Boolean.TryParse(dataArray[dataLocationIndex["kontrolvejet"]], out kontrolVejet); } catch (KeyNotFoundException e) { kontrolVejet = false; };
                try { Boolean.TryParse(dataArray[dataLocationIndex["kontrolmaalt"]], out kontrolMaalt); } catch (KeyNotFoundException e) { kontrolMaalt = false; };
                try { Boolean.TryParse(dataArray[dataLocationIndex["kontrolkrenget"]], out kontrolKrenget); } catch (KeyNotFoundException e) { kontrolKrenget = false; };
                try { Int32.TryParse(dataArray[dataLocationIndex["propelid2"]], out propelId2); } catch (KeyNotFoundException e) { propelId2 = -1; };
                try { propelNavn1 = dataArray[dataLocationIndex["propelnavn1"]]; } catch (KeyNotFoundException e) { propelNavn1 = "N/A"; };
                try { Int32.TryParse(dataArray[dataLocationIndex["kfid1"]], out kFId1); } catch (KeyNotFoundException e) { kFId1 = -1; };
                try { kFTekst = dataArray[dataLocationIndex["kftekst"]]; } catch (KeyNotFoundException e) { kFTekst = "N/A"; };
                try { Int32.TryParse(dataArray[dataLocationIndex["baadid"]], out baadId); } catch (KeyNotFoundException e) { baadId = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["ssa"]], out sSA); } catch (KeyNotFoundException e) { sSA = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["fa1"]], out fA1); } catch (KeyNotFoundException e) { fA1 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["fa2"]], out fA2); } catch (KeyNotFoundException e) { fA2 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["fa3"]], out fA3); } catch (KeyNotFoundException e) { fA3 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["sa"]], out sA); } catch (KeyNotFoundException e) { sA = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["s"]], out s); } catch (KeyNotFoundException e) { s = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["l"]], out l); } catch (KeyNotFoundException e) { l = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["b"]], out b); } catch (KeyNotFoundException e) { b = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["g"]], out g); } catch (KeyNotFoundException e) { g = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["bogg"]], out bogG); } catch (KeyNotFoundException e) { bogG = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["dhk"]], out dHK); } catch (KeyNotFoundException e) { dHK = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["ws"]], out wS); } catch (KeyNotFoundException e) { wS = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["dp"]], out dp); } catch (KeyNotFoundException e) { dp = -1; };
                try { Int32.TryParse(dataArray[dataLocationIndex["wmin"]], out wmin); } catch (KeyNotFoundException e) { wmin = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["sv"]], out sv); } catch (KeyNotFoundException e) { sv = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["tcc"]], out tCC); } catch (KeyNotFoundException e) { tCC = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["gph"]], out gPH); } catch (KeyNotFoundException e) { gPH = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["tacil"]], out tACIL); } catch (KeyNotFoundException e) { tACIL = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["tacim"]], out tACIM); } catch (KeyNotFoundException e) { tACIM = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["tacih"]], out tACIH); } catch (KeyNotFoundException e) { tACIH = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["taudl"]], out tAUDL); } catch (KeyNotFoundException e) { tAUDL = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["taudm"]], out tAUDM); } catch (KeyNotFoundException e) { tAUDM = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["taudh"]], out tAUDH); } catch (KeyNotFoundException e) { tAUDH = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["sas"]], out sAS); } catch (KeyNotFoundException e) { sAS = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["saa"]], out sAA); } catch (KeyNotFoundException e) { sAA = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["cw"]], out cW); } catch (KeyNotFoundException e) { cW = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["tau3"]], out tAU3); } catch (KeyNotFoundException e) { tAU3 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["tau4"]], out tAU4); } catch (KeyNotFoundException e) { tAU4 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["tau5"]], out tAU5); } catch (KeyNotFoundException e) { tAU5 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["tau6"]], out tAU6); } catch (KeyNotFoundException e) { tAU6 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["tau7"]], out tAU7); } catch (KeyNotFoundException e) { tAU7 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["tau8"]], out tAU8); } catch (KeyNotFoundException e) { tAU8 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["tau10"]], out tAU10); } catch (KeyNotFoundException e) { tAU10 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["tad3"]], out tAD3); } catch (KeyNotFoundException e) { tAD3 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["tad4"]], out tAD4); } catch (KeyNotFoundException e) { tAD4 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["tad5"]], out tAD5); } catch (KeyNotFoundException e) { tAD5 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["tad6"]], out tAD6); } catch (KeyNotFoundException e) { tAD6 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["tad7"]], out tAD7); } catch (KeyNotFoundException e) { tAD7 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["tad8"]], out tAD8); } catch (KeyNotFoundException e) { tAD8 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["tad10"]], out tAD10); } catch (KeyNotFoundException e) { tAD10 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["taci3"]], out tACI3); } catch (KeyNotFoundException e) { tACI3 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["taci4"]], out tACI4); } catch (KeyNotFoundException e) { tACI4 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["taci5"]], out tACI5); } catch (KeyNotFoundException e) { tACI5 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["taci6"]], out tACI6); } catch (KeyNotFoundException e) { tACI6 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["taci7"]], out tACI7); } catch (KeyNotFoundException e) { tACI7 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["taci8"]], out tACI8); } catch (KeyNotFoundException e) { tACI8 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["taci10"]], out tACI10); } catch (KeyNotFoundException e) { tACI10 = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["pltci"]], out pLTCI); } catch (KeyNotFoundException e) { pLTCI = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["pldci"]], out pLDCI); } catch (KeyNotFoundException e) { pLDCI = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["eci"]], out eCI); } catch (KeyNotFoundException e) { eCI = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["pltud"]], out pLTUD); } catch (KeyNotFoundException e) { pLTUD = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["pldud"]], out pLDUD); } catch (KeyNotFoundException e) { pLDUD = -1; };
                try { Double.TryParse(dataArray[dataLocationIndex["eud"]], out eUD); } catch (KeyNotFoundException e) { eUD = -1; };
            }
            catch (System.IndexOutOfRangeException e)
            {
                throw new InvalidDataException("Data can not be read by programe");
            }

            ints = new List<int>();
            groupeId = 0;
        }

        public int Certifikat { get { return certifikat; } set { certifikat = value; } }
        public string BaadNavn { get { return baadNavn; } set { baadNavn = value; } }
        public string Nation { get { return nation; } set { nation = value; } }
        public int SejlNummer { get { return sejlNummer; } set { sejlNummer = value; } }
        public int GroupeId { get { return groupeId; } set { groupeId = value; } }
        public string BaadType { get { return baadType; } set { baadType = value;} }
        public int ByggeAar { get { return byggeAar; } set { byggeAar = value; } }
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
            string[] lines = {""};
            if (path.EndsWith(".csv"))
            {
                lines = System.IO.File.ReadAllLines(path);
                
            } else if (path.EndsWith(".xlsx"))
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
                            temp = values[i, j].ToString() + ",";
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
            for(int i = 0; i < dataArray.Length; i++)
            {
                dataLocationIndex.Add(dataArray[i].ToLower(), i);
            }
        }

        public static string boatsToStringSimpel(List<Boat> boats) {
            string text = "";
            foreach (Boat boat in Boat.boats) {
                text += boat.Certifikat + "  -  " + boat.BaadType + "  -  " + boat.Nation + " " + boat.SejlNummer + " - " + boat.BaadNavn +"\r\n";
            }
            return text;
        }

        public static object[,] boatsToDataGridViewString(List<Boat> boats)
        {
            object[,] text = new object[boats.Count,5];
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
            string text = "Certifikat;Baadnavn;Nation;SejlNummer;groupe;Soterings tal;\r\n";
            foreach(Boat boat in Boat.boats) {
                text += boat.Certifikat + ";";
                text += boat.BaadNavn + ";";
                text += boat.Nation + ";";
                text += boat.SejlNummer + ";";
                text += boat.groupeId + ";";
                text += boat.score + ";";

                text += "\r\n";
            }
            return text;
        }
    }
}
