// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let mingle p q =
    let rec mngl p' q' =
        match p', q' with
        | p1::[], q1::[] -> p1::q1::[]
        | p1::ps, q1::qs -> p1::q1::mngl ps qs
        | _, _ -> []
    mngl (Seq.toList p) (Seq.toList q) |> List.toArray |> String



[<EntryPoint>]
let main argv =
    let p = Console.ReadLine() |> Seq.toList
    let q = Console.ReadLine() |> Seq.toList
    let m =
        mingle p q
        |> printfn "%s"
    0 // return an integer exit code