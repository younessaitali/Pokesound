using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class FavButt : MonoBehaviour {
    public Image favImg;
    public AudioSource favAudio;
    public Sprite favSprite;
   // public Favorites favInstance = new Favorites();
    public int count;
	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void makeFav()
    {

        Favorites favInstance = new Favorites();
        count = 0;
        favSprite = favImg.sprite;
        favInstance.name = favImg.name;
        favInstance.genNum = manager._manager.currentGenIndex;
        favInstance.Num = Convert.ToInt32(favImg.name);
        favInstance.image = favSprite;
        favInstance.sound = favAudio.clip;
       /* if(!manager._manager.myFavs.Contains(favInstance))
        {
            manager._manager.myFavs.Add(favInstance);
        }*/
       for(int i =0;i<manager._manager.myFavs.Count;i++)
        {
           if(manager._manager.myFavs[i].image.name== favInstance.image.name)
            {
                count++;
            }
        }
        if(count==0)
        {
            manager._manager.myFavs.Add(favInstance);
        }
       
        

    }
    
}
