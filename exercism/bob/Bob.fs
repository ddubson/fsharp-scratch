module Bob
open System

let isLetter x = Char.IsLetter x

let isUpper x = (Char.IsUpper x) || not (isLetter x)

let (|Silence|_|) input = if input |> Seq.isEmpty then Some Silence else None

let (|AskingQuestion|_|) input = if input |> Seq.last = '?' then Some AskingQuestion else None

let (|Yelling|_|) input =
      if input |> Seq.forall isUpper && input |> Seq.exists isLetter
            then Some Yelling
            else None

let response (input: string): string =
    match input.Trim() with
        | Silence -> "Fine. Be that way!"
        | Yelling & AskingQuestion -> "Calm down, I know what I'm doing!"
        | Yelling -> "Whoa, chill out!"
        | AskingQuestion -> "Sure."
        | _ -> "Whatever."

