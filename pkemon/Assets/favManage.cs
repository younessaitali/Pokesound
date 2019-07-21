using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class favManage : MonoBehaviour {
    public List<Image> FavoriteRenders = new List<Image>();
    public List<AudioSource> FavouriteAudio = new List<AudioSource>();
    public List<Text> FavouriteText = new List<Text>();
    int debut ;
    int end ;
    public void Awake()
    {
        debut = 0;
        end = FavoriteRenders.Count;
       
    }
    private void OnEnable()
    {
       
        StartCoroutine(waitalil());
    }
    // Use this for initialization
    void Start () {

       

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void nextfav()
    {
        if (end < gamedata._gameData.myFavs.Count)
        {
            debut += FavoriteRenders.Count;
            end += FavoriteRenders.Count;
            GenerateFav();
        }

    }
    public void prefav()
    {
        if (0 < debut)
        {
            debut -= FavoriteRenders.Count;
            end -= FavoriteRenders.Count;
            GenerateFav();

        }
    }
    public void GenerateFav()
    {
       
        int k = 0;
        for (int i = 0; i < FavoriteRenders.Count; i++)
        {
            FavoriteRenders[i].gameObject.SetActive(false);
        }
        for (int j = debut; j < end; j++)
        {
            if (0 <= j && j < gamedata._gameData.myFavs.Count)
            {
               FavoriteRenders[k].gameObject.SetActive(true);
                FavoriteRenders[k].sprite = gamedata._gameData.myFavs[j].image;
                FavouriteAudio[k].clip = gamedata._gameData.myFavs[j].sound;
               
                // Debug.Log(pokeImage[j].ToString());
                FavouriteText[k].text = gamedata._gameData.myFavs[j].image.name.Replace(FindObjectOfType<ManageStuff>().lettersYouMustDelete, " ");
               // FavoriteRenders[k].name = j.ToString();

                k++;
                if (k == FavoriteRenders.Count)
                {
                    k = 0;
                }
            }


        }
    }
    public void ShowFav()
    {
        /* for (int i = 0; i < gamedata._gameData.myFavs.Count; i++)
         {
             FindObjectOfType<ManageStuff>().pokeImage.Add(gamedata._gameData.myFavs[i].image);
             FindObjectOfType<ManageStuff>().pokeSounds.Add(gamedata._gameData.myFavs[i].sound);
         }*/
        //gamedata._gameData.Load();
        GenerateFav();
    }
    public IEnumerator waitalil()
    {
        yield return new WaitForSeconds(0.5f);
        
        gamedata._gameData.Load();
        ShowFav();
    }
}
