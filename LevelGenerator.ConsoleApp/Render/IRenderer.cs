namespace LevelGenerator.ConsoleApp.Render
{
    public interface IRenderer
    {
        object Sprite { get; }
        string Name { get; }
        object Render();
    }
}
