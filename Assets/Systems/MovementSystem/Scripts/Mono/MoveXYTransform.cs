using System.Collections;
using System.Collections.Generic;
using MovementSystem;
using UnityEngine;


namespace MovementSystem
{
    public class MoveXYTransform : MoveXYTransformBase
    {
        public override void MoveDown()
        {
            Move(Vector3.down * VerticalSpeed);
        }

        public override void MoveUp()
        {
            Move(Vector3.up * VerticalSpeed);
        }

        public override void MoveLeft()
        {
            Move(Vector3.left * HorizontalSpeed);
        }

        public override void MoveRight()
        {
            Move(Vector3.right * HorizontalSpeed);
        }
    }
}