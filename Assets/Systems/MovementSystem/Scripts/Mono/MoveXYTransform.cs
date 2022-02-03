using System.Collections;
using System.Collections.Generic;
using MovementSystem;
using UnityEngine;

public class MoveXYTransform : MonoBehaviour, ICanMove2D
{
    [SerializeField]float horizontalSpeed;
    public float HorizontalSpeed => horizontalSpeed;

    [SerializeField]float verticalSpeed;
    public float VerticalSpeed => verticalSpeed;

    public void MoveDown()
    {
        Move(Vector3.down * VerticalSpeed);
    }

    public void MoveUp()
    {
        Move(Vector3.up * VerticalSpeed);
    }

    public void MoveLeft()
    {
        Move(Vector3.left * HorizontalSpeed);
    }

    public void MoveRight()
    {
        Move(Vector3.right * HorizontalSpeed);
    }

    void Move(Vector3 value)
    {
        transform.position += value* Time.deltaTime;
    }

}
