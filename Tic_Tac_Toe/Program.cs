using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessBoard chessBoard = new ChessBoard();
            Player player1 = new Player();
            Player player2 = new Player();
            string Input = "";
            int row;
            int column;
            bool turn = true;
            int condition = 0;
            while (true)
            {
                Console.Write(chessBoard.WriteBoard());
                if (turn)
                {
                    Console.WriteLine("This is " + player1.Name + " turn");
                    while (condition == 0)
                    {
                        
                        Input = player1.checkRow();
                        if (Input.Contains("q"))
                        {
                            condition = 2;
                            break;
                        }
                        row = int.Parse(Input);
                        Input = player1.checkColumn();
                        if (Input.Contains("q"))
                        {
                            condition = 2;
                            break;
                        }
                        column = int.Parse(Input);
                        if (chessBoard.Board[row, column] == '?')
                        {
                            chessBoard.Board[row, column] = 'O';
                            condition = 1;
                        }
                        else
                            Console.WriteLine("This coordinate is checked");
                            
                    }
                    if (condition == 2)
                        break;
                    if (isGameOver(chessBoard))
                    {
                        Console.Write(chessBoard.WriteBoard());
                        Console.WriteLine("Player1 won!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("This is " + player2.Name + " turn");
                    while (condition == 0)
                    {

                        Input = player2.checkRow();
                        if (Input.Contains("q"))
                        {
                            condition = 2;
                            break;
                        }
                        row = int.Parse(Input);
                        Input = player2.checkColumn();
                        if (Input.Contains("q"))
                        {
                            condition = 2;
                            break;
                        }
                        column = int.Parse(Input);
                        if (chessBoard.Board[row, column] == '?')
                        {
                            chessBoard.Board[row, column] = 'X';
                            condition = 1;
                        }
                        else
                            Console.WriteLine("This coordinate is checked");

                    }
                    if (condition == 2)
                        break;
                    if (isGameOver(chessBoard))
                    {
                        Console.Write(chessBoard.WriteBoard());
                        Console.WriteLine("Player2 won!");
                        break;
                    }
                }
                turn = !turn;
                condition = 0;
            }
            Console.ReadLine();
        }
        static bool isGameOver(ChessBoard chessBoard)
        {
            bool result = false;
            int n = 0;
            for(int i = 0; i<3; i++)
            {
                for(int j = 0; j <2; j++)
                {
                    if (chessBoard.Board[i, j] == '?' || chessBoard.Board[i, j] != chessBoard.Board[i, j + 1])
                    {
                        break;
                    }
                    n++;
                }
                if (n == 2)
                {
                    result = true;
                    break;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (chessBoard.Board[j, i] == '?' || chessBoard.Board[j, i] != chessBoard.Board[j+1, i])
                    {
                        break;
                    }
                    n++;
                }
                if (n == 2)
                {
                    result = true;
                    break;
                }
                n = 0;
            }
            if (chessBoard.Board[1, 1] != '?' && chessBoard.Board[1, 1] == chessBoard.Board[0, 0] && chessBoard.Board[1, 1] ==
                chessBoard.Board[2, 2])
                result = true;
            if (chessBoard.Board[1, 1] != '?' && chessBoard.Board[1, 1] == chessBoard.Board[0, 2] && chessBoard.Board[1, 1] ==
                chessBoard.Board[2, 0])
                result = true;
            return result;
        }
    }
}
