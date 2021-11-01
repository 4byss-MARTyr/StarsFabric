using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricStars
{
    class Factory
    {
        private const uint RED_DWARF_MASS = 0;
        private const uint WHITE_DWARF_MASS = 251;
        private const uint YELLOW_DWARF_MASS = 751;
        private const uint BLUE_SUPER_GIANT_MASS = 1501;

        public static Star CreateStar(uint mass)
        {
            if (mass < WHITE_DWARF_MASS && mass >= RED_DWARF_MASS)
                return new RedDwarf();
            else if (mass < YELLOW_DWARF_MASS && mass >= WHITE_DWARF_MASS)
                return new WhiteDwarf();
            else if (mass < BLUE_SUPER_GIANT_MASS && mass >= YELLOW_DWARF_MASS)
                return new YellowDwarf(mass);
            else
                return new BlueSuperGiant();

        }
    }
}
