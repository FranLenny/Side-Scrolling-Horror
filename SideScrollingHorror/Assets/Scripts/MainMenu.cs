using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void startGame()
    {
        SceneManager.LoadScene("neverEndingRoad");
    }

    public void instructions()
    {
        SceneManager.LoadScene("instructions");
    }
    
    public void credits()
    {
        SceneManager.LoadScene("credits");
    }

    public void quit()
    {
        Application.Quit();
    }
}
