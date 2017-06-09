using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePati
{
    public class Player : ICloneable
    {
        private int health = 100;
        private int damage = 10;
        private Opponent opponent;

        public int Health { get => health; set => health = value; }
        public int Damage { get => damage; set => damage = value; }
        internal Opponent Opponent { get => opponent; set => opponent = value; }

        public Player ShallowCopy()
        {
            return this.MemberwiseClone() as Player;
        }

        private Player DeepCopy()
        {
            Player cloned = this.MemberwiseClone() as Player;
            cloned.Opponent = new Opponent();

            return cloned as Player;
        }

        public object Clone()
        {
           return DeepCopy() as Player;
        }

        public String getStatInfo() {

            return $"current health: {health}  curren damage: {damage}";
        }
    }
}
