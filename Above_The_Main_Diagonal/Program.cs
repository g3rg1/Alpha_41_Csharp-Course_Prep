using System;

namespace Above_The_Main_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = ulong.Parse(Console.ReadLine());

            ulong[,] mtrx = new ulong[n,n];
            ulong colNum = 1;
            ulong sum = 0;
            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                var rowNum = colNum + colNum;
                if (i == 0)
                {
                    rowNum = 1;
                }

                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    if(j==0)
                    {
                        mtrx[i, j] = rowNum;
                    }
                    else
                    {
                        rowNum += rowNum;
                        mtrx[i, j] = rowNum;
                    }
                }

                if (i == 0)
                {
                    colNum = 1;
                }
                else
                {
                    colNum += colNum;
                }
                
            }

            for (int i = 0; i < mtrx.GetLength(0) - 1; i++)
            {

                for (int j = i+1; j < mtrx.GetLength(1); j++)
                {
                    sum += mtrx[i, j];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
