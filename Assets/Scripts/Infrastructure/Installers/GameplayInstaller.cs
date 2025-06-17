using UnityEngine;
using Zenject;

public class GameplayInstaller : MonoInstaller
{
    [SerializeField] private InputHandler _inputHandler;
    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<WalletRepository>().AsSingle();
        Container.Bind<InputPlayer>().AsSingle();
        Container.Bind<InputHandler>().FromInstance(_inputHandler).AsSingle();
    }
}
