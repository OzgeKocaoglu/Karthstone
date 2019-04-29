using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    class WeaponCard : Card
    {

        public int Attack;
        public int Durability;

        public WeaponCard(int m, Sprite p, string t, string d, int Attack, int durability) : base(m, p, t, d)
        {
            this.Attack = Attack;
            this.Durability = durability;

            
        }
    }
}
