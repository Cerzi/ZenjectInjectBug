# ZenjectInjectBug
A demo project to highlight a possible execution order bug when using CustomFactory

BAR is instantied via `Container.Bind<Bar>().FromNewComponentOnNewGameObject().AsSingle().NonLazy();` and, as expected, it is injected before its Awake method is run.

However, Foo is created from a CustomFactory and for whatever reason has its Awake() logic run before it is injected

[Example console output](log.PNG)
