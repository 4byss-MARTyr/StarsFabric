using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricStars
{
    public abstract class Star
    {
        public abstract void Explode();
    }

    public class RedDwarf : Star
    {
        public override void Explode()
        {
            Console.WriteLine("Red Dwarf doesn't explode.");
        }
    }

    public class WhiteDwarf : Star
    {
        public override void Explode()
        {
            Console.WriteLine("White Dwarf doesn't explode.");
        }
    }

    public class YellowDwarf : Star
    {
        public uint Mass { get; set; } = 1000;
        public override void Explode()
        {
            if (Mass > 1000)
                Console.WriteLine("Yellow Dwarf: BANG!!!");
            else
                Console.WriteLine("Yellow Dwarf: nothing happens.");
        }

        public YellowDwarf(uint mass)
        {
            Mass = mass;
        }
    }
    public class BlueSuperGiant : Star
    {
        public override void Explode()
        {
            Console.WriteLine("Blue Super Giant slowly becomes a black hole.");
        }
    }
}
