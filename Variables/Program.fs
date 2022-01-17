// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printfn "Welcome to the calculator program"
    
    printfn "Type the first number"
    let firstNo = Console.ReadLine() |> int

    printfn "Type the second number"
    let secondNo = Console.ReadLine() |> int

    printfn "First %i, Second %i" firstNo secondNo

    let sum = firstNo + secondNo
    printfn "The sum is %i" sum
    0
