using UnityEngine;
using DG.Tweening;

public class DiamondAnimationController : MonoBehaviour
{

    void Start()
    {
        SetDiamondRotate();
        SetDiamondVerticalPosition();
    }


    private void SetDiamondRotate()
    {
        transform.DORotate(new Vector3(0f, 360f, 0f), 5f, RotateMode.Fast)
            .SetLoops(-1, LoopType.Restart)
            .SetRelative()
            .SetEase(Ease.Linear);
    }


    private void SetDiamondVerticalPosition()
    {
        transform.DOMove(new Vector3(transform.position.x, 3f, transform.position.z), 1f)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.Linear);
    }
}
