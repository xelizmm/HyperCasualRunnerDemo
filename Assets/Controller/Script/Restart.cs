using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
