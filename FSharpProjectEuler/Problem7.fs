namespace ProjectEuler
    module Problem7 =
        
        open Common

        let numbers = Seq.unfold (fun x -> Some(x, x + 2L)) 1L

        let functionalSolution =
            numbers |> Seq.filter isPrime|> Seq.take 10001 |> Seq.last