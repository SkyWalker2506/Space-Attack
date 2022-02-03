using System.Collections;
using System.Collections.Generic;
using MovementSystem;
using UnityEngine;

public class Move2DTransform : MonoBehaviour,ICanMove2D
{
    [SerializeField]float horizontalSpeed;
    [SerializeField]float verticalSpeed;

    public float HorizontalSpeed => horizontalSpeed;

    public float VerticalSpeed => verticalSpeed;

    public void MoveDown()
    {
        throw new System.NotImplementedException();
    }

    public void MoveLeft()
    {
        throw new System.NotImplementedException();
    }

    public void MoveRight()
    {
        throw new System.NotImplementedException();
    }

    public void MoveUp()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
