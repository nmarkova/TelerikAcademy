// 03. We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. 

using System;


class LongestSequence
{
    static void Main()
    {
        string[,] elements =
        {
        {"ha", "fifi", "ho", "hi",},
        {"fo", "ha", "hi", "xx"},
        {"xxx", "ho", "ha", "xx"},
        };

        //Uncomment to try the second example:
        //string[,] elements =
        //{
        //{"s", "qq", "s"},
        //{"pp", "pp", "s"},
        //{"pp", "qq", "s"},
        //};

        int currentSeq = 1;
        int maxSeq = int.MinValue;
        int maxSeqRow = 0;
        int maxSeqCol = 0;
        string maxSeqDirection = "";

        // case 1 - horizontal sequences - left to right
        for (int row = 0; row < elements.GetLength(0); row++)
        {
            for (int col = 0; col < elements.GetLength(1) - 1; col++)
            {
                if (elements[row, col] == elements[row, col + 1])
                {
                    currentSeq++;
                }
                else
                {
                    currentSeq = 1;
                }

                if (currentSeq > maxSeq)
                {
                    maxSeq = currentSeq;
                    maxSeqRow = row;
                    maxSeqCol = col + 1;
                    maxSeqDirection = "horizontal";
                }
            }
            currentSeq = 1;
        }

        // case 2 - vertical sequences - top to down
        for (int col = 0; col < elements.GetLength(1); col++)
        {
            for (int row = 0; row < elements.GetLength(0) - 1; row++)
            {
                if (elements[row, col] == elements[row + 1, col])
                {
                    currentSeq++;
                }
                else
                {
                    currentSeq = 1;
                }

                if (currentSeq > maxSeq)
                {
                    maxSeq = currentSeq;
                    maxSeqCol = col;
                    maxSeqRow = row + 1;
                    maxSeqDirection = "down";
                }
            }
            currentSeq = 1;
        }

        // case 3 - diagonal sequences - top left to bottom right (TLTB)
        for (int i = 0; i < elements.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < elements.GetLength(1) - 1; j++)
            {
                for (int row = i, col = j; row < elements.GetLength(0) - 1 && col < elements.GetLength(1) - 1; row++, col++) 
                {
                    if (elements[row, col] == elements[row + 1, col + 1])
                    {
                        currentSeq++;
                    }
                    else
                    {
                        currentSeq = 1;
                    }

                    if (currentSeq > maxSeq)
                    {
                        maxSeq = currentSeq;
                        maxSeqRow = row + 1;
                        maxSeqCol = col + 1;
                        maxSeqDirection = "TLBR"; 
                    }
                }
                currentSeq = 1;
            }
        }

        // case 4 - diagonal sequences - top right to bottom left (TRBL)
        for (int i = 0; i < elements.GetLength(0) - 1; i++)
        {
            for (int j = 1; j < elements.GetLength(1); j++)
            {
                for (int row = i, col = j; row < elements.GetLength(0) - 1 && col > 0; row++, col--)
                {
                    if (elements[row, col] == elements[row + 1, col - 1])
                    {
                        currentSeq++;
                    }
                    else
                    {
                        currentSeq = 1;
                    }

                    if (currentSeq > maxSeq)
                    {
                        maxSeq = currentSeq;
                        maxSeqRow = row + 1;
                        maxSeqCol = col - 1;
                        maxSeqDirection = "TRBL";
                    }
                }
                currentSeq = 1;
            }
        }

        // populate the bool matrix for selected cells
        bool[,] selectedCells = new bool[elements.GetLength(0), elements.GetLength(1)];
        switch (maxSeqDirection)
        {
            case "horizontal":
                for (int i = maxSeqCol; i >= Math.Abs(maxSeq - maxSeqCol - 1); i--)
                {
                    selectedCells[maxSeqRow, i] = true;
                }
                break;
            case "down":
                for (int i = maxSeqRow; i >= Math.Abs(maxSeq - maxSeqRow - 1); i--)
                {
                    selectedCells[i, maxSeqCol] = true;
                }
                break;
            case "TLBR":
                for (int row = maxSeqRow, col = maxSeqCol; row >= Math.Abs(maxSeq - maxSeqRow - 1) && col >= Math.Abs(maxSeq - maxSeqCol - 1); row--, col--) 
                {
                    selectedCells[row, col] = true;
                }
                break;
            case "TRBL":
                for (int row = maxSeqRow, col = maxSeqCol; row >= Math.Abs(maxSeq - maxSeqRow - 1); row--, col++) 
                {
                    selectedCells[row, col] = true;
                }
                break;
            default:
                break;
        }

        for (int i = 0; i < elements.GetLength(0); i++)
        {
            for (int j = 0; j < elements.GetLength(1); j++)
            {
                if (selectedCells[i, j] == true)
                {
                    //printing the matrix with highlighted max sequence
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("{0, 4} ", elements[i, j]);
                    Console.ForegroundColor = ConsoleColor.Gray; 
                }
                else
                {
                    // printing without color
                    Console.Write("{0, 4} ", elements[i, j]);
                }
            }
            Console.WriteLine();
        }
    }
}