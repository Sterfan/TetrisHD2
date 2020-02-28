using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenuCanvas : MonoBehaviour
{
    public GameObject Canvas;
    // Erik's scene needs to put into the build indes to work with this.
    private void Start()
    {
        //AudioManager.PlayMusic("menu_music");
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
        //AudioManager.StopMusic("menu_music");
        AudioManager.PlayMusic("music");
        Canvas.SetActive(false);
        Debug.Log("Start level over");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MenuGame()
    {
        AudioManager.PlayMusic("bt_push");
        AudioManager.PlayMusic("menu_music");
        Debug.Log("go to menu");
        SceneManager.LoadScene("Menu");
    }
}
