namespace BookGenerator.ConsoleApp.Render
{
    public interface IRenderer
    {
        object Sprite { get; }

        object Render();
    }
}
