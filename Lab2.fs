// Learn more about F# at http://fsharp.org

open System
let rec mySin (x:float) =
    if x <= 0.1 then x
    else 3.0 * mySin(x/3.0) - 4.0 * mySin(x/3.0) ** 3.0

[<EntryPoint>]
let main argv =
    Console.WriteLine(mySin 1.0)
    0 // return an integer exit code
