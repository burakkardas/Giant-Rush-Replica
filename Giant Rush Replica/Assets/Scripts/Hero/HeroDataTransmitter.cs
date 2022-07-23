using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroDataTransmitter : MonoBehaviour
{
    [SerializeField] private HeroInputController heroInputController;
    [SerializeField] private HeroColorController heroColorController;
    [SerializeField] private HeroStackController heroStackController;
    [SerializeField] private HeroMovementController heroMovementController;
    [SerializeField] private HeroVisualEffectController heroVisualEffectController;
    [SerializeField] private HeroUIController heroUIController;


    public bool GetIsTouch()
    {
        return heroInputController.isTouch;
    }



    public string GetHeroCurrentColor()
    {
        return heroColorController.currentHeroColor;
    }



    public void IncreaseHeroScale()
    {
        heroStackController.IncreaseHeroScale();
    }



    public void DeacreaseHeroScale()
    {
        heroStackController.DeacreaseHeroScale();
    }


    public float GetHeroHorizontalValue()
    {
        return heroMovementController.horizontalValue;
    }


    public Material GetHeroMaterial()
    {
        return heroColorController.heroMaterial;
    }


    public void PlayHeroStackParticle()
    {
        heroVisualEffectController.PlayHeroStackParticle();
    }


    public void SetHeroDiamondCount(int value)
    {
        heroStackController.heroDiamondCount += value;

        SetHeroDiamondText();
    }


    public int GetHeroDiamondCount()
    {
        return heroStackController.heroDiamondCount;
    }



    public void SetHeroDiamondText()
    {
        heroUIController.SetHeroDiamondCountText();
    }



    public void SetHeroLevelText()
    {
        heroUIController.SetHeroLevelText();
    }



    public int GetHeroLevel()
    {
        return heroStackController.heroLevel;
    }
}
