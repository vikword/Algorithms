bool Exist(char[,] board, string word)
{
    var m = board.GetLength(0);
    var n = board.GetLength(1);

    var dx = new int[] { 1, -1, 0, 0 };
    var dy = new int[] { 0, 0, 1, -1 };

    for (var i = 0; i < m; i++)
    {
        for (var j = 0; j < n; j++)
        {
            if (board[i, j] != word[0]) continue;

            var stack = new Stack<Tuple<int, int, int, HashSet<string>>>();
            var pos = $"{i},{j}";
            stack.Push(new Tuple<int, int, int, HashSet<string>>(i, j, 0, new HashSet<string>() { pos }));
            while (stack.Count > 0)
            {
                var (x, y, p, path) = stack.Pop();

                if ((p + 1) >= word.Length) return true;

                for (var k = 0; k < dx.Length; k++)
                {
                    var nx = x + dx[k];
                    var ny = y + dy[k];
                    pos = $"{nx},{ny}";

                    if (nx < 0 || ny < 0 || nx >= m || ny >= n || board[nx, ny] != word[p + 1] ||
                        path.Contains(pos)) continue;

                    var npath = new HashSet<string>(path) { pos };
                    stack.Push(new Tuple<int, int, int, HashSet<string>>(nx, ny, p + 1, npath));
                }
            }
        }
    }

    return false;
}

Console.WriteLine(Exist(new[,]{{'A', 'B','C', 'E'}, {'S', 'F', 'C', 'S'}, {'A', 'D', 'E', 'E'}}, "ABCCED"));
Console.WriteLine(Exist(new[,]{{'A', 'B','C', 'E'}, {'S', 'F', 'C', 'S'}, {'A', 'D', 'E', 'E'}}, "SEE"));
Console.WriteLine(Exist(new[,]{{'A', 'B','C', 'E'}, {'S', 'F', 'C', 'S'}, {'A', 'D', 'E', 'E'}}, "ABCB"));