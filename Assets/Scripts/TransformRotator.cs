using UnityEngine;

namespace Asteroids
{
    internal sealed class TransformRotator : IRotator
    {
        private readonly Transform _transform;
        
        public TransformRotator(Transform transform)
        {
            _transform = transform;
        }
        
        public void Rotate(Vector3 direction)
        {
            var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            _transform.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}
