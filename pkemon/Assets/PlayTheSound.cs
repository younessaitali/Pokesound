using UnityEngine;


public class PlayTheSound : MonoBehaviour
{

    new public AudioSource sound;
    private bool isPlaying;

    public void PlaySound()
    {
       
            sound.Stop();
            
        
            sound.Play();
           
        
    }

}
