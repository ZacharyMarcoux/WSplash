using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public GameObject shopCanvas;

    private void Start()
    {
        // Disable shopCanvas initially
        shopCanvas.SetActive(false);
    }

    public void OpenShop()
    {
        // Enable shopCanvas when the button is clicked
        shopCanvas.SetActive(true);
    }

    public void CloseShop()
    {
        // Disable shopCanvas when the exit button is clicked
        shopCanvas.SetActive(false);
    }
}
