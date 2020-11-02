using Zenject;

namespace Dependencies
{
    public class GameDependencies : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<EventManager>().AsSingle();
        }
    }    
}
