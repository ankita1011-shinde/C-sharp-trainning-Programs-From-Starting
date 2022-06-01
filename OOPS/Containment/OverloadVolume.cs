using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Containment
{
    class OverloadVolume
    {
        public  double volume(double r)
        {
            double spherevol = (4 / 3) * (22 / 7) * (r * r * r);
            return spherevol;
           
        }
        public double volume(double h,double r)
        {
            double cylindervol = (22 / 7) * (r * r) * h;
            return cylindervol;
        }
        public double volume(double l,double b,double h)
        {
            double cuboidvol=l*b * h;
            return cuboidvol;
        }
    }

    class VolumeTest
    {
        static void Main(string[] args)
        {
            OverloadVolume vl = new OverloadVolume();

            
           

            Console.WriteLine("Volume of sphere is: " + vl.volume(4));
            Console.WriteLine("Volume ofCylinder is: "+vl.volume(20, 4));
            Console.WriteLine("Volume of cuboid is: "+vl.volume(20, 4, 10));
        }
    }
}
