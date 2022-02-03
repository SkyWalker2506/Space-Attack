namespace MovementSystem
{
    public interface ICanMove2D
    {
        float HorizontalSpeed { get; }
        float VerticalSpeed { get; }

        void MoveRight();
        void MoveLeft();
        void MoveUp();
        void MoveDown();
    }
}