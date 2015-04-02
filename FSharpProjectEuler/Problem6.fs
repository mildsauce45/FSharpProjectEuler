namespace ProjectEuler
    module Problem6 =   
                
        let functionalSolution = 
            let numbers = [1..100]

            let sumOfSquares = numbers |> List.map (fun x -> x * x) |> List.sum
        
            let numbersSum = numbers |> List.sum

            let squareOfSum = numbersSum * numbersSum

            squareOfSum - sumOfSquares        
            
