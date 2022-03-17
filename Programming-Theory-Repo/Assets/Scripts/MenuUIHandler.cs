using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public InputField playername;

    public void StartNew()
    {
        if (playername.text != "")
        {
            SceneManager.LoadScene(1);
            MainManager.playernamestr = playername.text;
        }
        else
        {
            Debug.Log("Enter name");
        }
    }

    public void StartMainScene()
    {
        SceneManager.LoadScene(2);
        Debug.Log("Success LoadScene2");
    }

    public void StartName()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Success Back to Name Scene");
    }
    
    
}
