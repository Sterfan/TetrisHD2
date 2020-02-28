﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{

    // Erik's scene needs to put into the build indes to work with this.
    private void Start()
    {
        AudioManager.PlayMusic("gm_win");
        StartCoroutine(WaitForMusic(3.750f));
    }
    IEnumerator WaitForMusic(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        AudioManager.PlayMusic("menu_music");
    }
    public void PressSound()
    {
        AudioManager.PlayMusic("bt_push");
    }

    public void HoverSound()
    {
        AudioManager.PlayMusic("bt_hover");
    }

    public void ResetGame()
    {
        PressSound();
        Debug.Log("Play game again");
        SceneManager.LoadScene("NickS");
        AudioManager.StopMusic("menu_music");
        AudioManager.StopMusic("gm_win");
        AudioManager.PlayMusic("music");

    }

    public void MenuGame()
    {
        AudioManager.PlayMusic("bt_push");
        AudioManager.StopMusic("gm_win");
        AudioManager.PlayMusic("menu_music");
        Debug.Log("go to menu");
        SceneManager.LoadScene("Menu");
    }
}