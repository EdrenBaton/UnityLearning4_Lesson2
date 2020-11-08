using UnityEngine;

namespace Asteroids
{
    public class PlayerRotateController : RotationController
    {
        private Camera _camera;
        private Transform _player;
        
        public PlayerRotateController(IRotator rotator, Transform player) : base(rotator)
        {
            _camera = Camera.main;
            _player = player;
        }

        public override void Execute()
        {
            _rotator.Rotate(Input.mousePosition - _camera.WorldToScreenPoint(_player.position));
        }
    }
}