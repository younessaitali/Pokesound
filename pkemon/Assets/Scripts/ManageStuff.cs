using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageStuff : MonoBehaviour {
    public string lettersYouMustDelete;
    public List<Sprite> pokeImage = new List<Sprite>();
    public List<AudioClip> pokeSounds = new List<AudioClip>();
    public List<Image> renders = new List<Image>();
    public List<Text> textRender = new List<Text>();
    public GameObject pokeball;
    public List<AudioSource> audioSources = new List<AudioSource>();
    bool isActive = false;
    private int k = 0;
    private int debut ;
    private int end ;
    // Use this for initialization
    void Awake () {
        
        debut = 0;
        end = renders.Count;


        /* for (int j = debut; j < end; j++)
         {

             renders[k].sprite = pokeImage[j];
             audioSources[k].clip = pokeSounds[j];
             //Debug.Log(pokeImage[j].ToString());
             textRender[k].text = pokeImage[j].name.Replace(lettersYouMustDelete , " ");

             k++;
             if (k == renders.Count)
             {
                 k = 0;
             }

         }*/

       // gamedata._gameData.Load();
    }
    private void Start()
    {
        
        GeneratePage();
    }

    // Update is called once per frame
    void Update () {
		
	}
    public void pokeballactive()
    {
        
        if(isActive==false)
        {
            pokeball.SetActive(true);
            isActive = true;
        }
        else if(isActive==true)
        {
            pokeball.SetActive(false);
            isActive = false;
        }
       

    }
    public void nextPage()
    {if(end < pokeImage.Count)
        {
            debut += renders.Count;
            end += renders.Count;
            GeneratePage();
        }
       
    }
    public void prePage()
    {
        if (0 <debut)
        {
            debut -= renders.Count;
            end -= renders.Count;
            GeneratePage();

        }
    }
    public void GeneratePage()
    {
        k = 0;
        for(int i =0;i<renders.Count; i++)
        {
            renders[i].gameObject.SetActive(false);
        }
        for (int j = debut; j < end; j++)
        {
            if (0<=j && j < pokeImage.Count)
            {
                renders[k].gameObject.SetActive(true);
                renders[k].sprite = pokeImage[j];
                audioSources[k].clip = pokeSounds[j];
                renders[k].name = j.ToString();
               // Debug.Log(pokeImage[j].ToString());
                textRender[k].text = pokeImage[j].name.Replace(lettersYouMustDelete , " ");

                k++;
                if (k == renders.Count)
                {
                    k = 0;
                }
            }
          

        }
    }
}
