using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GoToShop : MonoBehaviour
{
    public string ShopName;

    public void LoadShop()
    {
        SceneManager.LoadScene(3);
    }
}
