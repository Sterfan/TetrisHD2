using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Erik's scene needs to put into the build indes to work with this.
    public void PlayGame ()
    {
        Debug.Log("Go to Erik's scene");
        SceneManager.LoadScene("ErikN");
    }

    public void QuitGame ()
    {
        Debug.Log ("Quit");
        Application.Quit ();
    }
}
