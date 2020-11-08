namespace Asteroids
{
    public abstract class RotationController : IExecutable
    {
        protected IRotator _rotator;

        protected RotationController(IRotator rotator)
        {
            _rotator = rotator;
        }

        public abstract void Execute();
    }
}