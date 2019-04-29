using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class CardClass : IMage, IWarrior, IRogue
    {

        public int[] Ctype = new int[3];
        public Text Mage;
        public Text TRogue;
        public Text TWarrior;




        void Start()
        {

            
        }

        

        void IMage.Mage()
        {
           
            Debug.Log("Mage");

        }

        public void Rogue()
        {
            
            Debug.Log("Rogue");
        }

        public void Warrior()
        {
           
            Debug.Log("Warrior");
        }



    }
}
