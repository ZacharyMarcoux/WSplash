using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class StartGame : MonoBehaviour
{
    public string LevelName;

    public void LoadLevel()
    {
        SceneManager.LoadScene(1);
    }
}
    