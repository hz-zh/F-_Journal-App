open System
open System.IO

[<EntryPoint>]
let main argv =  
    // 1. Set variables to today's time and date
    let now = DateTime.Now
    let dateStr = now.ToString("yyyy-MM-dd")
    let timeStr = now.ToString("hh:mm:ss tt")

    // 2. Create a text file with the name set to today's date
    let fileName = sprintf "%s.txt" dateStr
    let file = File.CreateText(fileName)

    // Write the time and date to the first line
    file.WriteLine(sprintf "_%s %s_" dateStr timeStr)

    // 3. Ask user via the console to type a paragraph
    printfn "Enter your journal entry:"
    // 4. Store the user's response as a string
    let entry = Console.ReadLine()

    // 5. Write the response string to the text file
    file.WriteLine(entry)

    // 6. Write the file to the console
    file.Close()
    let fileContents = File.ReadAllText(fileName)
    printfn "%s" fileContents
    
    0 // return an integer exit code (0 in this case)
