/*Name: C# Exercise06******
 * Author: Cherif Ouedraogo
 * Date:8/10/2019**********/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Joint-Base Rescue Operation \n ");
            MilitaryUnit mymilitaryUnit = new MilitaryUnit();
            Console.WriteLine(mymilitaryUnit.Types());
            Console.WriteLine(mymilitaryUnit.Missions());
            Console.WriteLine(mymilitaryUnit.Command());
            Console.WriteLine(mymilitaryUnit.Equipment());
            Console.WriteLine(mymilitaryUnit.Brief());
            Console.WriteLine();
            AirForce myairforce = new AirForce();
            Console.WriteLine(myairforce.Types());
            Console.WriteLine(myairforce.Missions());
            Console.WriteLine(myairforce.Command());
            Console.WriteLine(myairforce.Equipment());
            Console.WriteLine(myairforce.Brief());
            Mission1 mymission1 = new Mission1();
            Console.WriteLine(mymission1.Missions());
            Console.WriteLine(mymission1.Equipment());
            Equipment01 myequipment01 = new Equipment01();
            Console.WriteLine(myequipment01.Equipment());
            Console.WriteLine();
            Marines mymarines = new Marines();
            Console.WriteLine(mymarines.Types());
            Console.WriteLine(mymarines.Missions());
            Console.WriteLine(mymarines.Command());
            Console.WriteLine(mymarines.Equipment());
            Console.WriteLine(mymarines.Brief());
            Mission2 mymission2 = new Mission2();
            Console.WriteLine(mymission2.Missions());
            Console.WriteLine(mymission2.Equipment());
            Equipment2 myequipment2 = new Equipment2();
            Console.WriteLine(myequipment2.Equipment());
            Console.WriteLine();
            SpecialOps myspecialops = new SpecialOps();
            Console.WriteLine(myspecialops.Types());
            Console.WriteLine(myspecialops.Missions());
            Console.WriteLine(myspecialops.Command());
            Console.WriteLine(myspecialops.Equipment());
            Console.WriteLine(myspecialops.Brief());
            Mission3 mymission3 = new Mission3();
            Console.WriteLine(mymission3.Missions());
            Console.WriteLine(mymission3.Equipment());
            Equipment3 myequipment3 = new Equipment3();
            Console.WriteLine(myequipment3.Equipment());
            Console.WriteLine();
            Army myarmy = new Army();
            Console.WriteLine(myarmy.Types());
            Console.WriteLine(myarmy.Missions());
            Console.WriteLine(myarmy.Command());
            Console.WriteLine(myarmy.Equipment());
            Console.WriteLine(myarmy.Brief());
            Mission4 mymission4 = new Mission4();
            Console.WriteLine(mymission4.Missions());
            Console.WriteLine(mymission4.Equipment());
            Equipment4 myequipment4 = new Equipment4();
            Console.WriteLine(myequipment4.Equipment());
            Console.WriteLine();
            Allies myallies = new Allies();
            Console.WriteLine(myallies.Types());
            Console.WriteLine(myallies.Missions());
            Console.WriteLine(myallies.Command());
            Console.WriteLine(myallies.Equipment());
            Console.WriteLine(myallies.Brief());
            Mission5 mymission5 = new Mission5();
            Console.WriteLine(mymission5.Missions());
            Console.WriteLine(mymission5.Equipment());
            Equipment5 myequipment5 = new Equipment5();
            Console.WriteLine(myequipment5.Equipment());
            Console.WriteLine();
            JointBase myjointbase = new JointBase();
            Console.WriteLine(myjointbase.Types());
            Console.WriteLine(myjointbase.Missions());
            Console.WriteLine(myjointbase.Command());
            Console.WriteLine(myjointbase.Equipment());
            Console.WriteLine(myjointbase.Brief());
            Mission6 mymission6 = new Mission6();
            Console.WriteLine(mymission6.Missions());
            Mission7 mymission7 = new Mission7();
            Console.WriteLine(mymission7.Missions());
            Console.WriteLine();
        }
    }
    class MilitaryUnit
    {
        public MilitaryUnit()
            {
            }
        public virtual string Types()
        {
            return " This is a Joint-Base Rescue Command ";
        }
        public virtual string Missions()
        {
            return " The mission is to perform rescue operation jointly with other "+ 
                  " components in order to "+ 
                  " extract valuable asset from an undisclosed hostile territory ";
        }
        public virtual string Command()
        {
            return " All commands report to Joint-Base command headquarters ";
        }
        public virtual string Equipment()
        {
            return " All equipment requested and ready for mission";
        }
        public virtual string Brief()
        {
            return " Mission briefing and debriefing conducted";
        }

    }
    class AirForce: MilitaryUnit
    {
        public override string Types()
        {
            return " Air Force [ThunderBolt] command unit has joined the mission";
        }
        public override string Missions()
        {
            return " Their Mission is to provide air superiority and overwatch for ground operations ";
        }
        public override string Command()
        {
            return " Air Force Commander Greg Stephens, airman BlueFalcon and pilot IronEagle are on orders for the rescue mission ";
        }
        public override string Equipment()
        {
            return " Unit has drones and fighter jets ready for misison ";
        }
        public override string Brief()
        {
            return " Commander Greg to his unit: Make them Fly! The brief is completed. More details to follow and Mission is a GO ";
        }

    }
    class Marines: MilitaryUnit
    {
        public override string Types()
        {
            return " Marines Quick Reaction Force has joined the mission ";
        }
        public override string Missions()
        {
            return " Their Mission is to provide assistance to ground operations ";
        }
        public override string Command()
        {
            return " Commander Lorenzon Carti, Gunnery Sgt HotHead ,Corporal ProudMarine1 and Squad A are on orders for the rescue mission ";
        }
        public override string Equipment()
        {
            return " Marines force has requested and gained weapons, ammuniton and transportation for misison ";
        }
        public override string Brief()
        {
            return " Commander Lorenzo to his unit: Retreat Hell Marines!! The brief is completed. More details to follow and Mission is a GO";
        }

    }
    class SpecialOps : MilitaryUnit
    {
        public override string Types()
        {
            return " Special Forces Extraction unit has joined the mission ";
        }
        public override string Missions()
        {
            return " Their Mission is to take lead and coordinate ground operations for rescue mission ";
        }
        public override string Command()
        {
            return " Commander James Smelser and Team Hellfire are on orders for the rescue mission ";
        }
        public override string Equipment()
        {
            return " Special force unit has requested and gained weapons, ammuniton and transportation for misison ";
        }
        public override string Brief()
        {
            return " Commander Smelser to his unit: Let's give them Hell!Schooack them all!" +  
                   " The brief is completed more details to follow and Mission is a GO";
        }

    }
    class Army : MilitaryUnit
    {
        public override string Types()
        {
            return " Army Rapid Intervention unit has joined the mission ";
        }
        public override string Missions()
        {
            return " Their Mission is to provide firepower and cover the extraction unit during the ground operations for rescue mission ";
        }
        public override string Command()
        {
            return " Commander Derek Cobb and Platoon Sergeant Sean Zizter lead Team Dark Horse and Team " +
                   " and Team Nightstalkers for the rescue mission";
        }
        public override string Equipment()
        {
            return " The two Army units have requested and gained weapons, ammuniton and transportation for misison ";
        }
        public override string Brief()
        {
            return " Commander Cobb to his unit: Hooah Soldiers!! The brief is completed more details to follow and Mission is a GO ";
        }

    }
    class JointBase : MilitaryUnit
    {
        public override string Types()
        {
            return " Joint-Base Rescue Mission Command has joined the mission ";
        }
        public override string Missions()
        {
            return " Their Mission is to coordinate and plan the rescue misison from start to end, and provide logistical support ";
        }
        public override string Command()
        {
            return " Commander Charles Carter, intelligence data analyst Adam Francis, Communication support expert Edmundo Luna " +
                   " Crisis management Candina Janicki are all head of their respective sections ";
        }
        public override string Equipment()
        {
            return " The command center has requested and obtained all necessary equipment for the misison ";
        }
        public override string Brief()
        {
            return " Commander Carter: Let's Bring them all Home!! The brief is completed. More details to follow and Mission is a GO ";
        }

    }
    class Allies : MilitaryUnit
    {
        public override string Types()
        {
            return " ON-Site Ally forces Command has joined the mission ";
        }
        public override string Missions()
        {
            return " Their Mission is to assist the rescue misison from start to end, and provide logistical support to ground elements.";
        }
        public override string Command()
        {
            return " Commander Yamba Ouandaogo and his assistant Private Awol, along with the local allies cover entry/exit points. ";
        }
        public override string Equipment()
        {
            return " The allies forces have requested and obtained all necessary equipment for the misison ";
        }
        public override string Brief()
        {
            return " Commander Yamba:Let's do this right!! The brief is completed. More details to follow and Mission is a GO ";
        }

    }
    class Mission1: AirForce
    {
        public Mission1() 
        {
            
        }
        public override string Missions()
        {
            return " Commander Greg Gives out the mission details. Personnel and equipment is loaded and ready to go ";
        }
        public override string Equipment()
        {
            return " Drone pilot is Airman Blue Falcon and Raptor pilot is Top Gun ";
        }
    }
    class Equipment01: Mission1
    {
        public override string Equipment()
        {
            return " The equipments for Air Force include MQ-9 Reaper Hunter with three Hellfire II, and F-35 Fully loaded for overwatch ";
        }
    }
    class Mission2 : Marines
    {
        public Mission2()
        {

        }
        public override string Missions()
        {
            return " Commander Lorenzo Gather the troops and gives the mission details. Personnel and equipment is loaded and ready to go ";
        }
        public override string Equipment()
        {
            return " Helicopter pilot is CPT Lightning and convoy commander for ground forces is Gunnery SGT Yells ";
        }
    }
    class Equipment2 : Mission2
    {
        public override string Equipment()
        {
            return " The equipments for the Marines include Sikorsky CH-53K Transport Helicopter, and two strikers for ground movement ";
        }
    }
    class Mission3 : SpecialOps
    {
        public Mission3()
        {

        }
        public override string Missions()
        {
            return " Commander Smelser Gather the team and gives the mission details. Personnel and equipment is loaded and ready to go ";
        }
        public override string Equipment()
        {
            return " Helicopter pilot is CW3 Nightmare and convoy commander for ground forces is SSG KickIt ";
        }
    }
    class Equipment3 : Mission3
    {
        public override string Equipment()
        {
            return " The equipments for the SpecialOps include BlackHawk fully armed and three armored HMMVs for ground movement ";
        }
    }
    class Mission4 : Army
    {
        public Mission4()
        {

        }
        public override string Missions()
        {
            return " Commander Cobb and SFC Zizter Gather the team  and give the mission details." +
                   " Personnel and equipment get loaded and ready to go ";
        }
        public override string Equipment()
        {
            return " Convoy commander for ground forces is SSG Spartan ";
                
        }
    }
    class Equipment4 : Mission4
    {
        public override string Equipment()
        {
            return " The equipments for the Army include 2 fully armed Bradleys, 2 Buffalos and three armored HMMVs for ground movement ";
        }
    }
    class Mission5 : Allies
    {
        public Mission5()
        {

        }
        public override string Missions()
        {
            return " Commander Yamba gathers his troops and gives the mission details," +
                   "  and personnel and equipment is loaded and ready to go. Private Awol is missing!!! ";
        }
        public override string Equipment()
        {
            return " Convoy commanders for support forces are SFC RoughRider and SSG Avenger ";
        }
    }
    class Equipment5 : Mission5
    {
        public override string Equipment()
        {
            return " The equipments for the Allies include two M1 Abrahms and five armored HMMVs for ground movement";
        }
    }
    class Mission6 : JointBase
    {
        public Mission6()
        {

        }
        public override string Missions()
        {
            return " Commander Carter reviews all mission requirements announces that everything is ready for execution. MISSION IS A GO ";
        }
    }
    class Mission7: Mission6
    {
        public Mission7()
        {
        }
            public override string Missions()
        {
            return" All Missions conducted successfully and all units have been back and debriefed. Rescue Mission  is Over ";
        }
    }
}
