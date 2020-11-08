using UnityEngine;

namespace Asteroids
{
    public class PlayerMoveController : MoveController
    {
        public PlayerMoveController(IMover mover) : base(mover)
        {
        }

        public override void Execute()
        {
            _mover.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),
                Time.deltaTime);
        }
    }
}