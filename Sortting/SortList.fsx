let unsortedArray = new ResizeArray<int> ([| 1; 8; 5; 2; 7; 6; 4; 3; 5; 9; 10 |])
let sorted = new ResizeArray<int> ()
for n=1 to unsortedArray.Count-1 do
    let mutable lowest = 0
    for i=0 to unsortedArray.Count-1 do  
        if unsortedArray.[i] < unsortedArray.[lowest] then
            lowest <- i
    sorted.Add(unsortedArray.[lowest])
    unsortedArray.RemoveAt(lowest)

printfn "%A" (sorted |> Seq.toArray)