namespace ProjectEuler
    module Problem9 = 

        let isTriplet arr =
            match arr with
            | [a; b; c] -> a * a + b * b = c * c            
            | _ -> false

        let getTriplets =
            seq {
                for a = 1 to 1000 do
                    for b = a to 1000 do
                        for c = b to 1000 do
                            if (a + b + c) = 1000 then yield [a; b; c]
            }

        let functionalSolution = 
            getTriplets |> Seq.filter isTriplet |> Seq.head |> Seq.fold (fun acc x -> acc * x) 1
