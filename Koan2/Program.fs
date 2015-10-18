
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
