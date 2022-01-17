// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let euclid_distance a b =
    match a, b with
    | (x, y), (x', y') -> Math.Sqrt <| ((x' - x) ** 2.0) + ((y' - y) ** 2.0)

let perimeter p = 
    let rec per (p: list<float * float>) p' = 
        match p' with
        | a::b::hs -> euclid_distance a b + per p (b::hs)
        | b::[] -> euclid_distance b p.Head 
        | _ -> 0.0
    per p p
    


[<EntryPoint>]
let main argv =
    let n = Console.ReadLine() |> int
    let points =
        [ 
            for i in [1..n] do
                yield
                    Console.ReadLine().Split([|' '|])
                    |> Array.map (fun e -> (float e.[0], float e.[1]))
                    |> fun e -> e.[0]
        ]
        |> perimeter
        |> printfn "%f"

    0