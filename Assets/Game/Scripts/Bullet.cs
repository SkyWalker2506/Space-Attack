using CombatSystem;
using InputSystem;
using MovementSystem;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    ICanMove2D canMove2D;
    ICanDamage ICanDamage;

    private void Awake()
    {
        InitializeInterfaces();
    }

    void InitializeInterfaces()
    {
        canMove2D = GetComponent<ICanMove2D>();
        if (canMove2D == null)
            Debug.Log("No canMove2D", gameObject);
    }

    void Update()
    {
        canMove2D.MoveUp();
    }


}