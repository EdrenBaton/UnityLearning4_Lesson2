using UnityEngine;

namespace Asteroids
{
    public abstract class WeaponController : IExecutable
    {
        protected readonly IShooter _shooter;

        public WeaponController(IShooter shooter)
        {
            _shooter = shooter;
        }
        
        public abstract void Execute();
        protected abstract Rigidbody2D CreateAmmunition(Rigidbody2D ammunition, Vector3 position, Quaternion rotation);
    }
}