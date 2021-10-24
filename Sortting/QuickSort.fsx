let rec Theqsort  = function
    | [] ->  []
    | pivot::rest -> let left, right = rest |> List.partition(fun i -> i < pivot)
                     (Theqsort left) @ [pivot] @ Theqsort right


Theqsort [-22;2;34;-2;0;9;-5;14;-55;74;13]