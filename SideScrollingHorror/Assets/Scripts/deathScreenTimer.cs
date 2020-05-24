using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathScreenTimer : MonoBehaviour
{

    float timeLeft = 5f;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
