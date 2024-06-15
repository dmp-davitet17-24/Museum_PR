using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class web_virtual : MonoBehaviour
{
    public void CallWebSite(string link)
    {
        Application.OpenURL(link);
    }

}
