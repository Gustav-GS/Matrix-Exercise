using System;

namespace Matrix_Exercise {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Tell the numbers of lines and columns of your headquarter:");
            int L = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int[,] headquarter = new int[L, C];
            Console.WriteLine("Write the numbers bellow: ");
            Console.WriteLine("Example: if you choose 3, and 4, you need to write:");
            Console.WriteLine("10 8 15 12");
            Console.WriteLine("21 11 23 8");
            Console.WriteLine("14 5 13 19");
            Console.WriteLine("");
            for (int i = 0; i < L; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < C; j++) {
                    headquarter[i, j] = int.Parse(values[j]);
                    }
                }
            Console.WriteLine("");
            Console.WriteLine("Write a number that belongs to the headquarters: ");

            int search = int.Parse(Console.ReadLine());
            for (int i = 0; i < L; i++) {
                for (int j = 0; j < C; j++) {
                    if (headquarter[i, j] == search) {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0) {
                            Console.WriteLine("Left: " + headquarter[i, j - 1]);
                            }
                        if (i > 0) {
                            Console.WriteLine("Up: " + headquarter[i - 1, j]);
                            }
                        if (j < L - 1) {
                            Console.WriteLine("Right: " + headquarter[i, j + 1]);
                            }
                        if (i < C - 1) {
                            Console.WriteLine("Down: " + headquarter[i + 1, j]);
                            }
                        Console.WriteLine("");
                        }
                    }
                }
            }
        }
    }

