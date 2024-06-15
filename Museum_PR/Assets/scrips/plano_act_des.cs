using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plano_act_des : MonoBehaviour
{
    public GameObject color;
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        color.SetActive(false);

    }

    public void act_des_panel()
    {
        if (color != null)
        {
            bool IsActive = color.activeSelf;
            color.SetActive(!IsActive);
           
        }
    }
    public void disableButton()
    {
        button.interactable = true;
        button.interactable = false;
    }
  
}
