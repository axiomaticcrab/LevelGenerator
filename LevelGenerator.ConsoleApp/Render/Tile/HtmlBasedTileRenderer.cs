namespace LevelGenerator.ConsoleApp.Render.Tile
{
    public class HtmlBasedTileRenderer : IRenderer
    {
        private readonly string url;

        public HtmlBasedTileRenderer(string url)
        {
            this.url = url;
        }

        object IRenderer.Sprite
        {
            get { return url; }
        }

        public object Render()
        {
            return string.Format("<div data-toggle=\"tooltip\" title=\"@tooltip\" style=\"width: 100px; height: 100px; background-image: url('{0}');\">@enemy</div>",url);
        }
    }
}
