using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class phoneController : MonoBehaviour
{
    private static bool phoneIsOnScreen = false;

    public Image phoneScreen;


    void Start()
    {
        phoneScreen.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (phoneIsOnScreen)
            {
                Resume();
            }
            else
            {
                Phone();
            }
        }

        if (!phoneIsOnScreen)
        {
            phoneScreen.enabled = false;
        }
    }

    public void Resume()
    {
        phoneScreen.enabled = false;
        phoneIsOnScreen = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Phone()
    {
        phoneScreen.enabled = true;
        phoneIsOnScreen = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
