using UnityEngine;


namespace MovementSystem
{
    public abstract class MoveXYTransformBase : MonoBehaviour, ICanMove2D
    {
        [SerializeField] protected float horizontalSpeed=100;
        public float HorizontalSpeed => horizontalSpeed;

        [SerializeField] protected float verticalSpeed=100;
        public float VerticalSpeed => verticalSpeed;

        public abstract void MoveDown();

        public abstract void MoveUp();

        public abstract void MoveLeft();

        public abstract void MoveRight();

        protected void Move(Vector3 value)
        {
            if (gameObject.activeSelf == false) return;
            transform.position += value * Time.deltaTime;
        }
    }
}