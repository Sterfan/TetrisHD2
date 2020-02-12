﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{

    // Erik's scene needs to put into the build indes to work with this.
    public void PlayGame ()
    {
        AudioManager.PlayMusic("bt_push");
        Debug.Log("Play the game again.");
        SceneManager.LoadScene("ErikN");
    }

    public void HoverSound()
    {
        AudioManager.PlayMusic("bt_hover");
    }

    public void MenuGame ()
    {
        AudioManager.PlayMusic("bt_push");
        Debug.Log ("go to menu");
        SceneManager.LoadScene("Sterfan");
    }
}