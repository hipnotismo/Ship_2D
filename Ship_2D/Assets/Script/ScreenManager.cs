using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{

    public void button(string name)
    {
        SceneManager.LoadScene(name);

    }
    public void gameplayButton()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void exitButton()
    {
        Application.Quit();
        Debug.Log("quit");
    }

    public void returnButton()
    {
      //  SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Main");

    }
    public void OptionsButton()
    {
        SceneManager.LoadScene("Options");
    }

    public void creditButton(string namhe)
    {
        SceneManager.LoadScene("Credits");
    }
}
