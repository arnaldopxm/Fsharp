// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System


let parseInt s = 
    try
        s |> int |> Some
    with
        | _ -> None

let readInt _ = Console.ReadLine() |> parseInt

let printOption opt =
    match opt with
    | Some(a:int) -> printfn "%i" a
    | None -> ()

let printTimes n x = n |> int |> Seq.init <| id |> Seq.iter (fun _ -> printOption x)

let inputList n = Seq.initInfinite readInt |> Seq.takeWhile Option.isSome |> Seq.iter (fun x -> printTimes n x)




// section: other solutions
// other option
let xs = [1; 2; 3; 4; 5]
let xxs = xs |> List.collect (fun x -> List.replicate 3 x)
//val it : int list = [1; 1; 1; 2; 2; 2; 3; 3; 3; 4; 4; 4; 5; 5; 5]

//simplified
let repCol n xs = (List.replicate >> List.collect) n xs




[<EntryPoint>]
let main argv =
    let n = readInt 0
    let list = inputList n.Value
    0
