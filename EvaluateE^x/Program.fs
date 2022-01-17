// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System


let rec fact n =
    match n with
    | 0 -> 0
    | 1 -> 1
    | x -> x * fact (x-1)

let float4i i = Math.Round(float(i), 4)
let float4f (f: float) = Math.Round(f, 4)

// Define a function to construct a message to print
let rec e x:float =
    let calcSerie x n = 
        (float4f (x ** float4i n)) / (float4i <| fact n)
    // let calcSerie x n =  (x ** float n) / (float <| fact n)
    let rec s x' n =
        match n with
        | 0 -> 1.0
        | n' -> calcSerie x' n' + s x' (n-1)
    s x 9
    

[<EntryPoint>]
let main argv =
    let n = Console.ReadLine() |> int
    for i in 1..n do 
        Console.ReadLine()
        |> float
        |> e
        |> printf "%.4f \n"

    0 // return an integer exit code