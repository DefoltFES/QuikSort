namespace ClassLibrary

module Sort =
   let rec qsort = function
   | [] -> []
   | (x:int) :: xs ->
       let smaller = List.filter ((>=) x) xs
       let larger  = List.filter ((<) x) xs
       qsort smaller @ [x] @ qsort larger
    
        
