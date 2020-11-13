using SantaTimber.Controllers;
using SantaTimber.Views;
using UnityEngine;
using Zenject;

public class BindingsInstaller : MonoInstaller
{
    [SerializeField] private MenuWindow _menuView;
    public override void InstallBindings()
    {
       InjectViewIntoHandler();
    }

    private void InjectViewIntoHandler()
    {
        Container.Bind<MenuWindow>().FromInstance(_menuView);
        Container.Bind<MenuWindowHandler>().AsSingle().NonLazy();

    }
}
