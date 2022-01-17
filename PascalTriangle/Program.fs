// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let fact x =
    let rec fact' x' =
        match x' with
        | 0 -> 1
        | 1 -> 1
        | n -> n * fact' (n - 1)
    fact' x

let elem n r = 
    n - r
    |> fact
    |> (*) (fact r)
    |> (/) (fact n)

let pascal_line n =
    let rec p_l n' =
        match n' with
        | 0 -> "1"
        | r ->
            elem n r
            |> string
            |> fun x -> $"{p_l (r - 1)}  {x}"
    p_l n

let pascal k =
    for i in [0..(k - 1)] do
        i
        |> pascal_line
        |> printfn "%s"


[<EntryPoint>]
let main argv =
    let k = 
        Console.ReadLine()
        |> int
        |> pascal
    0 // return an integer exit code