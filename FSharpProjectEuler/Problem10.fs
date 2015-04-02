namespace ProjectEuler
    module Problem10 =

        open Common        
        open Support

        let addition n =
            match n with
            | 2L -> 1L
            | _ -> 2L

        let functionalSolution =
            let primes = Seq.unfold (fun x -> if x < 2000000L then Some(x, x + (addition x)) else None) 2L |> Seq.filter Common.isPrime

            primes |> Seq.sum

        let anotherSolution =
            Seq.toList (Support.MathHelper.SieveOfEratosthenes(2000000L)) |> List.sum
