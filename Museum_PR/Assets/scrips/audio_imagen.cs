using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class audio_imagen : MonoBehaviour
{

    public GameObject botonPlay;
    public GameObject botonPausa;
    public GameObject botonReiniciar;
    public GameObject botonVolumen;
    public GameObject botonMute;
    public bool play;
    public bool termino;
 
 
    public bool slide;
    public AudioSource audioSource;
    public AudioSource barraVolumen;




    // Start is called before the first frame update
    void Start()
    {

        audioSource.Play();
        audioSource.Pause();
    }



   
    

    public void Volumen()
    {
        audioSource.volume = 1;
      
    }
    public void Play()
    {
       audioSource.Play();
        botonPlay.SetActive(false);
        botonPausa.SetActive(true);
        play = true;

    }

    public void Pausa()
    {
        audioSource.Pause();
        botonPlay.SetActive(true);
        botonPausa.SetActive(false);
        play = false;

    }

    public void Reiniciar()
    {
      
        Play();
        botonReiniciar.SetActive(false);
    }

    public void Silenciar()
    {
       
       
        if (audioSource.mute)
        {
            botonMute.SetActive(false);
            botonVolumen.SetActive(true);
            audioSource.mute = false;
            

        }
        else
        {
            botonMute.SetActive(true);
            botonVolumen.SetActive(false);
            audioSource.mute = true;
           
        }
      
    }
}
