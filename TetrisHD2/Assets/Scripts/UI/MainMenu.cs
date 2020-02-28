using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Erik's scene needs to put into the build indes to work with this.
    public void PressSound()
    {
        AudioManager.PlayMusic("bt_push");
    }

    public void HoverSound()
    {
        AudioManager.PlayMusic("bt_hover");
    }

    public void PlayGame ()
    {
        AudioManager.StopMusic("menu_music");
        AudioManager.PlayMusic("gm_start");
        AudioManager.PlayMusic("music");
        Debug.Log("Go to level1 scene");
        SceneManager.LoadScene("Zone1");
    }

    public void QuitGame ()
    {
        PressSound();
        Debug.Log ("Quit");
        Application.Quit ();
    }
}
