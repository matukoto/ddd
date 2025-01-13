printfn "hello"
// Path: main.fsx
let name = "world"
printfn $"hello {name}"

let list = [ 1..10 ]
let isEven (x: int) : bool = x % 2 = 0
let evens = list |> List.filter isEven
List.iter (printf "%i ") evens

[ 1..10 ] |> List.filter isEven |> List.iter (printf "%i ")
