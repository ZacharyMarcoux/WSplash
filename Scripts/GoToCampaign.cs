using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GoToCampaign : MonoBehaviour
{
    public string Campaign;

    public void LoadCampaign()
    {
        SceneManager.LoadScene(2);
    }
}
