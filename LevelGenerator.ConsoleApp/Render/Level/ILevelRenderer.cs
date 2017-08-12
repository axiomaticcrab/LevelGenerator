namespace LevelGenerator.ConsoleApp.Render.Level
{
    public interface ILevelRenderer
    {
        ConsoleApp.Level.Level Level { get; }

        ILevelRenderer Init(ConsoleApp.Level.Level level);
        object Render();
    }
}