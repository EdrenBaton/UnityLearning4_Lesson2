using UnityEngine;

namespace Asteroids
{
    public class MouseShootController : IShooter
    {
        private readonly string _fire1Button;

        public MouseShootController(string fire1Button)
        {
            _fire1Button = fire1Button;
        }
        public bool Shoot()
        {
            return Input.GetButtonDown(_fire1Button);
        }
    }
}