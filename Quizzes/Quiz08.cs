//Name: Quiz08
//Author: Cherif Ouedraogo
//Date: August, 20 2019


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" This is TEST 08 ");
            RaceHorse myfirsthorse = new RaceHorse(" Mustang ", 7 ," Brown");
            RaceHorse mysecondhorse = new RaceHorse(" Thunder ", 9 , " Black ");
            RaceHorse mythirdhorse = new RaceHorse(" Turtle ", 16 , " White ");
            Console.WriteLine(myfirsthorse.ToString());
            Console.WriteLine(mysecondhorse.ToString());
            Console.WriteLine(mythirdhorse.ToString());

        }
        
    }
    class RaceHorse
    {
        private string _name;
        private int _age;
        private string _color;
        static int count = 0;
        private int _HorseNumber;

        public RaceHorse( string Name, int Age, string Color)
        {
            count++;
            _HorseNumber = count;
            _name = Name;
            _age = Age;
            _color = Color;
        }
         public string Name
        {
            get => this._name;
            set => _name=value;
        }
        public int Age
        {
            get => this._age;
            set => this._age = value;
        }
        public string Color
        {
            get => this._color;
            set => this._color = value;
        }
        public int Horsenumber
        {
            get => this._HorseNumber;
        }
        public override string ToString()
        {
            return _HorseNumber.ToString() + "." +" RaceHorse Name :"+ Name.ToString() + " , Age: " + Age.ToString()
                                           + " "+ " , Color: " + Color.ToString();
            
        }
     
    }

}
