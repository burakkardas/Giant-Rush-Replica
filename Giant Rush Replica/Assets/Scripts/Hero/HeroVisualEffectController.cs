using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroVisualEffectController : MonoBehaviour
{
    [SerializeField] private HeroDataTransmitter heroDataTransmitter;
    [SerializeField] private ParticleSystem heroStackParticle;


    private void Start()
    {
        SetHeroParticleMaterial();
    }



    public void PlayHeroStackParticle()
    {
        heroStackParticle.Play();
    }



    public void SetHeroParticleMaterial()
    {
        heroStackParticle.GetComponent<Renderer>().material = heroDataTransmitter.GetHeroMaterial();
    }
}
