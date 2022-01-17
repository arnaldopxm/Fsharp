// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let permute l =
    let rec per l' =
        match l' with
        | [] -> []
        | a::[] -> a::[]
        | a::b::hs -> b::a::per hs
    l
    |> Seq.toList
    |> per
    |> List.toArray
    |> String

[<EntryPoint>]
let main argv =
    let t = Console.ReadLine() |> int
    for i in [1..t] do
        Console.ReadLine()
        |> permute
        |> printfn "%s"
    0