using UnityEngine;

namespace Asteroids
{
    public abstract class MoveController : IExecutable
    {
        protected IMover _mover;

        protected MoveController(IMover mover)
        {
            _mover = mover;
        }

        public abstract void Execute();
    }
}