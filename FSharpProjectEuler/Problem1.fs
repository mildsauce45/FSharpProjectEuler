namespace ProjectEuler
    module Problem1 =

        // Verbose (mostly a port of c#)
        let problem1Verbose = 

            let mod35 x =
                x % 3 = 0 || x % 5 = 0 

            let numbers = [1..999]

            let mutable total = 0

            for n in numbers do
                if mod35 n then
                    total <- total + n;
                else
                    total <- total

            total        
       
        let problem1VeryFunctional =
            [1..999] |> List.map (fun i -> if i % 5 = 0 || i % 3 = 0 then i else 0) |> List.sum
        
        let problem1AVeryFSharpSolution =
            ([0..3..999] @ [0..5..995] |> List.sum) - ([0..15..990] |> List.sum) 
        
        let problem1BestSolution =
            
            let sumDivisibleBy n p =
                n * (p / n) * ((p / n) + 1) / 2

            sumDivisibleBy 3 999 + sumDivisibleBy 5 999 - sumDivisibleBy 15 999
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        


  




