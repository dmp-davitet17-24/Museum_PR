using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class salto_menu : MonoBehaviour
{
    public ScrollRect scrollRect;
    public Vector2 targetNormalizedPosition;

    public void Jump()
    {
        scrollRect.normalizedPosition = targetNormalizedPosition;
    }

}
