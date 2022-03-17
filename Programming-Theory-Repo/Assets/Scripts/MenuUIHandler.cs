using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public InputField playername;


    public void StartSelectScene()
    {
        if (playername.text != "")
        {            
            SceneManager.LoadScene(1);
            MainManager.playernamestr = playername.text;
        }
        else
        {
            Debug.Log("Enter Name");
        }
    }

    public void StartMainScene()
    {
        SceneManager.LoadScene(2);
        Debug.Log("Success LoadScene2");
    }

    public void BackToLastScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene - 1);
        Debug.Log("Success Back to Name Scene");
    }
    
    
}
