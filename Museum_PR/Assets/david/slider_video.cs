using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class slider_video : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public GameObject botonPlay;
    public GameObject botonPausa;
    public GameObject botonReiniciar;
    public GameObject botonVolumen;
    public GameObject botonMute;
    public bool play;
    public bool termino;
    public VideoPlayer videoPlayer;
    public Slider barra;
    public bool slide;
    public AudioSource audioSource;
    public Slider barraVolumen;




    // Start is called before the first frame update
    void Start()
    {
        Screen.autorotateToPortrait = true;

        Screen.autorotateToPortraitUpsideDown = true;

        Screen.autorotateToLandscapeLeft = false;

        Screen.autorotateToLandscapeRight = false;

        Screen.orientation = ScreenOrientation.AutoRotation;
        botonReiniciar.SetActive(false);
        videoPlayer.Play();
        videoPlayer.Pause();
    }

    public void OnPointerDown(PointerEventData a)
    {
        videoPlayer.Pause();
        slide = true;
    }

    public void OnPointerUp(PointerEventData a)
    {
        if (play)
        {
            videoPlayer.Play();

        }
        else
        {
            videoPlayer.Pause();
        }
        float frame = (float)barra.value * (float)videoPlayer.frameCount;
        videoPlayer.frame = (long)frame;
        slide = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (slide == false)
        {
            barra.value = (float)videoPlayer.frame / (float)videoPlayer.frameCount;
        }
        if (barra.value >= 0.99 && termino == false)
        {
            botonReiniciar.SetActive(true);
            botonPlay.SetActive(false);
            botonPausa.SetActive(false);
            termino = true;
        }
        if (barra.value == 0)
        {
            termino = false;
        }
    }

    public void Volumen()
    {
        audioSource.volume = barraVolumen.value;
    }
    public void Play()
    {
        videoPlayer.Play();
        botonPlay.SetActive(false);
        botonPausa.SetActive(true);
        play = true;

    }

    public void Pausa()
    {
        videoPlayer.Pause();
        botonPlay.SetActive(true);
        botonPausa.SetActive(false);
        play = false;

    }

    public void Reiniciar()
    {
        videoPlayer.frame = 0;
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

