// Learn more about F# at http://fsharp.org

open System

//X=(A1/2 + B2)eC+D/(|A| - |B|)
let myFunc (A:float) (B:float) (C: float) (D: float) =
    (A**0.5 + B**2.0) * Math.E**(C+D)/ (abs(A)-abs(B))

[<EntryPoint>]
let main argv =
    Console.WriteLine(myFunc 3.0 4.0 2.0 1.0)
    0 // return an integer exit code
