namespace LevelGenerator.ConsoleApp.Domain.Enemy.Behaviours
{
    public interface ICanRotate
    {
        float RotationSpeed { get; }
        Condition When { get; }
    }
}