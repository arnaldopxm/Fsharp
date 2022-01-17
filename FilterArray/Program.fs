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

let lift2 f a b =
    match a, b with
    | Some(x), Some(y) -> Some (f x y)
    | _ -> None








//other solution
// filter function
let f x s =
  seq { for v in s do if v < x then yield v }

 








[<EntryPoint>]
let main argv =
    let n = readInt 0
    let list = readList 0 |> Seq.filter (fun e -> (lift2 (<) e n).Value) |> Seq.iter printOption
    0 // return an integer exit code



