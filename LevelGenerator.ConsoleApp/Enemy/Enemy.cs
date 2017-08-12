using LevelGenerator.ConsoleApp.Common;
using LevelGenerator.ConsoleApp.Render.Enemy;

namespace LevelGenerator.ConsoleApp.Enemy
{
    public abstract class Enemy : IEnemy
    {
        private readonly EnemyType _enemyType;
        private readonly IEnemyRenderer enemyRenderer;
        private readonly string _name;
        private readonly Vector2 _position;

        protected Enemy(EnemyType enemyType, Vector2 position, IEnemyRenderer enemyRenderer)
        {
            _enemyType = enemyType;
            this.enemyRenderer = enemyRenderer;
            _name = enemyRenderer.Name;
            _position = position;
        }

        IEnemyRenderer IEnemy.EnemyRenderer
        {
            get { return enemyRenderer; }
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