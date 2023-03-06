using System;
using System.Collections.Generic;

namespace loebsindeling {
    internal class Sorting {
		public static List<Boat> svSorting(List<Boat> boatList) {
            foreach (Boat boat in boatList)
            {
                boat.score = boat.Sv;
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

		public static List<Boat> dh2022Sort(List<Boat> boatList, int upAndDownCount, int circleCount)
		{
			//sort for tacil
            boatList.Sort(delegate (Boat x, Boat y) {
                if (x.TACIL == y.TACIL)
                {
                    return 0;
                } else if (x.TACIL > y.TACIL)
                {
                    return 1;
                } else {
                    return -1;
                };
            });
			int i = 1;
			foreach (Boat boat in boatList)
			{
                boat.ints.Add(i);
				i++;
			}
            boatList.Sort(delegate (Boat x, Boat y) {
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
            boatList.Sort(delegate (Boat x, Boat y) {
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
            boatList.Sort(delegate (Boat x, Boat y) {
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
            boatList.Sort(delegate (Boat x, Boat y) {
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
            boatList.Sort(delegate (Boat x, Boat y) {
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
                boat.score = (boat.ints[0] + boat.ints[1] + boat.ints[2])*circleCount + (boat.ints[3] + boat.ints[4] + boat.ints[5]) * upAndDownCount;
                i++;
            }
            boatList.Sort(delegate (Boat x, Boat y) {
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
