// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let findSubsetRec list find level =
    match level with
    | 0 -> 
        list
        |> Seq.tryFind (fun t -> t > level)
    | -1 -> -1

// Define a function to construct a message to print
let findSubset list v =
    list.Length
    

[<EntryPoint>]
let main argv =
    let count = Console.ReadLine() |> int
    let list = 
        Console.ReadLine().Split [|' '|]
        |> Array.map int
    let casesCount = Console.ReadLine() |> int
    for _ in [0..casesCount-1] do
        Console.ReadLine()
        |> int
        |> findSubset list
        |> printfn "%d"
    0 // return an integer exit code