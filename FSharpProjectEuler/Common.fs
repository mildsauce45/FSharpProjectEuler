namespace ProjectEuler
    module Common =
        
        open System
        open Support

        let findFactorsOf(n:int64) =
            let upperBound = int64(Math.Sqrt(double(n)))
            [2L..upperBound] |> Seq.filter (fun x -> n % x = 0L)

        let isPrime(n:int64) = findFactorsOf(n) |> Seq.length = 0

        let isPrime2(n:int64) =
            Support.MathHelper.IsPrime n

