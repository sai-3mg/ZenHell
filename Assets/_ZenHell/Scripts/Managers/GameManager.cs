using UnityEngine;
using Zenject;
using ZenHell.Controllers;

namespace ZenHell.Managers
{
    public class GameManager
    {
        private readonly InputController _inputController;

        [Inject]
        public GameManager(InputController inputController)
        {
            _inputController = inputController;
        }

        public void StartGame()
        {
            // Start game logic here
            Debug.Log("Game started!");
        }

        public void EndGame()
        {
            // End game logic here
            Debug.Log("Game ended!");
        }

    }
}
