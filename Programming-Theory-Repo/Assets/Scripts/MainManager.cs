using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class MainManager : MonoBehaviour
{
    public Text playerName;
    public static string playernamestr;

    void Start() 
    {
        playerName.text = playernamestr;
    }
}
