// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let rec quicksort list =
   match list with
   | [] ->                            // If the list is empty
        []                            // return an empty list
   | firstElem::otherElements ->      // If the list is not empty
        let smallerElements =         // extract the smaller ones
            otherElements
            |> List.filter (fun e -> e < firstElem)
            |> quicksort              // and sort them
        let largerElements =          // extract the large ones
            otherElements
            |> List.filter (fun e -> e >= firstElem)
            |> quicksort              // and sort them
        // Combine the 3 parts into a new list and return it
        List.concat [smallerElements; [firstElem]; largerElements]


[<EntryPoint>]
let main argv =
    printfn "%A" (quicksort [1;5;23;18;9;1;3])
    0 