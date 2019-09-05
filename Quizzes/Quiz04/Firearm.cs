using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test04
{
    class Firearm
    {
        string name = "";
        string sound = "";

        public Firearm (string aName, string aSound)
        {
            name = aName;
            sound = aSound;
        }
        public string FirearmFire()
        {
            Console.WriteLine($" I am a {name} and go {sound}");
            return "";
        }
    }
}
