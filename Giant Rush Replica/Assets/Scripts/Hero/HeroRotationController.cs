using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroRotationController : MonoBehaviour
{
    [SerializeField] private HeroDataTransmitter heroDataTransmitter;
    [SerializeField] private float lerpValue;

    private void Update()
    {
        SetHeroRotation();
    }


    private void SetHeroRotation()
    {
        if (heroDataTransmitter.GetIsTouch() || !heroDataTransmitter.GetIsTouch())
        {
            if (heroDataTransmitter.GetHeroHorizontalValue() > 0)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0f, 25f, 0f), lerpValue * Time.deltaTime);
            }
            else if (heroDataTransmitter.GetHeroHorizontalValue() < 0)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0f, -25f, 0f), lerpValue * Time.deltaTime);
            }
            else
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0f, 0f, 0f), lerpValue * Time.deltaTime);
            }
        }
    }
}
