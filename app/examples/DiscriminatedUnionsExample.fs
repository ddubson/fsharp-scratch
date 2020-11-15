module app.DiscriminatedUnionsExample

type SuccessfulWithdrawal = { Amount: decimal; Balance: decimal }
type FailedWithdrawal = { Amount: decimal; Balance: decimal; isOverdraft: bool }
type MoneyWithdrawalResult =
    | Success of SuccessfulWithdrawal
    | InsufficientFunds of FailedWithdrawal
    | CardExpired of System.DateTime
    | UndisclosedFailure
    
let withdrawMoney n: MoneyWithdrawalResult = UndisclosedFailure
    
let handleWithdrawal amount =
    let w = withdrawMoney amount
    match w with
    | Success s -> printfn "Successfully withdrew %f" <| s.Amount