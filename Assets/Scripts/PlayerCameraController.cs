using TMPro;
using UnityEngine;

namespace Asteroids
{
    public class PlayerCameraController : CameraController
    {
        private Camera _camera;
        private float _zOffset = -10.0f;
        
        public PlayerCameraController(Transform target) : base(target)
        {
            _camera = Camera.main;
        }

        public override void Execute()
        {
            FollowTarget();
        }

        protected override void FollowTarget()
        {
            var offset = _target.position;
            
            offset.z += _zOffset;
            _camera.transform.position = offset;
        }
    }
}