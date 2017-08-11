namespace LevelGenerator.ConsoleApp.Render
{
    public interface IRenderer
    {
        object Sprite { get; }

        object Render();
    }
}
