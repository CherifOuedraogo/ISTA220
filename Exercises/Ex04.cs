/*****************************
* Name: C# Ex04
* Author: Cherif Ouedraogo
* Date: July 26, 2019*********/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEx04
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("A day in the life of farm animals......\n");

Console.WriteLine("Two Horses at a farm networking event!!!!!\n");

Horse horse1 = new Horse("Zorro", "Brown", "HIHAAAH", " Fresh Grass");
Horse horse2 = new Horse("Mr QuagMayer", "Grey", "Neigh", " Grinded Corn");
Console.WriteLine(horse1.HorseSpeaks());
Console.WriteLine(horse1.HorseEats());
Console.WriteLine(horse2.HorseSpeaks());
Console.WriteLine(horse2.HorseEats());
Console.ReadLine();
/**************************************************************/
Console.WriteLine("Three more animals join the networking event on the farm!!!!\n");
Snake snake1 = new Snake("Kaa", "chingchingching");
Dog dog1 = new Dog("Rufus", "wouf wouf");
Bird bird1 = new Bird("Eagle", "kakaaa kakaaa ");
Console.WriteLine(bird1.BirdSpeaks());
Console.WriteLine(dog1.DogSpeaks());
Console.WriteLine(snake1.SnakeSpeaks());
Console.ReadLine();
}
/*********************************Classes**********************************/

class Horse
{ // Creating Class Horse with two methods and two constructors.
public string name = "";
public string color = "";
public string sound = "";
public string food = "";
public Horse()
{

}
public Horse(string aName, string aColor, string aSound, string aFood)
{
name = aName;
color = aColor;
sound = aSound;
food = aFood;
}
public string HorseSpeaks()
{
Console.WriteLine($"Hello my name is {name} and i am a {color} horse on a farm. I say {sound}");
return "";
}
public string HorseEats()
{
Console.WriteLine($"My favorite food is {food}.\n Soooo Yummy!!! It's nice to meet you.");
return "";
}
// Creating class Dog with one constructor and one method.
class Dog
{
string name = "";
string sound = "";

public Dog(string aName, string aSound)
{
name = aName;
sound = aSound;
}
public string DogSpeaks()
{
Console.WriteLine($"Hello. My name is {name} and before i bite i warn by saying {sound}");
return "";
}
//creating a class Bird with one constructor and one method.
class Bird
{
string name = "";
string sound = "";

public Bird(string aName, string aSound)
{
name = aName;
sound = aSound;
}
public string BirdSpeaks()
{
Console.WriteLine($"Hello from Up here. My name is {name} and before i land i yell {sound}");
return "";
}
}
// creating a class Snake with one constructor and one method.
class Snake
{
string name = "";
string sound = "";
public Snake(string aName, string aSound)
{
name = aName;
sound = aSound;
}
public string SnakeSpeaks()
{
Console.WriteLine($" Hello everyone my name is {name} the Texan Rattle Snake.\n Beware when i say {sound}");
return "";

}
}
}

}
}

}