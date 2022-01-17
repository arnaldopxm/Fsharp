// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let common_prefix s1 s2 =
    let s1' = Seq.toList s1
    let s2' = Seq.toList s2
    let p =
        Seq.zip s1' s2'
        |> Seq.takeWhile (fun x -> fst x = snd x)
        |> Seq.length
    match p with
    | 0 -> [(s1'.Length, s1'); (0, []); (0, [])]
    | n -> [(n, s1'.[0..n-1]); (s1'.Length - n, s1'.[n..]); (s2'.Length - n, s2'.[n..])]
    |> List.map (fun e -> (fst e, String (List.toArray <| snd e)))

    

[<EntryPoint>]
let main argv =
    let s1 = Console.ReadLine()
    let s2 = Console.ReadLine()
    let p =
        common_prefix s1 s2
        |> Seq.iter (fun x -> printfn "%i %s" (fst x) (snd x))

    0 // return an integer exit code