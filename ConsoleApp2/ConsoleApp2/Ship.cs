using System;

namespace sajt
{
    public interface lWeaponsystem
    {
        String fire();
        String reload();
    }

    public class HasWepons : lWeaponsystem

    {
        public HasWepons()
        {
        }

        public string fire()
        {
            return "PEWPEW"; 
        }

        public string reload()
        {
            return "Klik klak";
        }
    }

    public class NoWepons : lWeaponsystem

    {
        public NoWepons()
        {

        }

        public string fire()
        {
            return "Nothing to fire, Sir!";
        }

        public string reload()
        {
            return "Nothing to reload, Sir!";
        }

    }

        public class Ship
    {
        public int size;
        public int shield;
        public lWeaponsystem weaponsystem;
        public Ship()
        {
        }
    }

    public class TradeShip : Ship
    {
        public TradeShip()
        {
            size = 20;
            shield = 100;
            weaponsystem = new NoWepons();
        }
    }

    public class Battleship : Ship
    {
        public Battleship()
        {
            size = 20;
            shield = 100;
            weaponsystem = new HasWepons();

        }
    }
    public class ShipFactory {

        public ShipFactory() { }

        public Ship makeShip(int id) {


            if (id == 1) {
                return new Battleship();
            }
            if (id == 2)
            {
                return new TradeShip();
            }
            return null;
        }
    }
}