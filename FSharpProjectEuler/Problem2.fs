namespace ProjectEuler
    module Problem2 =
        
        let badSolution =
            let rec fib n =
                if n < 2 then 1 else fib (n - 1) + fib (n - 2)


            let mutable loop = true
            let mutable n = 1
            let mutable accum = 0

            while loop do
                // Get the current fib number
                let num = fib n

                // Now let's test to see if we're under 4000000
                if num < 4000000 then
                    n <- n + 1
                    if num % 2 = 0 then
                        accum <- accum + num
                else
                    loop <- false    
                                   
            accum

        let functionalSolution =
            let fib = Seq.unfold (fun (current, next) -> Some(current, (next, current + next))) (0, 1)

            fib |> Seq.takeWhile(fun n -> n < 4000000) |> Seq.filter (fun n -> n % 2 = 0) |> Seq.sum

