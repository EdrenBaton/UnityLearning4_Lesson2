namespace Asteroids
{
    public class HealthController
    {
        private float _health;

        public HealthController(float startHealth)
        {
            _health = startHealth;
        }

        public void IncreaseHealth(float addHp)
        {
            _health += addHp;
        }

        public bool DecreaseHealth(float subtrHp)
        {
            _health -= subtrHp;

            var isAlive = _health > 0;
            return isAlive;
        }
    }
}