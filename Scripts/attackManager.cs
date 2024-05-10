using UnityEngine;
using UnityEngine.UI;

public class attackManager : MonoBehaviour
{
    public GameObject levelSelect;

    private void Start()
    {
        // Disable shopCanvas initially
        levelSelect.SetActive(false);
    }

    public void OpenLevels()
    {
        // Enable shopCanvas when the button is clicked
        levelSelect.SetActive(true);
    }

    public void CloseLevels()
    {
        // Disable shopCanvas when the exit button is clicked
        levelSelect.SetActive(false);
    }
}
