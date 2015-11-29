 type Type =
    static member M1 v (h:'E1->_) = 
        let f (t:^t) = (^t : (static member M2: _ -> _) v) in f Unchecked.defaultof<Type> h
    static member M2 (m:Choice<'T,'E1>) = fun (h:'E1 -> Choice<'T,'E2>) -> match m with Choice1Of2 v -> Choice1Of2 v | Choice2Of2 e -> h e

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code
