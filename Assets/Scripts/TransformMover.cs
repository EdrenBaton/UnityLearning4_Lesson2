using UnityEngine;

namespace Asteroids
{
    internal class TransformMover : IMover
    {
        private readonly Transform _transform;
        private Vector3 _move;
        
        private readonly float _speed;
        private readonly float _zSpeed = 0.0f;

        public TransformMover(Transform transform, float speed)
        {
            _transform = transform;
            _speed = speed;
        }

        public void Move(float horizontal, float vertical, float deltaTime)
        {
            var speed = deltaTime * _speed;
            
            _move.Set(horizontal * speed, vertical * speed, _zSpeed);
            _transform.localPosition += _move;
        }
    }
}