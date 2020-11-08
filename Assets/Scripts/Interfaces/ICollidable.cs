using UnityEngine;

namespace Asteroids
{
    public interface ICollidable
    {
        void Collide(Collision2D other);
    }
}