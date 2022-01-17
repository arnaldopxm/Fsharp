// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let cardNo = 12
    let cardDescription = 
       if cardNo = 1 || cardNo = 14 then "Ace"
       elif cardNo = 11 then "Jack"
       elif cardNo = 12 then "Queen"
       elif cardNo = 13 then "King"
       else string cardNo
    printfn "%s" cardDescription
    0