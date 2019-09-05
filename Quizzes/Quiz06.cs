/*Name: Csharp Quiz 06*********
 * Author: Cherif Ouedraogo
 * Date: August 8,2019********/


using System;
namespace CSharp_Quiz06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Test 06");
            Console.WriteLine();
            Firearm myfirearm = new Firearm();
            Shotgun myshotgun = new Shotgun();
            Rifle myrifle = new Rifle();
            Pistol mypistol = new Pistol();
            myfirearm.Type();
            myshotgun.Type();
            myrifle.Type();
            mypistol.Type();
        }
    }
    class Firearm
    {
        public virtual void Type()
        {
            Console.WriteLine("I am a firearm and I shoot things.");
        }
    }
    class Shotgun : Firearm
    {
        public override void Type()
        {
            Console.WriteLine("I am a shotgun and I go Boom. ");
        }
    }
    class Rifle : Firearm
    {
        public override void Type()
        {
            Console.WriteLine("I am a rifle and I go Bang.");
        }
    }
    class Pistol : Firearm
    {
        public override void Type()
        {
            Console.WriteLine("I am a pistol I go Pop.");
        }
    }
}
