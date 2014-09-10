module Memoization

open System.Collections.Generic

let memoize (f: 'a -> 'b) =
    let dict = new Dictionary<'a, 'b>()

    let memoizedFunc (input : 'a) =
        match dict.TryGetValue(input) with
            | true, x -> x
            | false, _ ->
                let answer = f input
                dict.Add(input, answer)
                answer

    memoizedFunc

let rec memoizedFib =
    let fib x = 
        match x with
        | 0 | 1 -> 1
        | 2 -> 2
        | n -> memoizedFib (n - 1) + memoizedFib ( n - 2)

    memoize fib

