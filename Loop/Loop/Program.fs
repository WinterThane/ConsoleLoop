open System

[<EntryPoint>]
let main argv =

    let rec queryAnInt () =
        printf "Input: " 
        let input = System.Console.ReadLine()
        match System.Int32.TryParse input with
        | (true, number) -> printf "Number: %d was the input\n" number
        | _              -> match input with
                            | "a" -> printf "Input was: %s - print all\n" input
                            | "q" -> printf "Input was: %s - quit\n" input
                            | _   -> queryAnInt ()

    queryAnInt () |> ignore

    printfn "Press any key to exit ..." 
    Console.ReadLine() |> ignore
    0

