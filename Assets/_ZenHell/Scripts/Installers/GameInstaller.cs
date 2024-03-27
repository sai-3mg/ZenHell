using Zenject;
using ZenHell.Managers;
using ZenHell.Controllers;

namespace ZenHell.Installers
{
    public class GameInstaller : MonoInstaller<GameInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<GameManager>().AsSingle();
            Container.Bind<NetworkManager>().AsSingle();
            Container.Bind<InputController>().AsSingle();

            // If there are any other dependencies needed by these classes, bind them here as well
        }
    }

}