using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Exited");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("LevelPicker");
    }

    public void BackToStartMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void LVL_1()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void LVL_2()
    {
        SceneManager.LoadScene("Level_2");
    }
    public void LVL_3()
    {
        SceneManager.LoadScene("Level_3");
    }
    public void LVL_4()
    {
        SceneManager.LoadScene("Level_4");
    }
    public void LVL_5()
    {
        SceneManager.LoadScene("Level_5");
    }
    public void LVL_6()
    {
        SceneManager.LoadScene("Level_6");
    }
    public void LVL_7()
    {
        SceneManager.LoadScene("Level_7");
    }
    public void LVL_8()
    {
        SceneManager.LoadScene("Level_8");
    }
    public void LVL_9()
    {
        SceneManager.LoadScene("Level_9");
    }

   // public void Credits()
   // {
    //    SceneManager.LoadScene("Credits");
   // }
}
