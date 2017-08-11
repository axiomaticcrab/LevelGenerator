namespace LevelGenerator.ConsoleApp.Render
{
    public class TextBasedRenderer : IRenderer
    {
        private readonly string _character;
        private readonly string _name;

        public TextBasedRenderer(string character, string name)
        {
            _character = character;
            _name = name;
        }

        object IRenderer.Sprite
        {
            get { return _character; }
        }

        string IRenderer.Name
        {
            get { return _name; }
        }

        public object Render()
        {
            return _character;
        }
    }
}