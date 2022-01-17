// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let parseInt s = 
    try
        s |> int |> Some
    with
        | _ -> None
let readInt _ = Console.ReadLine() |> parseInt
let readList _ = Seq.initInfinite readInt |> Seq.takeWhile Option.isSome
let printOption o =
    match o with
    | Some(x: int) -> printfn "%i" x
    | _ -> ()

let rec reverse l =
    match l with
    | h :: t -> (reverse t) @ [h]
    | [] -> []

[<EntryPoint>]
let main argv =
    let reverse = 
        readList 0
        |> Seq.toList
        |> reverse
        |> Seq.iter printOption
    0 // return an integer exit code