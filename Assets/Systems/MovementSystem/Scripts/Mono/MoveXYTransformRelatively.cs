namespace MovementSystem
{
    public class MoveXYTransformRelatively : MoveXYTransformBase
    {
        public override void MoveDown()
        {
            Move(-transform.forward * VerticalSpeed);
        }

        public override void MoveUp()
        {
            Move(transform.forward * VerticalSpeed);
        }

        public override void MoveLeft()
        {
            Move(-transform.right* HorizontalSpeed);
        }

        public override void MoveRight()
        {
            Move(transform.right * HorizontalSpeed);
        }
    }
}