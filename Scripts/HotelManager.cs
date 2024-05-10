using UnityEngine;
using UnityEngine.UI;

public class HotelManager : MonoBehaviour
{
    public GameObject HotelCanvas;

    private void Start()
    {
        // Disable shopCanvas initially
        HotelCanvas.SetActive(false);
    }

    public void OpenHotelShop()
    {
        // Enable shopCanvas when the button is clicked
        HotelCanvas.SetActive(true);
    }

    public void CloseHotelShop()
    {
        // Disable shopCanvas when the exit button is clicked
        HotelCanvas.SetActive(false);
    }
}
