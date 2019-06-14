using UnityEngine;
using Zenject;

public class Foo : BaseFoo
{
    [Inject]
    public void Construct(TestInjection test)
    {
        Debug.Log("Foo was injected with TestInjection");
    }

    private void Awake()
    {
        Debug.Log("Foo AWAKE called");
    }
}