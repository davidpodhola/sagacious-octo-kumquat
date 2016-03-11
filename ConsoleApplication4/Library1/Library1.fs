module Library1

open FsCheck
open ConsoleApplication4

[<Xunit.Fact>]
let test =
  let sumIs (a:int[]) =
    let solver = Solution()
    let index = solver.solution( a )
    let left = a |> Array.toSeq |> Seq.take (index-1) |> Seq.toArray |> Array.sum
    let right = a |> Array.toSeq |> Seq.skip (index + 1) |> Seq.toArray |> Array.sum
    left = right
  
  Check.Quick sumIs
  
  