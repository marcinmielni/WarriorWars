using WarriorWars.Enum;
using WarriorWars;
using System;
namespace WarriorWars{
    class Program{
        static Random rng = new Random();
        static void Main(){
            Warrior goodGuy = new Warrior("Bob", Faction.GoodGuy);
            Warrior badGuy = new Warrior("George", Faction.BadGuy);

            while(goodGuy.IsAlive && badGuy.IsAlive){
                if(rng.Next(0,10) < 5){
                    goodGuy.Attack(badGuy);
                }
                else if(rng.Next(0,10) > 5){
                    badGuy.Attack(goodGuy);
                
                }
            }
        }
    }
}
