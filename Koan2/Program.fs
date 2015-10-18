// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

(*

Module 2 - Koan

As per the previous module your task for this assignment is to solve the following Koan. Once again the idea of the Koan is not just to get the application running but to really think about why the issues occurred and to ensure you understand the problems

let dosomethingrandom x =
    if x == 0 then Console.WriteLine(1)
    else dosomethingrandom (x - 1) * x
Get the above code to compile and return an integer in F# Interactive.

The rules for the process are:

If x is equal to 0 then return 1
Else multiply the result of dosomethingrandom with a parameter of x - 1 by x.
Module 2 - Problem

In this problem we are going to create a simple console application that reads in the name and age of a person. We need to input multiple peoples details which we specify at the start of the application. We then output each persons name and age as well as a field which is determined by the following rules:

If age >= 20 then the field is a string which states the person's name and that they are no longer a teenager
If the age < 20 and greater than 13 then the field is a string that states the persons name and that they are a teenage
If the age is < than 13 then is states the name and the person is a kid or child.
As part of this exercise your application must handle erroneous input.

To complete this assignment please complete the Q and A and peer review.


*)
open System

[<EntryPoint>]
let main argv = 

    // testing with Unsigned Int because negative number ages don't make any sense!
    let agecheck input= 
        UInt32.TryParse input

        ///Traps unsuspecting trolls in a recursive loop until they give us a Uint
    let rec ConsoleTrap() = 
        let input = Console.ReadLine()
        let result = agecheck input

        let isrealage = fst result

        if  isrealage then
            snd(result) //return the age
        
        //if the input fails to parse as an int
        else 
            Console.WriteLine "Enter a REAL age"
            ConsoleTrap() 


    Console.WriteLine "What is your age"
    let age = ConsoleTrap()
    Console.WriteLine "What is your name"
    let name = Console.ReadLine()

    if age >= uint32 20 then
            Console.WriteLine (name + " age " + age.ToString() +  ", you are no longer a teenager. Boom!")
            if age > uint32 200 then
               Console.Write("Not sure I really beleive you are " + age.ToString()  + " years old." )
    elif age < uint32 20 && age > uint32 13 then
            Console.WriteLine (name + " age " + age.ToString() + ", you are a teenager. Boom!")
    elif age < uint32 13 then
            Console.WriteLine (name + " age " + age.ToString() + ", you are a kid or a child. Bam!")




    Console.ReadKey() |> ignore
    0 // return an integer exit code
