namespace WarriorWars;
{
    class Warrior{
        private static int STARTINGHEALTH = 100;
        
        private Faction faction;
        
        private int health;
        private string name;
        private bool isAlive;

        private Weapon weapon;
        private Armor armor;
        
        public Warrior(){
            this.health = STARTINGHEALTH;
        }
    }
}