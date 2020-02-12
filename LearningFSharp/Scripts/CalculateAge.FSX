open System

let estimatedAge =
    let age =
        let year = DateTime.Now.Year
        year - 1986
    sprintf "You are about %d years old!" age
