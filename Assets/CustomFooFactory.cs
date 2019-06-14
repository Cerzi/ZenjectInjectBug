using System.Numerics;
using Zenject;

public class CustomFooFactory<T> : IFactory<T> where T : BaseFoo
{
    private readonly DiContainer _container;

    public CustomFooFactory(DiContainer container)
    {
        _container = container;
    }


    public T Create()
    {
        return _container.InstantiateComponentOnNewGameObject<T>();


    }
}

public class FooFactory<T> : PlaceholderFactory<BaseFoo>
    where T : BaseFoo
{ }
