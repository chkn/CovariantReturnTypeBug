open CSharp

type Class3() =
    inherit Class2()

printfn "%s" (Class3().Foo())

