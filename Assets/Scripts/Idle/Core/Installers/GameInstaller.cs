using Idle.Core.Inventory;
using Zenject;

namespace Idle.Core.Installers
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IInventory>().To<PlayerInventory>().AsSingle();
        }
    }
}
