using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace AdventOfCode.Y2021.Day05;

[ProblemName("Hydrothermal Venture")]
class Solution : Solver {

    public object PartOne(string input) => GetIntersectionCount(ParseLines(input, skipDiagonal: true));
    public object PartTwo(string input) => GetIntersectionCount(ParseLines(input, skipDiagonal: false));

    int GetIntersectionCount(IEnumerable<IEnumerable<Vec2>> lines) {
        // build a grid with iterating over all points, counting intersections:
        var grid = new Dictionary<Vec2, int>();
        foreach (var pt in lines.SelectMany(pt => pt)) {
            grid[pt] = grid.GetValueOrDefault(pt, 0) + 1;
        }
        return grid.Count(kvp => kvp.Value > 1);
    }

    IEnumerable<IEnumerable<Vec2>> ParseLines(string input, bool skipDiagonal) =>
        from line in input.Split("\n")
            // parse the numbers first:
            let ns = (
                    from st in line.Split(", ->".ToArray(), StringSplitOptions.RemoveEmptyEntries)
                    select int.Parse(st)
                ).ToArray()

            // line properties:
            let start = new Vec2(ns[0], ns[1])
            let end = new Vec2(ns[2], ns[3])
            let displacement = new Vec2(end.x - start.x, end.y - start.y)
            let length = 1 + Math.Max(Math.Abs(displacement.x), Math.Abs(displacement.y))
            let dir = new Vec2(Math.Sign(displacement.x), Math.Sign(displacement.y))

            // represent lines with a set of points:
            let points =
                from i in Enumerable.Range(0, length)
                select new Vec2(start.x + i * dir.x, start.y + i * dir.y)

        where !skipDiagonal || dir.x == 0 || dir.y == 0  // skip diagonals in part 1
        select points;
}

record Vec2(int x, int y);
