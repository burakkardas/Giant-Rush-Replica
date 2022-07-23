using UnityEngine;
using TMPro;

public class HeroUIController : MonoBehaviour
{
    [SerializeField] private HeroDataTransmitter heroDataTransmitter;


    [SerializeField] private TMP_Text heroLevelText;
    [SerializeField] private TMP_Text heroDiamondCountText;


    public void SetHeroDiamondCountText()
    {
        heroDiamondCountText.text = heroDataTransmitter.GetHeroDiamondCount().ToString();
    }


    public void SetHeroLevelText()
    {
        heroLevelText.text = "LVL." + heroDataTransmitter.GetHeroLevel().ToString();
    }
}
