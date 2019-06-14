using UnityEngine;
using Zenject;

public class TestMonoInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<TestInjection>().AsSingle();
        Container.BindInterfacesAndSelfTo<FooTester>().AsSingle().NonLazy();

        Container.BindFactory<BaseFoo, FooFactory<Foo>>()
                .FromFactory<CustomFooFactory<Foo>>();

        Container.Bind<Bar>().FromNewComponentOnNewGameObject().AsSingle().NonLazy();
    }
}






public class FooTester : IInitializable
{
    private readonly FooFactory<Foo> _fooFactory;

    public FooTester(FooFactory<Foo> fooFactory)
    {
        _fooFactory = fooFactory;
    }

    public void Initialize()
    {
        Debug.Log("Instantiating new Foo from custom factory method");
        Foo foo = (Foo)_fooFactory.Create();
        foo.name = "TEST";
    }
}

/// <summary>
/// This is to be injected into a new instance of Foo to test the injection timing
/// </summary>
public class TestInjection
{

}