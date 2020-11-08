using UnityEngine;

namespace Asteroids
{
    public class BarrelController : WeaponController
    {
        private readonly Transform _barrel;
        private readonly Rigidbody2D _bullet;
        private readonly float _force;

        public BarrelController(IShooter shooter, Transform barrel, Rigidbody2D bullet, float force) : base(shooter)
        {
            _barrel = barrel;
            _bullet = bullet;
            _force = force;
        }

        public override void Execute()
        {
            if (_shooter.Shoot())
            {
                CreateAmmunition(_bullet, _barrel.position, _barrel.rotation);
            }
        }

        protected override Rigidbody2D CreateAmmunition(Rigidbody2D ammunition, Vector3 position, Quaternion rotation)
        {
            var bullet = Object.Instantiate(_bullet, _barrel.position, _barrel.rotation);
            bullet.AddForce(_barrel.up * _force);

            return bullet;
        }
    }
}