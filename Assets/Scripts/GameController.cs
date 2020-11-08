using System;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private Transform _player;
        [SerializeField] private Transform _barrel;
        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private PlayerCollisionController _playerCollisionController;
        
        // Эти параметры нужно было утащить в дату, не успел :(
        [SerializeField] private float _playerSpeed;
        [SerializeField] private float _bulletForce;
        [SerializeField] private float _playerStartHp;

        private List<IExecutable> _executables;
        
        private PlayerCameraController _playerCameraController;
        private PlayerMoveController _playerMoveController;

        private void Start()
        {
            _executables = new List<IExecutable>();
            
            _executables.Add(new PlayerCameraController(_player));
            _executables.Add(new PlayerMoveController(new TransformMover(_player, _playerSpeed)));
            _executables.Add(new PlayerRotateController(new TransformRotator(_player), _player));
            _executables.Add(new BarrelController(new MouseShootController("Fire1"), _barrel, _bullet, _bulletForce));

            _playerCollisionController.Init();
            _playerCollisionController.SetHealthController(new HealthController(100.0f));
        }

        private void Update()
        {
            for (var i = 0; i < _executables.Count; i++)
            {
                _executables[i].Execute();
            }
        }
    }
}