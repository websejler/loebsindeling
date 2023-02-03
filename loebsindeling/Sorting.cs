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
	}
}
