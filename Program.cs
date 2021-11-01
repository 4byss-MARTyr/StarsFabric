using System;

namespace FabricStars
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(135);
            for(int i = 0; i<15; i++)
            {
                
                Star star = Factory.CreateStar((uint)rnd.Next(0,2000));
                star.Explode();
            }
        }
    }
}
