using UnityEngine;

namespace Asteroids
{
    public abstract class CameraController : IExecutable
    {
        protected Transform _target;
        
        public CameraController(Transform target)
        {
            _target = target;
        }

        public abstract void Execute();

        protected abstract void FollowTarget();
    }
}