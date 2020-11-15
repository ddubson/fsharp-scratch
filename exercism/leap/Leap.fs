module Leap

let isDivisibleByFour x = x % 4 = 0

let isDivisibleBy100 x  = x % 100 = 0

let isDivisibleBy400 x = x % 400 = 0

let isDivisibleBy100AndNot400 x =
    isDivisibleBy100 x && isDivisibleBy400 x

let isDivisibleBy4AndNot100 x =
    isDivisibleByFour x && not <| isDivisibleBy100 x

let leapYear year =
    (isDivisibleByFour year && isDivisibleBy100AndNot400 year) ||
    isDivisibleBy4AndNot100 year