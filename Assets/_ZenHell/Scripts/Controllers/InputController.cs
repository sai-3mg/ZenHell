using UnityEngine;

namespace ZenHell.Controllers
{
    public class InputController
    {
        public Vector2 GetMovementDirection()
        {
            // Replace this with actual input fetching logic
            return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }
    }
}