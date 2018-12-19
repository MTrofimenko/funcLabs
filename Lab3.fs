// Learn more about F# at http://fsharp.org

open System

let equation(x:float) =
    Math.Log10(x) + 2.0

let diff(x:float) =
    1.0/x

let secDiff(x:float) =
    -x

let getStartPoint(a:float)(b:float) =
    if equation(a)*secDiff(a) > 0.0 then a
    else b

let rec NewtonInner(x:float)(e: float)=
    let mutable y = x
    let mutable x1 = x
    Console.WriteLine x1
    x1 <- x1 - equation(x1)/diff(x1)
    if abs(y - x1) >= e then NewtonInner x1 e
    else x1

let Newton(a:float)(b:float)(e:float)=
    let x = getStartPoint a b
    let u = NewtonInner x e
    u

let rec loop(a:float)(b:float)(p:float) =
    if a < b then
        if abs(a - equation a) > p then
            loop (a + p) b p
        else a
    else 0.0
[<EntryPoint>]
let main argv =
    Console.WriteLine(Newton 0.0 0.2 0.01)
    0 // return an integer exit code
