using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FavButt : MonoBehaviour {
    public Image favImg;
    public AudioSource favAudio;
    public Sprite favSprite;
    public Favorites favInstance = new Favorites();
    public int count;
	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void makeFav()
    {
        count = 0;
        favSprite = favImg.sprite;
        favInstance.name = favImg.name;
       
        favInstance.image = favSprite;
        favInstance.sound = favAudio.clip;
       /* if(!gamedata._gameData.myFavs.Contains(favInstance))
        {
           gamedata._gameData.myFavs.Add(favInstance);
        }*/
        for(int i =0;i<gamedata._gameData.myFavs.Count;i++)
        {
           if(gamedata._gameData.myFavs[i].name == favInstance.name)
            {
                count++;
            }
        }
        if(count==0)
        {
            gamedata._gameData.myFavs.Add(favInstance);
        }
       
        

    }
    
}
