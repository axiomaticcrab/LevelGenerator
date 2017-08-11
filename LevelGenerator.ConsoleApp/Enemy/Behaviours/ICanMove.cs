namespace LevelGenerator.ConsoleApp.Enemy.Behaviours
{
    public interface ICanMove
    {
        float MovementSpeed { get; }
        Condition When { get; }
    }
}