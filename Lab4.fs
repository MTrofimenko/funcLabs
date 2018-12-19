// Learn more about F# at http://fsharp.org

open System

type Tree<'a> =
    | Node of 'a * list<Tree<'a>>

let getNodeValue(node)=
  if node % 2.0 = 0.0 && node >= 0.0 && node <=100.0 then
    node**2.0
  else
    1.0
let rec checkstuff tree =
    match tree with
    | Node (node, children) -> (getNodeValue node) *
    (children
        |> List.fold (fun acc next -> acc * (checkstuff next)) 1.0
    )

[<EntryPoint>]
let main argv =
    let t2 = Node (1.0, [Node (2.0, [Node (3.0, []); Node (5.0, [])]); Node (6.0, [Node (4.0, []); Node (7.0, [])])])
    let res = checkstuff t2
    printfn "res: %f" res
    0 // return an integer exit code
