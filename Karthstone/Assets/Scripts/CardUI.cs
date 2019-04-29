using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardUI : MonoBehaviour
{


    public Image portrait;
    public Text Title;
    public Text ManaCost;
    public Text Description;
    public Sprite p;
    public int ParseValue;
    
    
    


    Card c; 
  
    void Start()
    {
        p = GetComponent<Image>().GetComponent<Sprite>();
        int.TryParse(ManaCost.text, out ParseValue);

        c = new Card(ParseValue, Title.text, Description.text, p);

        
    }

    
    void Update()
    {
        
    }
}
