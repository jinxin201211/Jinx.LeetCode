using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    public class ProblemSet_037_解数独 : ISolution
    {
        public CompleteStatus Status { get { return CompleteStatus.Excellent; } }

        public void Test()
        {
            //char[][] board = {
            //    new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
            //    new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            //    new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
            //    new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
            //    new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
            //    new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            //    new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
            //    new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
            //    new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' },
            //};

            char[][] board =  {
                new char[] { '.', '.', '9', '7', '4', '8', '.', '.', '.' },
                new char[] { '7', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '2', '.', '1', '.', '9', '.', '.', '.' },
                new char[] { '.', '.', '7', '.', '.', '.', '2', '4', '.' },
                new char[] { '.', '6', '4', '.', '1', '.', '5', '9', '.' },
                new char[] { '.', '9', '8', '.', '.', '.', '3', '.', '.' },
                new char[] { '.', '.', '.', '8', '.', '3', '.', '2', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '6' },
                new char[] { '.', '.', '.', '2', '7', '5', '9', '.', '.' }
            };
            //Console.WriteLine("=========================================");
            //foreach (var item in board)
            //{
            //    item.Print();
            //}
            //Console.WriteLine("=========================================");
            SolveSudoku(ref board);
            //Console.WriteLine("=========================================");
            //foreach (var item in board)
            //{
            //    item.Print();
            //}
            //Console.WriteLine("=========================================");
        }

        /// <summary>
        /// "执行用时 :↵336 ms↵, 在所有 C# 提交中击败了↵61.33%↵的用户"
        /// "内存消耗 :↵33.2 MB↵, 在所有 C# 提交中击败了↵100.00%↵的用户"
        /// </summary>
        public void SolveSudoku(ref char[][] board)
        {
            bool one = false;
            do
            {
                one = false;
                Dictionary<int, char[]> candidates = new Dictionary<int, char[]>();
                for (int i = 0; i < 81; i++)
                {
                    if (board[i / 9][i % 9] == '.')
                    {
                        candidates.Add(i, GetCandidates(board, i / 9, i % 9));
                    }
                }
                foreach (var item in candidates)
                {
                    //Console.WriteLine($"{item.Key}: {item.Value.ToString<char>()}");
                    if (item.Value.Length == 1)
                    {
                        one = true;
                        board[item.Key / 9][item.Key % 9] = item.Value[0];
                    }
                }
                //Console.WriteLine("=========================================");
                //foreach (var item in board)
                //{
                //    item.Print();
                //}
                //Console.WriteLine("=========================================");
            } while (one);
            List<int> empty = new List<int>();
            for (int i = 0; i < 81; i++)
            {
                if (board[i / 9][i % 9] == '.')
                {
                    empty.Add(i);
                }
            }
            if (empty.Count > 0)
            {
                TraceBack(ref board, empty, 0);
            }
            //Console.WriteLine("=========================================");
            //foreach (var item in board)
            //{
            //    item.Print();
            //}
            //Console.WriteLine("=========================================");
        }

        public bool TraceBack(ref char[][] board, List<int> empty, int index)
        {
            //Console.WriteLine("=========================================");
            //foreach (var item in board)
            //{
            //    item.Print();
            //}
            //Console.WriteLine("=========================================");
            char[] candidates = GetCandidates(board, empty[index] / 9, empty[index] % 9);
            if (candidates.Length > 0)
            {
                bool complete = true;
                for (int j = 0; j < candidates.Length; j++)
                {
                    board[empty[index] / 9][empty[index] % 9] = candidates[j];
                    if (index + 1 < empty.Count)
                    {
                        complete = TraceBack(ref board, empty, index + 1);
                        if (complete)
                        {
                            break;
                        }
                        else
                        {
                            board[empty[index] / 9][empty[index] % 9] = '.';
                        }
                    }
                }
                return complete;
            }
            else
            {
                return false;
            }
        }

        public char[] GetCandidates(char[][] board, int row, int col)
        {
            List<char> candidates = (new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' }).ToList();
            List<char> others = new List<char>();
            for (int i = 0; i < 9; i++)
            {
                if (board[row][i] != '.')
                {
                    others.Add(board[row][i]);
                }
                if (board[i][col] != '.')
                {
                    others.Add(board[i][col]);
                }
            }
            int rowi = row / 3, coli = col / 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[rowi * 3 + i][coli * 3 + j] != '.')
                    {
                        others.Add(board[rowi * 3 + i][coli * 3 + j]);
                    }
                }
            }
            return candidates.Where(p => !others.Contains(p)).ToArray();
        }
    }
}
