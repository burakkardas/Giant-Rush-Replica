using UnityEngine;

public class HeroStackController : MonoBehaviour
{
    [SerializeField] private HeroDataTransmitter heroDataTransmitter;


    private Vector3 currentHeroScale;
    [SerializeField] private float changeAmout;
    public int heroLevel = 1;
    public int heroDiamondCount = 0;


    private void Start()
    {
        currentHeroScale = transform.localScale;
    }


    public void IncreaseHeroScale()
    {
        currentHeroScale.x += changeAmout;
        currentHeroScale.y += changeAmout;
        currentHeroScale.z += changeAmout;

        SetHeroLevel(1);

        transform.localScale = currentHeroScale;
    }


    public void DeacreaseHeroScale()
    {
        if (transform.localScale.x > 1f)
        {
            currentHeroScale.x -= changeAmout;
            currentHeroScale.y -= changeAmout;
            currentHeroScale.z -= changeAmout;

            SetHeroLevel(-1);
        }

        transform.localScale = currentHeroScale;
    }



    private void SetHeroLevel(int value)
    {
        heroLevel += value;

        heroDataTransmitter.SetHeroLevelText();
    }

}
