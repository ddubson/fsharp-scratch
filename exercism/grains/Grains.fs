module Grains
open System.Numerics

let square (n: int): Result<uint64, string> =
    if n > 0 && n <= 64 then Ok (uint64(BigInteger.Pow(new BigInteger(2), n - 1))) else Error "square must be between 1 and 64"

let total: Result<uint64, string> = List.sumBy
