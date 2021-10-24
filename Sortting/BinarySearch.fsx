let rec binSearchfun target arr =
    match Array.length arr with
      | 0 -> None
      | i -> let middle = i / 2
             match  sign <| compare target arr.[middle] with
               | 0  -> Some(target)
               | -1 -> binSearchfun target arr.[..middle-1]
               | _  -> binSearchfun target arr.[middle+1..]



binSearchfun 8510 [|1..10000000|]