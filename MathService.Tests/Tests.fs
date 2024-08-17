module Tests

open System
open Xunit
open MathService

[<Fact>]
let ``Sequence of Evens returns empty collection`` () =
    let expected = Seq.empty<int>
    let actual = MyMath.squaresOfOdds [ 2; 4; 6; 8; 10 ]
    Assert.Equal<Collections.Generic.IEnumerable<int>>(expected, actual)
