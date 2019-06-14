using UnityEngine;
using System.Collections;
using Zenject;

public class Bar : BaseFoo
{
    [Inject]
    public void Construct(TestInjection test)
    {
        Debug.Log("Bar was injected with TestInjection");
    }

    private void Awake()
    {
        Debug.Log("Bar AWAKE called");
    }
}
