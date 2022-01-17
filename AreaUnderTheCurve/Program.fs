// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let rec combine l l' =
    match l, l' with
    | [], [] -> []
    | [h], [h'] -> [ (h,h') ]
    | h::hs, h'::hs' -> (h,h') :: combine hs hs'
    | _, _ -> []


let evaluate_point a x b = a * (x ** b)

let evaluate_polinomial pol point =
    pol
    |> List.map (fun t -> evaluate_point (fst t) point (snd t) )
    |> List.fold (+) 0.0

let get_range l r e = 
    if l < r then
        [ l+e.. e ..r ] 
    elif l > r then
        [ l-e.. -e ..r ]
    else
        [ l ]

let evaluated_points_between low high step pol =
    get_range low high step
    |> List.map (fun point -> evaluate_polinomial pol point)

let area_under_the_curve low high step pol =
    evaluated_points_between low high step pol
    |> List.fold (+) 0.00
    |> fun x -> x * step

let solid_revolution_volume low high step pol =
    evaluated_points_between low high step pol
    |> List.map (fun v -> v ** 2.0)
    |> List.fold (+) 0.0
    |> fun x -> x * Math.PI * step


let read_float_array () =
    Console.ReadLine().Split [|' '|]
    |> Array.toList
    |> List.map float


[<EntryPoint>]
let main argv =

    let a = read_float_array()
    let b = read_float_array()
    let l =  read_float_array()

    let pol = combine a b

    let ar =
        pol
        |> area_under_the_curve l.[0] l.[1] 0.001
        |> printfn "%f"
    let vo =
        pol
        |> solid_revolution_volume l.[0] l.[1] 0.001
        |> printfn "%f"
    0