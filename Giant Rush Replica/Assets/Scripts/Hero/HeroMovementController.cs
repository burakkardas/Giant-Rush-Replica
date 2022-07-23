using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovementController : MonoBehaviour
{
    [SerializeField] private HeroDataTransmitter heroDataTransmitter;

    private Rigidbody rb;

    public float horizontalValue;
    [SerializeField] private float horizontalSpeed;
    [SerializeField] private float horizontalLimit;
    [SerializeField] private float forwardSpeed;
    public float newPositionX;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        CheckHorizontalValue();
    }


    private void FixedUpdate()
    {
        SetHeroMovementForward();
        SetHeroMovementHorizontal();
    }


    private void CheckHorizontalValue()
    {
        if (heroDataTransmitter.GetIsTouch())
        {
            horizontalValue = Input.GetAxisRaw("Mouse X");
        }
        else
        {
            horizontalValue = 0;
        }
    }


    private void SetHeroMovementHorizontal()
    {
        newPositionX = transform.position.x + horizontalValue * horizontalSpeed * Time.fixedDeltaTime;
        newPositionX = Mathf.Clamp(newPositionX, -horizontalLimit, horizontalLimit);

        transform.position = new Vector3(
            newPositionX,
            transform.position.y,
            transform.position.z
        );
    }


    private void SetHeroMovementForward()
    {
        rb.velocity = Vector3.forward * forwardSpeed * Time.fixedDeltaTime;
    }
}
