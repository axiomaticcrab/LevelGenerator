using BookGenerator.ConsoleApp.Domain.Level;
using BookGenerator.ConsoleApp.Render;

namespace BookGenerator.ConsoleApp.Domain.Enemy
{
    public abstract class Enemy : IEnemy
    {
        private readonly IRenderer _renderer;
        private readonly string _name;
        private readonly Vector2 _position;

        protected Enemy(IRenderer renderer, string name, Vector2 position)
        {
            _renderer = renderer;
            _name = name;
            _position = position;
        }

        IRenderer IEnemy.Renderer
        {
            get { return _renderer; }
        }
        string IEnemy.Name
        {
            get { return _name; }
        }

        Vector2 IEnemy.Position
        {
            get { return _position; }
        }
    }
}