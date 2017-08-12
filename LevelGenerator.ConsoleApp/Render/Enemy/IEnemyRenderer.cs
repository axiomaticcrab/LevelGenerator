namespace LevelGenerator.ConsoleApp.Render.Enemy
{
    public interface IEnemyRenderer  : IRenderer
    {
        string Name { get; }
    }
}