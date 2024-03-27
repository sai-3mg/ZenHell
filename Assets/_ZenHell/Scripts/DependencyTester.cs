using UnityEngine;
using Zenject;
using ZenHell.Managers;

public class DependencyTester : MonoBehaviour
{
    private GameManager _gameManager;

    [Inject]
    public void Construct(GameManager gameManager)
    {
        _gameManager = gameManager;
    }

    private void Start()
    {
        _gameManager.StartGame();
    }
}
