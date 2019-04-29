using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    class MinionCard : Card
    {

        public int Attack;
        public int Health;

        public MinionCard(int a, int h, int m, Sprite p, string t, string d) : base(m, p,t, d)
        {

            this.Health = h;
            this.Attack = a;
            
        }
    }
}
