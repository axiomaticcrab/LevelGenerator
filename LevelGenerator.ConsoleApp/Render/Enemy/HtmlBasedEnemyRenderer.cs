namespace LevelGenerator.ConsoleApp.Render.Enemy
{
    public class HtmlBasedEnemyRenderer : IEnemyRenderer
    {
        private readonly string url;
        private readonly string name;

        public HtmlBasedEnemyRenderer(string url, string name)
        {
            this.url = url;
            this.name = name;
        }

        object IRenderer.Sprite
        {
            get { return url; }
        }

        string IEnemyRenderer.Name
        {
            get { return name; }
        }

        public object Render()
        {
            return string.Format("<img src=\"{0}\" style=\"width: 30px; height: 30px;\" />", url);
        }
    }
}
