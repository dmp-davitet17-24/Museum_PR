using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;


public class abrir_url : MonoBehaviour
{
    public string url= "https://www.instagram.com/"; // Aquí debes ingresar la URL que deseas abrir

    public void AbrirUrl()
    {
        Application.OpenURL(url); // Esto abrirá la URL en el navegador predeterminado del dispositivo
    }
}
