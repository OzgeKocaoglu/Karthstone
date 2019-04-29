using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;
using UnityEngine.UI;

public abstract class Card : MonoBehaviour
{

    public int Manacost;
    public Sprite Portrait;
    public Color Rarity; // Class?
    public string Title;
    public string Description;

    private void Update()
    {
        
    }







    protected Card(int m, Sprite p, string t, string d )
    {
        
        this.Manacost = m;
        this.Portrait = p;
        this.Title = t;
        this.Description = d;
        
    }


    
  
    



}
