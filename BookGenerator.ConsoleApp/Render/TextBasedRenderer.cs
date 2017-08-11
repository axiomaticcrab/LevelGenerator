namespace LevelGenerator.ConsoleApp.Render
{
    public class TextBasedRenderer : IRenderer
    {
        private readonly string _character;

        public TextBasedRenderer(string character)
        {
            _character = character;
        }

        object IRenderer.Sprite
        {
            get { return _character; }
        }

        public object Render()
        {
            return _character;
        }
    }
}