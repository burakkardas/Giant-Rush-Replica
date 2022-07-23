using UnityEngine;
using Kardas;

public class HeroCollisionController : MonoBehaviour
{
    [SerializeField] private HeroDataTransmitter heroDataTransmitter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(heroDataTransmitter.GetHeroCurrentColor()))
        {
            heroDataTransmitter.IncreaseHeroScale();
            heroDataTransmitter.PlayHeroStackParticle();
            Destroy(other.gameObject);
        }

        if (!other.gameObject.CompareTag(heroDataTransmitter.GetHeroCurrentColor()) && !other.gameObject.CompareTag(Tag.DIAMOND))
        {
            heroDataTransmitter.DeacreaseHeroScale();
            Destroy(other.gameObject);
        }


        if (other.gameObject.CompareTag(Tag.DIAMOND))
        {
            heroDataTransmitter.SetHeroDiamondCount(1);
            Destroy(other.gameObject);
        }
    }
}
