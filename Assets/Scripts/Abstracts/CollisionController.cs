using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    [RequireComponent(typeof(Collider2D))]
    public abstract class CollisionController : MonoBehaviour, ICollidable
    {
        protected List<ICollidable> _collidables;

        public void Init()
        {
            _collidables = GetCollidableTypes();
        }
        
        protected void OnCollisionEnter2D(Collision2D other)
        {
            Collide(other);
        }

        public abstract void Collide(Collision2D other);
        protected abstract List<ICollidable> GetCollidableTypes();
    }
}