using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class gamedata : MonoBehaviour {
    public static gamedata _gameData;
    public List<Favorites> myFavs = new List<Favorites>();
    
   
    // Use this for initialization
    void Awake () {
        if(_gameData==null)
        {
           // DontDestroyOnLoad(this.gameObject);
            _gameData = this;
        } 
       //PlayerPrefs.DeleteAll();


      
    }
    private void Start()
    {
       
    }
    public void Load()
    {
       myFavs.Clear();
        for (int j = 0; j < PlayerPrefs.GetInt("favsCount"); j++)
        {
            Favorites favInst = new Favorites();
            favInst.name = PlayerPrefs.GetInt("poke" + j).ToString();
            favInst.image = FindObjectOfType<ManageStuff>().pokeImage[PlayerPrefs.GetInt("poke" + j)];
            favInst.sound = FindObjectOfType<ManageStuff>().pokeSounds[PlayerPrefs.GetInt("poke" + j)];
            if (myFavs.Contains(favInst)==false)
            {
                myFavs.Add(favInst);
            }
           
        }
        Debug.Log("loaded");
    }
	// Update is called once per frame
	void Update () {
		
	}
     public void whenBack()
    {
        

        for (int j =0;j<myFavs.Count;j++)
        {
            if (!PlayerPrefs.HasKey("poke" + j))
            {
                save(j);
                Debug.Log("whatthehell");
            }
        }
        PlayerPrefs.SetInt("favsCount", myFavs.Count);
       // Load();
       Debug.Log(PlayerPrefs.GetInt("favsCount"));
       
    }
    public void save(int i)
    {
            PlayerPrefs.SetInt("poke" + i, Convert.ToInt32(myFavs[i].name));
        
      
        Debug.Log(PlayerPrefs.GetInt("poke" + i));
        
    }
    
    
}
