namespace ProjectEuler
    module Problem3 =
        
        open System
        open Common

        let findMaxPrimeFactorOf(n:int64) =
            let upperBound = int64(Math.Sqrt(double(n)))

            [2L..upperBound] |> Seq.filter (fun x -> n % x = 0L) |> Seq.filter Common.isPrime |> Seq.max

        let functionalSolution =
            findMaxPrimeFactorOf 600851475143L        