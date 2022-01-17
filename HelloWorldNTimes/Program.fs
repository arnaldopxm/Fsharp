// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let pritnTimes (n:string) = n |> int |> Seq.init <| id |> Seq.iter (fun _ -> printfn "Hello World")

[<EntryPoint>]
let main argv =
    
    let n = Console.ReadLine() |> int |> Seq.init <| id |> Seq.iter (fun _ -> printfn "Hello World")
    0 // return an integer exit code