using System;
using System.Collections.Generic;

namespace loebsindeling {
    internal class Sorting
    {
        public const double Fn = 0.28;
        public static List<Boat> svSorting(List<Boat> boatList)
        {
            foreach (Boat boat in boatList)
            {
                boat.score = boat.Sv;
                boat.sorted = true;
            }
            boatList.Sort(delegate (Boat x, Boat y)
            {
                if (x.score == y.score)
                {
                    return 0;
                }
                else if (x.score > y.score)
                {
                    return 1;
                }
                else
                {
                    return -1;
                };
            });
            return boatList;
        }

        public static List<Boat> tASortering(List<Boat> boatList, int upAndDownCount, int circleCount, double LightWindWeight, double mediumWindWeight, double hardWindWeight)
        {
            //sort for tacil
            boatList.Sort(delegate (Boat x, Boat y)
            {
                if (x.TACIL == y.TACIL)
                {
                    return 0;
                }
                else if (x.TACIL > y.TACIL)
                {
                    return 1;
                }
                else
                {
                    return -1;
                };
            });
            int i = 1;
            foreach (Boat boat in boatList)
            {
                boat.ints.Add(i);
                i++;
            }
            boatList.Sort(delegate (Boat x, Boat y)
            {
                if (x.TACIM == y.TACIM)
                {
                    return 0;
                }
                else if (x.TACIM > y.TACIM)
                {
                    return 1;
                }
                else
                {
                    return -1;
                };
            });
            i = 1;
            foreach (Boat boat in boatList)
            {
                boat.ints.Add(i);
                i++;
            }
            boatList.Sort(delegate (Boat x, Boat y)
            {
                if (x.TACIH == y.TACIH)
                {
                    return 0;
                }
                else if (x.TACIH > y.TACIH)
                {
                    return 1;
                }
                else
                {
                    return -1;
                };
            });
            i = 1;
            foreach (Boat boat in boatList)
            {
                boat.ints.Add(i);
                i++;
            }
            boatList.Sort(delegate (Boat x, Boat y)
            {
                if (x.TAUDL == y.TAUDL)
                {
                    return 0;
                }
                else if (x.TAUDL > y.TAUDL)
                {
                    return 1;
                }
                else
                {
                    return -1;
                };
            });
            i = 1;
            foreach (Boat boat in boatList)
            {
                boat.ints.Add(i);
                i++;
            }
            boatList.Sort(delegate (Boat x, Boat y)
            {
                if (x.TAUDM == y.TAUDM)
                {
                    return 0;
                }
                else if (x.TAUDM > y.TAUDM)
                {
                    return 1;
                }
                else
                {
                    return -1;
                };
            });
            i = 1;
            foreach (Boat boat in boatList)
            {
                boat.ints.Add(i);
                i++;
            }
            boatList.Sort(delegate (Boat x, Boat y)
            {
                if (x.TAUDH == y.TAUDH)
                {
                    return 0;
                }
                else if (x.TAUDH > y.TAUDH)
                {
                    return 1;
                }
                else
                {
                    return -1;
                };
            });
            i = 1;
            foreach (Boat boat in boatList)
            {
                boat.ints.Add(i);
                boat.score = (boat.ints[0] * LightWindWeight + boat.ints[1] * mediumWindWeight + boat.ints[2] * hardWindWeight) * circleCount + (boat.ints[3] * LightWindWeight + boat.ints[4] * mediumWindWeight + boat.ints[5] * hardWindWeight) * upAndDownCount;
                boat.sorted = true;
                i++;
            }
            boatList.Sort(delegate (Boat x, Boat y)
            {
                if (x.score == y.score)
                {
                    return 0;
                }
                else if (x.score > y.score)
                {
                    return 1;
                }
                else
                {
                    return -1;
                };
            });
            return boatList;
        }

        public static List<Boat> dHCDL(List<Boat> boatList, string windVarName)
        {
            foreach (Boat boat in boatList)
            {
                double vmgUpVarMs = (3600 / boat.getDataDoubleCast(windVarName)) * 0.5144;
                double rl = (vmgUpVarMs * vmgUpVarMs) / (Fn * Fn * 9.81);
                double dhwl = boat.LOA - boat.OA - boat.OF;
                boat.score = (dhwl + rl) / 2;
                boat.sorted = true;
            }
            boatList.Sort(delegate (Boat x, Boat y)
            {
                if (x.score == y.score)
                {
                    return 0;
                }
                else if (x.score > y.score)
                {
                    return 1;
                }
                else
                {
                    return -1;
                };
            });
            return boatList;
        }
    }
}
