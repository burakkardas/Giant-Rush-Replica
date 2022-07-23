using UnityEngine;
using Kardas;

public class HeroColorController : MonoBehaviour
{
    public Material heroMaterial;

    [SerializeField] private Color[] materialColors;

    [HideInInspector] public string currentHeroColor;
    private int randomIndex;


    private void Start()
    {
        SetHeroMaterialRandomColor();
    }

    private void OnDestroy()
    {
        heroMaterial.color = Color.white;
    }



    public void SetHeroMaterialRandomColor()
    {
        GenerateRandomColorIndex();
        SetHeroObjectTag(randomIndex);

        heroMaterial.color = materialColors[randomIndex];
    }


    private void GenerateRandomColorIndex()
    {
        randomIndex = Random.Range(0, materialColors.Length);
    }


    private void SetHeroObjectTag(int value)
    {
        switch (value)
        {
            case 0:
                currentHeroColor = Tag.ORANGE;
                break;
            case 1:
                currentHeroColor = Tag.GREEN;
                break;
            case 2:
                currentHeroColor = Tag.YELLOW;
                break;
        }
    }
}
