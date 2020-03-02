using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{

    // Erik's scene needs to put into the build indes to work with this.
    private void Start()
    {
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
        AudioManager.StopMusic("menu_music");
        AudioManager.PlayMusic("music");
        Debug.Log("Start specific level");
        SceneManager.LoadScene("Zone1");
    }

    public void MenuGame ()
    {
        AudioManager.PlayMusic("bt_push");
        Debug.Log ("go to menu");
        SceneManager.LoadScene("Menu");
    }
}
