namespace ProjectEuler
    module Problem5 =   
        
        let divisors = [1..20]

        let isDivisable n =
            divisors |> List.forall (fun d -> n % d = 0)

        let numbers = Seq.unfold (fun x -> Some(x, x + 20)) 20

        let functionalSolution =
            numbers |> Seq.filter isDivisable |> Seq.head

