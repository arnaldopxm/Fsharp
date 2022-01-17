// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let compress s =
    let rec cmprs acc s' =
        match s' with
        | [] -> ""
        | a::[] -> string a
        | a::b::[] when a = b -> (string a) + string(acc + 2)
        | a::b::[] when a <> b ->
            match acc with
            | acc when acc = 0 -> string(a) + string(b)
            | _ -> string(a) + string(acc + 1) + string(b)
        | a::b::hs when a = b -> cmprs (acc + 1) (b::hs)
        | a::b::hs when a <> b ->
            match acc with
            | acc when acc = 0 -> string(a) + cmprs 0 (b::hs)
            | _ -> string(a) + string(acc + 1) + cmprs 0 (b::hs)
    s
    |> Seq.toList
    |> cmprs 0


[<EntryPoint>]
let main argv =
    let s =
        Console.ReadLine()
        |> compress
        |> printfn "%s"
    0 // return an integer exit code