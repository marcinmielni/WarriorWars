using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Armor{

    private int goodGuyArmorPoints;
    private int badGuyArmorPoints;
        private int armorPoints;
    public Armor(Faction faction){
        switch(faction){
            case Faction.GoodGuy:
                armorPoints = goodGuyArmorPoints;
                break;
            case Faction.BadGuy:
                armorPoints = badGuyArmorPoints;
                break;
            default:
            break;
        }
    }
        public int ArmorPoints{
            get{
                return armorPoints;
            }
        }
    }
}