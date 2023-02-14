using System;
using System.Collections.Generic;

namespace loebsindeling {
    internal class Sorting {
		public static List<Boat> svSorting(List<Boat> boatList) {
			boatList.Sort(delegate (Boat x, Boat y) {
				if (x.Sv == y.Sv) {
					return 0;
				} else if (x.Sv > y.Sv) {
					return 1;
				} else {
					return -1;
				};
			});
			return boatList;
		}

		public static List<Boat> dh2022Sort(List<Boat> boatList, int upAndDownCount, int circleCount)
		{
			//sort for tacil
            boatList.Sort(delegate (Boat x, Boat y) {
                if (x.Tacil == y.Tacil)
                {
                    return 0;
                } else if (x.Tacil > y.Tacil)
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
                if (x.Tacim == y.Tacim)
                {
                    return 0;
                }
                else if (x.Tacim > y.Tacim)
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
                if (x.Tacih == y.Tacih)
                {
                    return 0;
                }
                else if (x.Tacih > y.Tacih)
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
                if (x.Taudl == y.Taudl)
                {
                    return 0;
                }
                else if (x.Taudl > y.Taudl)
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
                if (x.Taudm == y.Taudm)
                {
                    return 0;
                }
                else if (x.Taudm > y.Taudm)
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
                if (x.Taudh == y.Taudh)
                {
                    return 0;
                }
                else if (x.Taudh > y.Taudh)
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
            return null;
		}
	}
}
