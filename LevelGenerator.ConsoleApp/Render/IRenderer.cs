namespace LevelGenerator.ConsoleApp.Render
{
    public interface IEnemyRenderer
    {
        object Sprite { get; }
        string Name { get; }
        object Render();
    }

    public interface ILevelRenderer
    {
        Level.Level Level { get; }

        void Render();
    }
}
