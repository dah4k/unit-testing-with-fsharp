module Tests

open System
open Xunit
open MathService

[<Fact>]
let ``Sequence of Evens returns empty collection`` () =
    let expected = Seq.empty<int>
    let actual = MyMath.squaresOfOdds [ 2; 4; 6; 8; 10 ]
    Assert.Equal<Collections.Generic.IEnumerable<int>>(expected, actual)

[<Fact>]
let ``Sequences of Ones and Evens returns Ones`` () =
    let expected = [ 1; 1; 1; 1 ]
    let actual = MyMath.squaresOfOdds [ 2; 1; 4; 1; 6; 1; 8; 1; 10 ]
    Assert.Equal<Collections.Generic.IEnumerable<int>>(expected, actual)

[<Theory>]
[<InlineData([1; 2; 3; 4; 5; 6; 7; 8; 9; 10],  [1; 9; 25; 49; 81])>]
[<Fact>]
let ``SquaresOfOdds works`` (input : list<int>, expected : list<int>) =
    let actual = MyMath.squaresOfOdds input
    Assert.Equal<Collections.Generic.IEnumerable<int>>(expected, actual)
