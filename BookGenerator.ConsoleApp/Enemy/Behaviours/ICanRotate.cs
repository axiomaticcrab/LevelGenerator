namespace LevelGenerator.ConsoleApp.Enemy.Behaviours
{
    public interface ICanRotate
    {
        float RotationSpeed { get; }
        Condition When { get; }
    }
}