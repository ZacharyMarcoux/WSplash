using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Threading;

public class LevelManager : MonoBehaviour
{
    public GameObject winCanvas;
    public GameObject loseCanvas; // Reference to the lose canvas
    public GameObject levelOne;
    public GameObject levelTwo;
    public GameObject levelThree;
    public GameObject levelFour;
    public GameObject levelFive;
    public GameObject levelSix;
    public TMP_Text countdownText;
    private float timer = 5f;
    private bool isGameOver = false; // Flag to prevent multiple invocations of DeactivateLoseCanvas

    public int LookmanHP = 100;
    private int currentLookmanHP;
    public TMP_Text displayingLookmanHP;
    public Button lookmanDamageButton; // Reference to the Lookman damage button

    private void Start()
    {
        currentLookmanHP = LookmanHP;
        levelOne.SetActive(false);
        levelTwo.SetActive(false);
        levelThree.SetActive(false);
        levelFour.SetActive(false);
        levelFive.SetActive(false);
        levelSix.SetActive(false);
        winCanvas.SetActive(false);
        loseCanvas.SetActive(false);

        // Add a listener to the Lookman damage button
        lookmanDamageButton.onClick.AddListener(DealDamageToLookman);
    }

    public void LookmanTakeDamage(int damage)
    {
        currentLookmanHP -= damage;
        displayingLookmanHP.text = "Lookman HP: " + currentLookmanHP; // Update UI to display current Lookman HP
        if (currentLookmanHP <= 0)
        {
            winCanvas.SetActive(true);
        }
    }

    void DealDamageToLookman()
    {
        // Call LookmanTakeDamage function when the Lookman damage button is clicked
        LookmanTakeDamage(1); // Deal 1 damage to Lookman
    }

    public void Update()
    {
        if (!isGameOver && levelOne.activeSelf)
        {
            timer -= Time.deltaTime;
            timer = Mathf.Max(timer, 0f);
            countdownText.text = "Time Remaining: " + Mathf.RoundToInt(timer) + "s";
            if (timer <= 0f)
            {
                loseCanvas.SetActive(true); // Activate the lose canvas
                isGameOver = true; // Set the flag to prevent multiple invocations
                Invoke("DeactivateLoseCanvasAndExitLevel", 5f); // Deactivate the lose canvas and exit level after 5 seconds
            }
        }
    }

    void DeactivateLoseCanvasAndExitLevel()
    {
        loseCanvas.SetActive(false); // Deactivate the lose canvas
        CloseLevel(); // Exit the level
    }

    void CloseLevel()
    {
        // Add your code here to exit the level
        levelOne.SetActive(false);
        levelTwo.SetActive(false);
        levelThree.SetActive(false);
        levelFour.SetActive(false);
        levelFive.SetActive(false);
        levelSix.SetActive(false);
    }

    public void OpenLevelOne()
    {
        levelOne.SetActive(true);
    }

    public void OpenLevelTwo()
    {
        levelTwo.SetActive(true);
    }

    public void OpenLevelThree()
    {
        levelThree.SetActive(true);
    }

    public void OpenLevelFour()
    {
        levelFour.SetActive(true);
    }

    public void OpenLevelFive()
    {
        levelFive.SetActive(true);
    }

    public void OpenLevelSix()
    {
        levelSix.SetActive(true);
    }
}
