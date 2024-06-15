using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacionesUI : MonoBehaviour
{

    [SerializeField] private GameObject imagenPrincipal;
    [SerializeField] private GameObject boton1;
    [SerializeField] private GameObject boton2;
    [SerializeField] private GameObject boton3;

    void Start()
    {
        LeanTween.moveX(imagenPrincipal.GetComponent<RectTransform>(), 0, 1.5f).setEase(LeanTweenType.easeInOutBack);
        LeanTween.moveX(boton1.GetComponent<RectTransform>(), 882, 1.5f).setDelay(2f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveX(boton2.GetComponent<RectTransform>(), 882, 1.5f).setDelay(2f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveX(boton3.GetComponent<RectTransform>(), 882, 1.5f).setDelay(2f).setEase(LeanTweenType.easeOutElastic);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
