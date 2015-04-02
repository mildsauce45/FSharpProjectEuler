// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
namespace ProjectEuler
    module MainModule =

        open System
        open Problem1
        open Problem2
        open Problem3
        open Problem4
        open Problem5
        open Problem6
        open Problem8
        open Problem9        

        [<EntryPoint>]
        let main argv = 
            let mutable line = "";

            printfn "Welcome to my F# Project Euler sample project"

            printfn "Problem 1 Answer (Verbose): %A" Problem1.problem1Verbose

            printfn "Problem 1 Answer (Most Functional): %A" Problem1.problem1VeryFunctional

            printfn "Problem 1 Answer (Best Solution): %A" Problem1.problem1BestSolution

            printfn "Problem 1 Answer (Best Solution): %A" Problem1.problem1AVeryFSharpSolution

            line <- Console.ReadLine()

            printfn "Problem 2 (Horrible Recursion): %A" Problem2.badSolution

            line <- Console.ReadLine()

            printfn "Problem 2 (Nice Functional Solution): %A" Problem2.functionalSolution

            line <- Console.ReadLine()

            printfn "Problem 3: %A" Problem3.functionalSolution

            line <- Console.ReadLine()

            printfn "Problem 4: %A" Problem4.functionalSolution

            line <- Console.ReadLine()

            printfn "Problem 5: %A" Problem5.functionalSolution

            line <- Console.ReadLine()

            printfn "Problem 6: %A" Problem6.functionalSolution

            line <- Console.ReadLine()

            printfn "Problem 7: %A" Problem7.functionalSolution

            line <- Console.ReadLine()

            printfn "Problem 8: %A" Problem8.functionalSolution

            line <- Console.ReadLine()

            printfn "Problem 9: %A" Problem9.functionalSolution

            line <- Console.ReadLine()
            
            printfn "Problem 10: %A" Problem10.functionalSolution

            line <- Console.ReadLine()

            printfn "Problem 10 (Sieve): %A" Problem10.anotherSolution

            line <- Console.ReadLine()
            
            0 // return an integer exit code
