using UnityEngine;

public class HeroInputController : MonoBehaviour
{
    [HideInInspector] public bool isTouch = false;

    private void Update()
    {
        HandleHeroInput();
    }


    private void HandleHeroInput()
    {
        if (Input.GetMouseButton(0))
        {
            isTouch = true;
        }
        else
        {
            isTouch = false;
        }
    }
}
