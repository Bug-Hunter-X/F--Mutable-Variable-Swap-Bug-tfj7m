let mutable x = 10
let mutable y = 20

let add x y = 
    x <- x + y
    y <- x - y
    x <- x - y
    x

printf "%d" (add x y)