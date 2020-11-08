using UnityEngine;

namespace Asteroids
{
    public interface IMover
    {
        void Move(float horizontal, float vertical, float deltaTime);
    }
}
