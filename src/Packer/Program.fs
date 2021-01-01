open System
open System.Net.Http
open System.IO.Compression
open System.IO

[<EntryPoint>]
let main argv =
    let externalFiles =[
        "LICENSE"
        "pack.mcmeta"
        "pack.png"
        "README.md"
    ]
    //对每个版本生成一个包
    let versions = 
        Directory.GetDirectories("./projects","*",SearchOption.TopDirectoryOnly) 
        |> Seq.map (fun p -> Path.GetRelativePath("./projects",p))
    printfn "%A" versions
    //let zipFileStream = File.Create("./Minecraft-Mod-Language-Package.zip")
    //let archive = new ZipArchive(zipFileStream,ZipArchiveMode.Update)
    
    0 // return an integer exit code