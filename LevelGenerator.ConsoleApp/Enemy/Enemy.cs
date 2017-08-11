using LevelGenerator.ConsoleApp.Level;
using LevelGenerator.ConsoleApp.Render;

namespace LevelGenerator.ConsoleApp.Enemy
{
    public abstract class Enemy : IEnemy
    {
        private readonly EnemyType _enemyType;
        private readonly IRenderer _renderer;
        private readonly string _name;
        private readonly Vector2 _position;

        protected Enemy(EnemyType enemyType, Vector2 position, IRenderer renderer)
        {
            _enemyType = enemyType;
            _renderer = renderer;
            _name = renderer.Name;
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

        EnemyType IEnemy.Type
        {
            get { return _enemyType; }
        }
    }
}