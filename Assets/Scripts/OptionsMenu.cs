using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public GameObject mainMenu;

    public void GoBack()
    {
        mainMenu.active = true;
        gameObject.active = false;
    }

    public void SetVolume(float value)
    {
        Debug.Log(value);
    }
}
