using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    [SerializeField] private Transform heroTransform;


    private Vector3 offset;
    private Vector3 newCameraPosition;


    [SerializeField][Range(0, 3)] private float lerpValue;


    private void Start()
    {
        offset = transform.position - heroTransform.position;
    }


    private void LateUpdate()
    {
        SetCameraSmoothFollow();
    }


    private void SetCameraSmoothFollow()
    {
        newCameraPosition = Vector3.Lerp(transform.position, heroTransform.position + offset, lerpValue * Time.deltaTime);
        transform.position = newCameraPosition;
    }

}
