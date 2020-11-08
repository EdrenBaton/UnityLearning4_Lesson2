using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class PlayerCollisionController : CollisionController
    {
        private HealthController _health;

        public override void Collide(Collision2D other)
        {
            // Тут будет проверка на то, что other = метеорит
            var asteroidDamage = 5.0f;
            var isAlive = _health.DecreaseHealth(asteroidDamage);
            
            // Тут не нравится, нужно это проверять в другом месте, to be continued...
            if (!isAlive)
            {
                Destroy(gameObject);
            }
        }

        public void SetHealthController(HealthController health)
        {
            _health = health;
        }

        protected override List<ICollidable> GetCollidableTypes()
        {
            return new List<ICollidable>
            {
                // Тут появятся астероиды
            };
        }
    }
}