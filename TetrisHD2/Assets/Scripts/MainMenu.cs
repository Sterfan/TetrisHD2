using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Erik's scene needs to put into the build indes to work with this.
    public void PlayGame ()
    {
        AudioManager.PlayMusic("bt_push");
        Debug.Log("Go to Erik's scene");
        SceneManager.LoadScene("ErikN");
    }

    public void HoverSound()
    {
        AudioManager.PlayMusic("bt_hover");
    }

    public void QuitGame ()
    {
        AudioManager.PlayMusic("bt_push");
        Debug.Log ("Quit");
        Application.Quit ();
    }
}
