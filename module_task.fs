// Трофименко Маргарита ПІ-41
//Варіант 1. Визначити процедуру СУМА_ДОБУТОК(Х), де Х − список довільної довжини, який складається з цілих чисел, а результат процедури – список двох елементів: 
//сума та добуток цих чисел. 
open System

let rec sumMult list =
  match list with
  | head :: tail ->
    match sumMult tail with
    | (a, b) ->
        (head + a, head * b)
  | [] -> (0, 1)

[<EntryPoint>]
let main argv =
    let result = sumMult [ 2; 3; 5 ]
    Console.WriteLine result
    0 
