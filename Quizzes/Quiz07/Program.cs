/* Name: Quiz 07 C#
 * Author: Cherif Ouedraogo
 * Date: August 13, 2019******/


using System;
namespace CsharpQuiz07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Test 7");
            IFirearm myshotgun = new Shotgun();
            IFirearm myrifle = new Rifle();
            IFirearm mypistol = new Pistol();
            Console.WriteLine(myshotgun.WeaponsTypes());
            Console.WriteLine(myrifle.WeaponsTypes());
            Console.WriteLine(mypistol.WeaponsTypes());
        }
    }
    class Shotgun : IFirearm
    {
        public string WeaponsTypes()
        {
            return " I am a shotgun and I go Boom ";
        }
    }
    class Rifle : IFirearm
    {
        public string WeaponsTypes()
        {
            return " I am a rifle and I go Bang ";
        }
    }
    class Pistol : IFirearm
    {
        public string WeaponsTypes()
        {
            return " I am a pistol and I go Pop ";
        }
    }
}
