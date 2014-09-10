module MutableFunction

type Widget =
    | Sprocket of string * int
    | Cog of string * float


let mutable generateWidget =
    let count = ref 0
    (fun() -> incr count
              Sprocket("Model A1", !count))


generateWidget()

generateWidget <- 
    let count = ref 0
    (fun() -> incr count
              Cog ((sprintf "Version 0x%x" !count), 0.0))

generateWidget()