using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    class SpellCard : Card
    {

        public SpellCard(int m, Sprite p, string t, string d) : base(m, p, t, d)
        {

            if(base.Description == null)
            {
                Debug.Log("For this card, you need to add description");
            }

        }

    }
}
