using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pantalla_completa : MonoBehaviour
{
    public Button miBoton;
    public Image miImagen;
    public Text miTexto;
    // Start is called before the first frame update
    void Start()
    {
        miBoton.onClick.AddListener(CambiarImagenYTexto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CambiarImagenYTexto()
    {
        miImagen.sprite = Resources.Load<Sprite>("miImagenCompleta"); // Cambia la imagen por una nueva
        miTexto.text = "Mi texto nuevo"; // Cambia el texto
        miImagen.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width); // Ajusta el tamaño de la imagen al ancho de la pantalla
        miImagen.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.height); // Ajusta el tamaño de la imagen al alto de la pantalla
    }
}
