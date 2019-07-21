using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class manager : MonoBehaviour {
    public static manager _manager;
    public string lettersYouMustDelete;
    public Generations gen1;
    public Generations gen2;
    public Generations gen3;
    public Generations gen4;
    public Generations gen5;
    public Generations gen6;

    public Generations currentGen;
    public List<Image> renders = new List<Image>();
    public List<Text> textRender = new List<Text>();
    public List<Image> makeFavButt = new List<Image>();
    public List<AudioSource> audioSources = new List<AudioSource>();
    public List<Favorites> myFavs = new List<Favorites>();
   
    public int currentGenIndex;
    private int k = 0;
    private int debut;
    private int end;
   
    public GameObject MenuePanel;
    public GameObject boardPanel;
    public GameObject deleteButt;

    public Sprite isFavSprite;
    public Sprite isNotFavSprite;
    // Use this for initialization
    private void Awake()
    {
        if(_manager==null)
        {
            _manager = this;
        }
    }
    
    void Start () {
      //PlayerPrefs.DeleteAll();
       // string yeah = "09yeh";
        loadData();
      // Debug.Log( yeah.Replace(yeah,);
        debut = 0;
        end = renders.Count;
        for (int i = 0;i<gen1.genImages.Count;i++)
        {
            currentGen.genImages.Add(gen1.genImages[i]);
        }
       // GeneratePage();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void GeneratePage()
    {
        k = 0;
        for (int i = 0; i < renders.Count; i++)
        {
            renders[i].gameObject.SetActive(false);
            makeFavButt[i].gameObject.SetActive(false);
            makeFavButt[i].sprite = isNotFavSprite;
        }
        for (int j = debut; j < end; j++)
        {
            if (0 <= j && j < currentGen.genImages.Count)
            {
                renders[k].gameObject.SetActive(true);
                makeFavButt[k].gameObject.SetActive(true);
                renders[k].sprite = currentGen.genImages[j];
                audioSources[k].clip = currentGen.genSounds[j];

                renders[k].name = j.ToString();
                
              
                 switch (currentGenIndex)
                 {
                    case 0:
                        for (int r = 0; r < myFavs.Count; r++)
                        {
                          
                            if (myFavs[r].genNum == currentGenIndex && j == myFavs[r].Num)
                            {
                                makeFavButt[k].sprite = isFavSprite;
                            }
                           
                        }; break;
                    case 1:
                        for (int r = 0; r < myFavs.Count; r++)
                        {
                           // makeFavButt[k].sprite = null;
                            if (myFavs[r].genNum == currentGenIndex && j == myFavs[r].Num)
                            {
                                makeFavButt[k].sprite = isFavSprite;
                            }
                        }; break;
                    case 2:
                        for (int r = 0; r < myFavs.Count; r++)
                        {
                            // makeFavButt[k].sprite = null;
                            if (myFavs[r].genNum == currentGenIndex && j == myFavs[r].Num)
                            {
                                makeFavButt[k].sprite = isFavSprite;
                            }
                        }; break;
                    case 3:
                        for (int r = 0; r < myFavs.Count; r++)
                        {
                            // makeFavButt[k].sprite = null;
                            if (myFavs[r].genNum == currentGenIndex && j == myFavs[r].Num)
                            {
                                makeFavButt[k].sprite = isFavSprite;
                            }
                        }; break;
                    case 4:
                        for (int r = 0; r < myFavs.Count; r++)
                        {
                            // makeFavButt[k].sprite = null;
                            if (myFavs[r].genNum == currentGenIndex && j == myFavs[r].Num)
                            {
                                makeFavButt[k].sprite = isFavSprite;
                            }
                        }; break;
                    case 5:
                        for (int r = 0; r < myFavs.Count; r++)
                        {
                            // makeFavButt[k].sprite = null;
                            if (myFavs[r].genNum == currentGenIndex && j == myFavs[r].Num)
                            {
                                makeFavButt[k].sprite = isFavSprite;
                            }
                        }; break;
                    case 10:
                        for (int r = 0; r < makeFavButt.Count; r++)
                        {
                            // makeFavButt[k].sprite = null;
                            makeFavButt[r].gameObject.SetActive(false);
                        }; break;

                }
                // Debug.Log(pokeImage[j].ToString());
                textRender[k].text = currentGen.genImages[j].name.Replace(lettersYouMustDelete, " ");

                k++;
                if (k == renders.Count)
                {
                    k = 0;
                }
            }


        }
    }
    public void nextPage()
    {
        if (end < currentGen.genImages.Count)
        {
            debut += renders.Count;
            end += renders.Count;
            GeneratePage();
        }

    }
    public void prePage()
    {
        if (0 < debut)
        {
            debut -= renders.Count;
            end -= renders.Count;
            GeneratePage();

        }
    }
    public void chageGen(int i)
    {
        currentGen.genImages.Clear();
        currentGen.genSounds.Clear();
        debut = 0;
        end = renders.Count;
        currentGenIndex = i;

        if (i ==0)
        {
           
            for (int c = 0; c < gen1.genImages.Count; c++)
            {
                currentGen.genImages.Add(gen1.genImages[c]);
                currentGen.genSounds.Add(gen1.genSounds[c]);
            }
            GeneratePage();
        }
        else if(i==1)
        {
           
            for (int c = 0; c < gen2.genImages.Count; c++)
            {
                currentGen.genImages.Add(gen2.genImages[c]);
                currentGen.genSounds.Add(gen2.genSounds[c]);
            }
            GeneratePage();
        }
        else if (i == 2)
        {

            for (int c = 0; c < gen3.genImages.Count; c++)
            {
                currentGen.genImages.Add(gen3.genImages[c]);
                currentGen.genSounds.Add(gen3.genSounds[c]);
            }
            GeneratePage();
        }
        else if (i == 3)
        {

            for (int c = 0; c < gen4.genImages.Count; c++)
            {
                currentGen.genImages.Add(gen4.genImages[c]);
                currentGen.genSounds.Add(gen4.genSounds[c]);
            }
            GeneratePage();
        }
        else if (i == 4)
        {

            for (int c = 0; c < gen5.genImages.Count; c++)
            {
                currentGen.genImages.Add(gen5.genImages[c]);
                currentGen.genSounds.Add(gen5.genSounds[c]);
            }
            GeneratePage();
        }
        else if (i == 5)
        {

            for (int c = 0; c < gen6.genImages.Count; c++)
            {
                currentGen.genImages.Add(gen6.genImages[c]);
                currentGen.genSounds.Add(gen6.genSounds[c]);
            }
            GeneratePage();
        }
        else if(i==10)
        {
            for (int c = 0; c < myFavs.Count; c++)
            {
                currentGen.genImages.Add(myFavs[c].image);
                currentGen.genSounds.Add(myFavs[c].sound);
            }
            GeneratePage();
        }
    }
    public void enableMenu()
    {
        MenuePanel.SetActive(true);
        boardPanel.SetActive(false);

    }
    public void disableMenu()
    {
        MenuePanel.SetActive(false);
        boardPanel.SetActive(true);
    }
    public void saveData()
    {
        
        for(int i = 0;i<myFavs.Count;i++)
        {
            if(!PlayerPrefs.HasKey("pokeGen"+i) && !PlayerPrefs.HasKey("pokeNum" + i))
            {
                PlayerPrefs.SetInt("pokeGen" + i, myFavs[i].genNum);
                PlayerPrefs.SetInt("pokeNum" + i, myFavs[i].Num);
            }
           
           

        }
        PlayerPrefs.SetInt("myfavCount", myFavs.Count);
    }
    public void loadData()
    {
        for(int i=0;i<PlayerPrefs.GetInt("myfavCount");i++)
        {
            Favorites inst = new Favorites();
            switch (PlayerPrefs.GetInt("pokeGen" + i))
            {
                case 0:
                    inst = new Favorites();
                    inst.genNum = PlayerPrefs.GetInt("pokeGen" + i);
                    inst.Num = PlayerPrefs.GetInt("pokeNum" + i);
                    inst.image = gen1.genImages[PlayerPrefs.GetInt("pokeNum" + i)];
                    inst.sound = gen1.genSounds[PlayerPrefs.GetInt("pokeNum" + i)];
                    myFavs.Add(inst);
                    break;
                case 1:
                    inst = new Favorites();
                    inst.genNum = PlayerPrefs.GetInt("pokeGen" + i);
                    inst.Num = PlayerPrefs.GetInt("pokeNum" + i);
                    inst.image = gen2.genImages[PlayerPrefs.GetInt("pokeNum" + i)];
                    inst.sound = gen2.genSounds[PlayerPrefs.GetInt("pokeNum" + i)];
                    myFavs.Add(inst);
                    break;
                case 2:
                    inst = new Favorites();
                    inst.genNum = PlayerPrefs.GetInt("pokeGen" + i);
                    inst.Num = PlayerPrefs.GetInt("pokeNum" + i);
                    inst.image = gen3.genImages[PlayerPrefs.GetInt("pokeNum" + i)];
                    inst.sound = gen3.genSounds[PlayerPrefs.GetInt("pokeNum" + i)];
                    myFavs.Add(inst);
                    break;
                case 3:
                    inst = new Favorites();
                    inst.genNum = PlayerPrefs.GetInt("pokeGen" + i);
                    inst.Num = PlayerPrefs.GetInt("pokeNum" + i);
                    inst.image = gen4.genImages[PlayerPrefs.GetInt("pokeNum" + i)];
                    inst.sound = gen4.genSounds[PlayerPrefs.GetInt("pokeNum" + i)];
                    myFavs.Add(inst);
                    break;
                case 4:
                    inst = new Favorites();
                    inst.genNum = PlayerPrefs.GetInt("pokeGen" + i);
                    inst.Num = PlayerPrefs.GetInt("pokeNum" + i);
                    inst.image = gen5.genImages[PlayerPrefs.GetInt("pokeNum" + i)];
                    inst.sound = gen5.genSounds[PlayerPrefs.GetInt("pokeNum" + i)];
                    myFavs.Add(inst);
                    break;
                case 5:
                    inst = new Favorites();
                    inst.genNum = PlayerPrefs.GetInt("pokeGen" + i);
                    inst.Num = PlayerPrefs.GetInt("pokeNum" + i);
                    inst.image = gen6.genImages[PlayerPrefs.GetInt("pokeNum" + i)];
                    inst.sound = gen6.genSounds[PlayerPrefs.GetInt("pokeNum" + i)];
                    myFavs.Add(inst);
                    break;
            }
           
        }
       
    }
    public void clearFavs()
    {
        myFavs.Clear();
        PlayerPrefs.DeleteAll();
        currentGen.genImages.Clear();
        currentGen.genSounds.Clear();
        GeneratePage();
    }
    public void butactive(bool hmm)
    {
        deleteButt.SetActive(hmm);
    }
}
