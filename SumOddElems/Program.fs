// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let lift f a b =
    match a, b with
    | Some a, Some b -> Some (f a b)
    | _ -> None

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

let filterLst f lst = 
    lst
    |> Seq.indexed
    |> Seq.filter f
    |> Seq.map snd

[<EntryPoint>]
let main argv =
    let filter e =
        snd e
        |> lift (%) (Some 2)
        |> lift (=) (Some 0)
        |> fun e -> e.Value

    let list =
        readList 0
        |> filterLst filter
        |> Seq.fold (lift (+)) (Some 0)
        |> printOption
    0 // return an integer exit code