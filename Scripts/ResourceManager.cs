using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    public Image hotelImage;
    public int upgradeLevel = 0;
    public Sprite Level1;
    public Sprite Level2;
    public Sprite Level3;
    public Sprite Level4;
    public Sprite Level5;
    public Sprite Level6;
    public bool hotelLevel2Purchased = false;
    public bool hotelLevel3Purchased = false;
    public bool hotelLevel4Purchased = false;
    public bool hotelLevel5Purchased = false;
    public bool hotelLevel6Purchased = false;

    //declaring the variables necessary for the souls resource
    public int soulsPerClick = 1;
    public bool soulUpgradeButtonOne = false;
    public bool soulUpgradeButtonTwo = false;
    public bool soulUpgradeButtonThree = false;
    public bool soulUpgradeButtonFour = false;
    public bool soulsEvolution = false;
    public Image soulsBaseImage;
    public Sprite soulsEvolutionSprite;
    public Button soulsButton;
    public Vector2 originalImageSize = new Vector2(465, 340); // Original size of the image
    public Vector2 upgradedImageSize = new Vector2(429, 500); // Size of the image after upgrade
    public Vector2 originalButtonSize = new Vector2(465, 340); // Original size of the button
    public Vector2 upgradedButtonSize = new Vector2(429, 500); // Size of the button after upgrade
    private float timeSinceLastSoulGain = 0f;
    private float soulGainInterval = 1f;
    public Text soulsText;
    private int soulsCount = 50000;

    //declaring the variables necessary for the aetherium resource
    public int aetheriumPerClick = 0;
    public bool aetheriumUpgradeButtonOne = false;
    public bool aetheriumUpgradeButtonTwo = false;
    public bool aetheriumUpgradeButtonThree = false;
    public bool aetheriumUpgradeButtonFour = false;
    public bool aetheriumEvolution = false;
    public Image aetheriumBaseImage;
    public Sprite aetheriumEvolutionSprite;
    public Button aetheriumButton;
    public Vector2 originalAetheriumImageSize = new Vector2(600, 400); // Original size of the image
    public Vector2 upgradedAetheriumImageSize = new Vector2(415, 390); // Size of the image after upgrade
    public Vector2 originalAetheriumButtonSize = new Vector2(600, 400); // Original size of the button
    public Vector2 upgradedAetheriumButtonSize = new Vector2(415, 390); // Size of the button after upgrade
    private float timeSinceLastAetheriumGain = 0f;
    private float aetheriumGainInterval = 1f;
    public Text aetheriumText;
    private int aetheriumCount = 50000;

    //declaring the variables necessary for the remant resource
    public int remnantPerClick = 0;
    public bool remnantUpgradeButtonOne = false;
    public bool remnantUpgradeButtonTwo = false;
    public bool remnantUpgradeButtonThree = false;
    public bool remnantUpgradeButtonFour = false;
    public bool remnantEvolution = false;
    public Image remnantBaseImage;
    public Sprite remnantEvolutionSprite;
    public Button remnantButton;
    public Vector2 originalRemnantImageSize = new Vector2(415, 430); // Original size of the image
    public Vector2 upgradedRemnantImageSize = new Vector2(400, 375); // Size of the image after upgrade
    public Vector2 originalRemnantButtonSize = new Vector2(415, 430); // Original size of the button
    public Vector2 upgradedRemnantButtonSize = new Vector2(400, 375); // Size of the button after upgrade
    private float timeSinceLastRemnantGain = 0f;
    private float remnantGainInterval = 1f;
    public Text remnantText;
    private int remnantCount = 10000;




    void Start()
    {

        soulsBaseImage.rectTransform.sizeDelta = originalImageSize;
        soulsButton.GetComponent<RectTransform>().sizeDelta = originalButtonSize;

        aetheriumBaseImage.rectTransform.sizeDelta = originalAetheriumImageSize;
        aetheriumButton.GetComponent<RectTransform>().sizeDelta = originalAetheriumButtonSize;

        remnantBaseImage.rectTransform.sizeDelta = originalRemnantImageSize;
        remnantButton.GetComponent<RectTransform>().sizeDelta = originalRemnantButtonSize;
        SetButtonVisibility(false);
    }

    void SetButtonVisibility(bool isVisible)
    {
    }

    public void ToHotelLevel2()
    {
        if (!hotelLevel2Purchased)
        {
            if (soulsCount >= 250 && aetheriumCount >= 250)
            {
                soulsCount -= 250;
                aetheriumCount -= 250;
                hotelLevel2Purchased = true;
                if (soulsText != null && aetheriumText != null)
                {
                    soulsText.text = soulsCount.ToString();
                    aetheriumText.text = aetheriumCount.ToString();
                }
            }
        }
    }

    public void Times2SoulsPerClick()
    {
        if (!soulUpgradeButtonOne)
        {
            if (soulsCount >= 50)
            {
                soulsCount -= 50;
                soulUpgradeButtonOne = true;
                if (soulsText != null)
                    soulsText.text = soulsCount.ToString();
                SetButtonVisibility(false);
            }
        }
    }

    public void Times2AetheriumPerClick()
    {
        if (!aetheriumUpgradeButtonOne)
        {
            if (aetheriumCount >= 50)
            {
                aetheriumCount -= 50;
                aetheriumUpgradeButtonOne = true;
                if (aetheriumText != null)
                    aetheriumText.text = aetheriumCount.ToString();
                SetButtonVisibility(false);
            }
        }
    }

    public void unlockRemnant()
    {
        if (!remnantUpgradeButtonOne)
        {
            if (aetheriumCount >= 1000 && soulsCount >= 1000)
            {
                aetheriumCount -= 1000;
                soulsCount -= 1000;
                remnantUpgradeButtonOne = true;
                if (aetheriumText != null && soulsText != null)
                {
                    aetheriumText.text = aetheriumCount.ToString();
                    soulsText.text = soulsCount.ToString();
                }
                SetButtonVisibility(false);
            }
        }
    }


    public void Times5SoulsPerClick()
    {
        if (!soulUpgradeButtonThree)
        {
            if (soulsCount >= 1000)
            {
                soulsCount -= 1000;
                soulUpgradeButtonThree = true;
                if (soulsText != null)
                    soulsText.text = soulsCount.ToString();
            }
        }
    }

    public void Times5PerAetheriumClick()
    {
        if (!aetheriumUpgradeButtonThree)
        {
            if (aetheriumCount >= 1000)
            {
                aetheriumCount -= 1000;
                aetheriumUpgradeButtonThree = true;
                if (aetheriumText != null)
                    aetheriumText.text = aetheriumCount.ToString();
            }
        }
    }

    public void Times2RemnantPerClick()
    {
        if (!remnantUpgradeButtonTwo)
        {
            if (aetheriumCount >= 3000 && soulsCount >= 3000)
            {
                aetheriumCount -= 3000;
                soulsCount -= 3000;
                remnantUpgradeButtonTwo = true;
                if (aetheriumText != null && soulsText != null)
                {
                    aetheriumText.text = aetheriumCount.ToString();
                    soulsText.text = soulsCount.ToString();
                }
                SetButtonVisibility(false);
            }
        }
    }

    public void Times10Soulsand5Soulspersecond()
    {
        if (!soulUpgradeButtonFour)
        {
            if (soulsCount >= 3000)
            {
                soulsCount -= 3000;
                soulUpgradeButtonFour = true;
                if (soulsText != null)
                    soulsText.text = soulsCount.ToString();
            }
        }
    }

    public void Times10Aetheriumand5AetheriumPerSecond()
    {
        if (!aetheriumUpgradeButtonFour)
        {
            if (aetheriumCount >= 3000)
            {
                aetheriumCount -= 3000;
                aetheriumUpgradeButtonFour = true;
                if (aetheriumText != null)
                    aetheriumText.text = aetheriumCount.ToString();
            }
        }
    }

    public void Times5Remnantand3AetheriumPerSecond()
    {
        if (!remnantUpgradeButtonFour)
        {
            if (soulsCount >= 10000 && aetheriumCount >= 10000 && remnantCount >= 2000)
            {
                soulsCount -= 10000;
                aetheriumCount -= 10000;
                remnantCount -= 2000;
                remnantUpgradeButtonFour = true;
                if (soulsText != null && aetheriumText != null && remnantText != null)
                {
                    soulsText.text = soulsCount.ToString();
                    aetheriumText.text = aetheriumCount.ToString();
                    remnantText.text = remnantCount.ToString();
                }
                    
            }
        }
    }

    public void soulEvolutionUpgrade()
    {
        if (!soulsEvolution)
        {
            if (soulsCount >= 5000 && aetheriumCount >= 10000 && remnantCount >= 2000)
            {
                soulsCount -= 5000;
                aetheriumCount -= 10000;
                remnantCount -= 2000;
                soulsEvolution = true;
                if (soulsText != null && aetheriumText != null && remnantText != null)
                {
                    soulsText.text = soulsCount.ToString();
                    aetheriumText.text = aetheriumCount.ToString();
                    remnantText.text = remnantCount.ToString();
                }
            }
        }
    }

    public void aetheriumEvolutionUpgrade()
    {
        if (!aetheriumEvolution)
        {
            if (soulsCount >= 5000 && aetheriumCount >= 10000 && remnantCount >= 2000)
            {
                soulsCount -= 5000;
                aetheriumCount -= 10000;
                remnantCount -= 2000;
                aetheriumEvolution = true;
                if (soulsText != null && aetheriumText != null && remnantText != null)
                {
                    soulsText.text = soulsCount.ToString();
                    aetheriumText.text = aetheriumCount.ToString();
                    remnantText.text = remnantCount.ToString();
                }
            }
        }
    }

    public void remnantEvolutionUpgrade()
    {
        if (!remnantEvolution)
        {
            if (soulsCount >= 15000 && aetheriumCount >= 15000 && remnantCount >= 6000)
            {
                soulsCount -= 15000;
                aetheriumCount -= 15000;
                remnantCount -= 6000;
                remnantEvolution = true;
                if (soulsText != null && aetheriumText != null && remnantText != null)
                {
                    soulsText.text = soulsCount.ToString();
                    aetheriumText.text = aetheriumCount.ToString();
                    remnantText.text = remnantCount.ToString();
                }
            }
        }
    }

    public void gainSoulsPerSecond()
    {
        if (!soulUpgradeButtonTwo)
        {
            if (soulsCount >= 300)
            {
                soulsCount -= 300;
                soulUpgradeButtonTwo = true;
                if (soulsText != null)
                    soulsText.text = soulsCount.ToString();
            }
        }
    }

    public void gainAetheriumPerSecond()
    {
        if (!aetheriumUpgradeButtonTwo)
        {
            if (aetheriumCount >= 300)
            {
                aetheriumCount -= 300;
                aetheriumUpgradeButtonTwo = true;
                if (aetheriumText != null)
                    aetheriumText.text = aetheriumCount.ToString();
            }
        }
    }

    public void gainRemnantPerSecond()
    {
        if (!remnantUpgradeButtonThree)
        {
            if (soulsCount >= 6000 && aetheriumCount >= 6000 && remnantCount >= 1000)
            {
                soulsCount -= 6000;
                aetheriumCount -= 6000;
                remnantCount -= 1000;
                remnantUpgradeButtonThree = true;
                if (remnantText != null)
                {
                    soulsText.text = soulsCount.ToString();
                    aetheriumText.text = aetheriumCount.ToString();
                    remnantText.text = remnantCount.ToString();
                }
            }
        }
    }

    public int CalculateSoulsPerClick()
    {
        if (soulUpgradeButtonFour)
            return soulsPerClick * 10;
        else if (soulUpgradeButtonThree)
            return soulsPerClick * 5;
        else if (soulUpgradeButtonOne)
            return soulsPerClick * 2;
        else
            return soulsPerClick * 1;
    }

    public int CalculateAetheriumPerClick()
    {
        if (aetheriumUpgradeButtonFour)
            return aetheriumPerClick * 10;
        else if (aetheriumUpgradeButtonThree)
            return aetheriumPerClick * 5;
        else if (aetheriumUpgradeButtonOne)
            return aetheriumPerClick * 2;
        else
            return aetheriumPerClick * 1;
    }

    public int CalculateRemnantPerClick()
    {
        if (remnantEvolution)
        {
            remnantPerClick = 10;
            return remnantPerClick;
        }
        else if (remnantUpgradeButtonFour)
        {
            remnantPerClick = 5;
            return remnantPerClick * 1;
        }
        else if (remnantUpgradeButtonTwo)
        {
            remnantPerClick = 1;
            return remnantPerClick * 2;
        }
        else if (remnantUpgradeButtonOne)
        {
            remnantPerClick = 1;
            return remnantPerClick * 1;
        }
        else
        {
            remnantPerClick = 0;
            return remnantPerClick;
        }
    }



    public void OnSoulsClick()
    {
        soulsCount += CalculateSoulsPerClick();
        if (soulsText != null)
            soulsText.text = soulsCount.ToString();
    }

    public void OnAetheriumClick()
    {
        aetheriumCount += CalculateAetheriumPerClick();
        if (aetheriumText != null)
            aetheriumText.text = aetheriumCount.ToString();
    }

    public void OnRemnantClick()
    {
        remnantCount += CalculateRemnantPerClick();
        if (remnantText != null)
            remnantText.text = remnantCount.ToString();
    }


    


    void UpdateResourceCounts()
    {
        soulsText.text = soulsCount.ToString();
        aetheriumText.text = aetheriumCount.ToString();
        remnantText.text = remnantCount.ToString();
    }

    void Update()
    {
        if (soulsEvolution)
        {
            soulsBaseImage.sprite = soulsEvolutionSprite;
            soulsBaseImage.rectTransform.sizeDelta = upgradedImageSize;
            soulsButton.GetComponent<RectTransform>().sizeDelta = upgradedButtonSize;
            timeSinceLastSoulGain += Time.deltaTime;
            if (timeSinceLastSoulGain >= soulGainInterval)
            {
                timeSinceLastSoulGain = 0f;
                soulsCount += 15;
                if (soulsText != null)
                    soulsText.text = soulsCount.ToString();
            }
        }
        else if (soulUpgradeButtonFour)
        {
            timeSinceLastSoulGain += Time.deltaTime;
            if (timeSinceLastSoulGain >= soulGainInterval)
            {
                timeSinceLastSoulGain = 0f;
                soulsCount += 5;
                if (soulsText != null)
                    soulsText.text = soulsCount.ToString();
            }
        }
        else if (soulUpgradeButtonTwo)
        {
            timeSinceLastSoulGain += Time.deltaTime;
            if (timeSinceLastSoulGain >= soulGainInterval)
            {
                timeSinceLastSoulGain = 0f;
                soulsCount += 2;
                if (soulsText != null)
                    soulsText.text = soulsCount.ToString();
            }
        }

        if (aetheriumEvolution)
        {
            aetheriumBaseImage.sprite = aetheriumEvolutionSprite;
            aetheriumBaseImage.rectTransform.sizeDelta = upgradedAetheriumImageSize;
            aetheriumButton.GetComponent<RectTransform>().sizeDelta = upgradedAetheriumButtonSize;
            timeSinceLastAetheriumGain += Time.deltaTime;
            if (timeSinceLastAetheriumGain >= aetheriumGainInterval)
            {
                timeSinceLastAetheriumGain = 0f;
                aetheriumCount += 15;
                if (aetheriumText != null)
                    aetheriumText.text = aetheriumCount.ToString();
            }
        }
        else if (aetheriumUpgradeButtonFour)
        {
            timeSinceLastAetheriumGain += Time.deltaTime;
            if (timeSinceLastAetheriumGain >= aetheriumGainInterval)
            {
                timeSinceLastAetheriumGain = 0f;
                aetheriumCount += 5;
                if (aetheriumText != null)
                    aetheriumText.text = aetheriumCount.ToString();
            }
        }
        else if (aetheriumUpgradeButtonTwo)
        {
            timeSinceLastAetheriumGain += Time.deltaTime;
            if (timeSinceLastAetheriumGain >= aetheriumGainInterval)
            {
                timeSinceLastAetheriumGain = 0f;
                aetheriumCount += 2;
                if (aetheriumText != null)
                    aetheriumText.text = aetheriumCount.ToString();
            }
        }

        if (remnantEvolution)
        {
            remnantBaseImage.sprite = remnantEvolutionSprite;
            remnantBaseImage.rectTransform.sizeDelta = upgradedRemnantImageSize;
            remnantButton.GetComponent<RectTransform>().sizeDelta = upgradedRemnantButtonSize;
            timeSinceLastRemnantGain += Time.deltaTime;
            if (timeSinceLastRemnantGain >= remnantGainInterval)
            {
                timeSinceLastRemnantGain = 0f;
                remnantCount += 10;
                if (remnantText != null)
                    remnantText.text = remnantCount.ToString();
            }
        }
        else if (remnantUpgradeButtonFour)
        {
            timeSinceLastRemnantGain += Time.deltaTime;
            if (timeSinceLastRemnantGain >= remnantGainInterval)
            {
                timeSinceLastRemnantGain = 0f;
                remnantCount += 3;
                if (remnantText != null)
                    remnantText.text = remnantCount.ToString();
            }
        }
        else if (remnantUpgradeButtonThree)
        {
            timeSinceLastRemnantGain += Time.deltaTime;
            if (timeSinceLastRemnantGain >= remnantGainInterval)
            {
                timeSinceLastRemnantGain = 0f;
                remnantCount += 1;
                if (remnantText != null)
                    remnantText.text = remnantCount.ToString();
            }
        }

        if (hotelLevel6Purchased)
            hotelImage.sprite = Level6;
        else if (hotelLevel5Purchased)
            hotelImage.sprite = Level5;
        else if (hotelLevel4Purchased)
            hotelImage.sprite = Level4;
        else if (hotelLevel3Purchased)
            hotelImage.sprite = Level3;
        else if (hotelLevel2Purchased)
            hotelImage.sprite = Level2;
        else
            hotelImage.sprite = Level1;

    }
}
