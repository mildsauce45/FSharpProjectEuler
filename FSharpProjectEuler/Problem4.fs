namespace ProjectEuler
    module Problem4 =
        
        open System.Linq

        let numbers =
            seq {
                for a = 100 to 999 do
                    for b = 100 to 999 do
                        yield [a; b]
            }

        let isPalindrome n =
            let forwardArr = n.ToString().ToCharArray()
            let backwardArr = forwardArr.Reverse().ToArray()

            forwardArr.SequenceEqual backwardArr

        let functionalSolution =
            numbers |> Seq.map (Seq.reduce (*)) |> Seq.filter isPalindrome |> Seq.max