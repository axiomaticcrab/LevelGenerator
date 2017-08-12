namespace LevelGenerator.ConsoleApp.Render
{
    public class TextBasedEnemyRenderer : IEnemyRenderer
    {
        private readonly string character;
        private readonly string name;

        public TextBasedEnemyRenderer(string character, string name)
        {
            this.character = character;
            this.name = name;
        }

        object IEnemyRenderer.Sprite
        {
            get { return character; }
        }

        string IEnemyRenderer.Name
        {
            get { return name; }
        }

        public object Render()
        {
            return character;
        }
    }
}