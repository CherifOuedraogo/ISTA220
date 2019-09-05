/*****************************
 * Name:Quiz 04***************
 * Author: Cherif Ouedraogo***
 * Date: July 25, 2019********/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test04
{
    class Program
    {
        class Firearm
        {
            string name = "";
            string sound = "";

            public Firearm(string aName, string aSound)
            {
                name = aName;
                sound = aSound;
            }
            public string FirearmFire()
            {
                Console.WriteLine($" I am a {name} and go {sound}");
                return "";
            }
            static void Main(string[] args)
            {
                Console.WriteLine("This is Test 04\n");
                Firearm firearm1 = new Firearm("shotgun", "Boom");
                Firearm firearm2 = new Firearm("Rifle", "Bang");
                Firearm firearm3 = new Firearm("Pistol", "Pop");
                Console.WriteLine(firearm1.FirearmFire());
                Console.WriteLine(firearm2.FirearmFire());
                Console.WriteLine(firearm3.FirearmFire());
                Console.ReadLine();
            }
            
        }
    }
}
