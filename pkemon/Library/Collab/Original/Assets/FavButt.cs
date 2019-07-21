using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FavButt : MonoBehaviour {
    public Image favImg;
    public AudioSource favAudio;
    public Sprite favSprite;
    public Favorites favInstance = new Favorites();
    private gamedata save;
	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void makeFav()
    {
        favSprite = favImg.sprite;
        favInstance.name = favImg.sprite.name;
        favInstance.image = favSprite;
        favInstance.sound = favAudio.clip;
        if(!gamedata.myFavs.Contains(favInstance))
        {
            gamedata.myFavs.Add(favInstance);
        }
        gamedata.SaveTR();
        

    }
}
