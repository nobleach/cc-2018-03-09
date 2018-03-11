module Tests

open System
open Xunit
open FSRejectLib

[<Fact>]
let ``Given "Daily Programmer", it returns "DlyPrgrmmr" `` () =
    let expected = "DlyPrgrmmr"
    let actual = Reject.rejectBlacklisted "Daily Programmer"
    Assert.Equal(expected, actual)
