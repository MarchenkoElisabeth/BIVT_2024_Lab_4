using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //int[,] A3 = {
        //    { 1, 2, 3, 4, 5 },
        //    { 5, 6, 7, 8 , 5},
        //    { 9, 10, 11, 12,5 },
        //    { 13, 14, 15, 16,5 }
        //};
        //int[,] A6 = {
        //        { 1, 2, 3, 4, 5, 6, 7 },
        //        { 5, 6, 7, 8, -9, 10, 11 },
        //        { 9, 10, -11, -12, -13, -14, -15 },
        //        { -13, -14, 15, 16, 17, 18, -19 }
        //    };
        //int[,] A12 = {
        //        { 1, 2, 3, 4, -5, -6, -7 },
        //        { 5, 11, -17, 11, -10, 6, 5 },
        //        { -9, -10, -11, -14, -15, -16, 1 },
        //        { -9, -10, -11, -14, 15, -6, -2 },
        //        { -9, -10, -11, -14, -15, 6, 4 },
        //        { 0, -2, -3, -4, -5, 0, 5 }
        //    };
        //int[,] A18 = {
        //        { 1, 2, -3, 4, -5, 6, 7 },
        //        { 5, 6, -7, 8, 9, -10, -11 },
        //        { 9, 10, 11, 12, 13, 14, 15 },
        //        { -13, 14, 15, 16, 17, -18, -19 },
        //        { 0, -1, -2, -3, -4, -5, -6 }
        //    };
        //int[,] A21 = {
        //        { 1, 2, -3, 4, -5, 7, 0 },
        //        { 5, 6, -7, 8, 9, -11, 0 },
        //        { 9, 10, 11, 12, 13, 15, 0 },
        //        { -13, 14, 15, 16, 17, -19,0 },
        //        { 0, -1, -2, -3, -4, -6, 0 }
        //    };
        //int[,] A27 = {
        //        { 1, 2, -3, 7, -5, 7, 7 },
        //        { 5, 6, -7, 8, 9, 9, -11 },
        //        { 9, 10, 11, 12, 13, 15, 15 },
        //        { -13, 14, 25, 25, 16, 17, -19 },
        //        { 0, 0, -1, -2, -3, -4, -6 }
        //    };
        //int[,] B7 = {
        //        { 1, 2, -3, 7, 7, 0 },
        //        { 5, 6, -7, 9, -11, 1 },
        //        { 9, 10, 11, 15, 15, 2 },
        //        { -13, 14, 25, 25, -19, 3 },
        //        { 5, 6, -7, 8, 9, 4},
        //        { 0, 0, -1, -2, -3, 5 }
        //    };
        int[,] B9 = {
                { 1, 2, -3, 7, 7, 0, -2 },
                { 5, 6, -7, 9, -11, 1, 3 },
                { 9, 10, 11, 15, 15, 2, 5 },
                { -13, 14, 25, 25, -19, 3, -7 },
                { 5, 6, -7, 8, 9, 4, 4},
                { 0, 0, -1, -2, -3, -5, 0 }
            };
        //program.Task_1_3(A3);
        //program.Task_1_6(A6);
        //program.Task_1_12(A12);
        //program.Task_1_18(A18, A18.GetLength(0), A18.GetLength(1));
        //program.Task_1_21(A21);
        //program.Task_1_27(A27);
        //program.Task_2_6(3);
        //program.Task_2_7(B7);
        program.Task_2_9(B9);
    }

    public void Draw(double[,] array)
    {

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {

                Console.Write($"{array[i, j]}  ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
    public void Draw(int[,] array)
    {

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {

                Console.Write($"{array[i, j]}  ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here

        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here

        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        
        int answer = 0;
        if (A.GetLength(0) != 4 || A.GetLength(1) != 4) return answer;
        // code here
        for (int i = 0; i < A.Length/4; i++)
        {
            answer += A[i,i];
            Console.WriteLine(A.Length);
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0;
        // code here

        // end

        return (row, col);
    }
    public (int, int) Task_1_5(int[,] A, int colIndex)
    {
        int value = 0, rowIndex = -1;
        // code here

        // end

        return (value, rowIndex);
    }
    public int[] Task_1_6(int[,] A)
    {
        if (A.GetLength(0) != 4 || A.GetLength(1) != 7) return null;
        int[] answer = new int[4];
        // code here
        for (int i = 0; i< 4; i++)
        {
            int JMin = 0;
            for (int j = 1; j < 7; j++)
            {
                if (A[i, j] < A[i,JMin]) JMin = j;
            }
            answer[i] = JMin;
            Console.WriteLine(JMin);

        }
        // end

        return answer;
    }
    public int[] Task_1_7(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public double[] Task_1_8(int[,] A)
    {
        double[] answer = default(double[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int JMax = 0;
            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[i, j] > A[i, JMax]) JMax = j;
            }
            int temp = A[i,JMax];
            A[i, JMax] = A[i, 0];
            A[i,0]=temp;
            //Console.WriteLine(JMin);

        }
        // end

        return A;
    }
    public int[,] Task_1_10(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_11(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_12(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;

        int iMax = 0, jMax = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > A[iMax, jMax])
                {
                    jMax = j;
                    iMax = i;
                }
            }
            //Console.WriteLine(JMin);

        }
        //Console.WriteLine($"{iMax}   {jMax}");
        // code here
        int[,] a = new int[5, 6];
        int newI = 0, newJ = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (iMax == i) continue;
            newJ = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (jMax == j) continue;
                a[newI,newJ] = A[i,j];
                newJ++;
            }
            newI++;
            //Console.WriteLine(JMin);

        }
        // end
        A = a;
        return A;
    }
    public int[,] Task_1_13(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[] Task_1_14(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_1_15(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int JMax = 0;
            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[i, j] > A[i, JMax]) JMax = j;
            }
            A[i, JMax]*= i+1;
            //Console.WriteLine(JMin);

        }
        // end

        return A;
    }
    public int[,] Task_1_16(int[,] A, int n, int m)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_17(int[,] B, int n, int m)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_1_18(int[,] D, int n, int m)           ///////////////////////
    {
        // code here
        Draw(D);

        for (int i = 0; i < n; i++)
        {
            if (D[i, 0] < 0) continue;
            int jMax = 0;
            for (int j = 1; j < m; j++)
            {
                if (D[i, j] < 0) break;
                if (D[i,j]> D[i,jMax]) jMax = j;
            }
            if (jMax < m - 1)
            {
                int temp = D[i, jMax];
                D[i, jMax] = D[i, jMax + 1];
                D[i, jMax + 1] = temp;
            }
            //for (int j = m-1; j > jMax; j--)
            //{
            //    if (D[i, j] < 0)
            //    {
            //        int temp = D[i, jMax];
            //        D[i,jMax] = D[i,j];
            //        D[i,j] = temp;
            //        break;
            //    }
            //}
        }
        Console.WriteLine();
        // end
        Draw(D);

        return D;
    }
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
        // code here

        // end

        return C;
    }
    public double[,] Task_1_20(double[,] F, int n, int m)
    {
        // code here

        // end

        return F;
    }
    public int[,] Task_1_21(int[,] H)
    {
        // code here
        if (H.GetLength(0) != 5 || H.GetLength(1) != 7) return null;
        Draw(H);

        for ( int i = 0; i < H.GetLength(0); i++)
        {
            int jMax = 0;
            for (int j = 1; j <  H.GetLength(1)-1; j++)
            {
                if (H[i, j] > H[i,jMax]) jMax = j;
            }
            int temp = H[i, jMax];
            H[i, H.GetLength(1) - 1] = H[i, H.GetLength(1) - 2];
            H[i, H.GetLength(1) - 2] = temp;
        }
        // end
        Console.WriteLine();
        Draw(H);
        return H;
    }
    public double[,] Task_1_22(double[,] Z)
    {
        // code here

        // end

        return Z;
    }
    public int[,] Task_1_23(int[,] G)
    {
        // code here

        // end

        return G;
    }
    public double[,] Task_1_24(double[,] Y)
    {
        if (Y.GetLength(0) != 6 || Y.GetLength(1) != 5) return null;
        // code here
        for (int i = 0; i < Y.GetLength(0); i++)
        {
            int jMax = 0;
            for (int j = 1; j < Y.GetLength(1); j++)
            {
                if (Y[i, jMax] < Y[i,j]) jMax = j;
            }
            double mid = 0, count = 0;
            for (int j = jMax; j < Y.GetLength(1); j++)
            {
                if (j == jMax) continue;
                if (Y[i, j] > 0)
                {
                    mid += Y[i, j];
                    count++;
                }
            }
            if (mid!=0) mid/=count;
            for (int j = 0; j < jMax; j++)
            {
                if (Y[i, j] < 0) Y[i, j] = mid;
            }
        }
        // end

        return Y;
    }
    public int[,] Task_1_25(int[,] X)
    {
        // code here

        // end

        return X;
    }
    public int[,] Task_1_26(int[,] A, int[] B)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_27(int[,] B)
    {
        // code here
        Draw(B);

        if (B.GetLength(0) != 5 || B.GetLength(1) != 7) return null;

        int[] temp = new int[B.GetLength(0)];
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int jMax = 0;
            for (int j = 1; j< B.GetLength(1); j++)
            {
                if (B[i, j] > B[i, jMax]) jMax = j;
            }
            temp[i] = B[i, jMax];
        }
        for(int i = 0; i < B.GetLength(0); i++)
        {
            B[i,3] = temp[4-i];
        }
        // end
        Draw(B);
        return B;
    }
    public int[,] Task_1_28(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_29(int[,] F)
    {
        // code here

        // end

        return F;
    }
    public int[,] Task_1_30(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 5 || B.GetLength(1) != 5) return null;
        // end

        int ijMax = 0, iN = -1;
        for( int i = 1; i < B.GetLength(0); i++)
        {
            if (B[i, i] > B[ijMax,ijMax]) ijMax = i;
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, 2] < 0)
            {
                iN = i;
                break;
            }
        }
        if (iN == -1) return B;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int temp = B[ijMax, i];
            B[ijMax, i] = B[iN, i];
            B[iN,i]= temp;

        }
        return B;
    }
    public int[,] Task_1_31(int[,] A, int[] B)
    {
        // code here

        // end

        return A;
    }
    public double[,] Task_1_32(double[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[] Task_1_33(int[,] A)
    {
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int count = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0) count++;
            }
        }
        // code here
        int[] answer = new int[count];
        count = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0)
                {
                    answer[count] = A[i, j];
                    count++;
                }
            }
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        // end
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int jMax = 0;
            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[i, j] > A[i, jMax]) jMax = j;
            }
            if (jMax == 0)
            {
                if (A[i, jMax + 1] > 0) A[i, jMax + 1] *= 2;
                if (A[i, jMax + 1] < 0) A[i, jMax + 1] /= 2;
            }
            else if (jMax == A.GetLength(1) - 1)
            {
                if (A[i, jMax - 1] > 0) A[i, jMax - 1] *= 2;
                if (A[i, jMax - 1] < 0) A[i, jMax - 1] /= 2;
            }
            else
            {
                if (A[i, jMax - 1] < A[i, jMax + 1])
                {
                    if (A[i, jMax - 1] > 0) A[i, jMax - 1] *= 2;
                    if (A[i, jMax - 1] < 0) A[i, jMax - 1] /= 2;
                }
                else
                {
                    if (A[i, jMax + 1] > 0) A[i, jMax + 1] *= 2;
                    if (A[i, jMax + 1] < 0) A[i, jMax + 1] /= 2;
                }
            }
        }
        return A;
    }
    
    public int[,] Task_2_2(int[,] A)      ///////        ERROR
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        // end
        Draw(A);
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int iMax = 0, countP = 0, countN = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > 0) countP++;
                if (A[i, j] < 0) countN++;
                if (A[i, j] > A[iMax, j]) iMax = i;
            }
            if (countP > countN)
            {
                A[iMax, j] = 0;
            }
            else A[iMax, j] = iMax;// + 1;                     /////////     index вместо номера
        }
        Draw(A);
        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;
        // code here
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int iMax = 0, sumAfterMax = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[iMax, j])
                {
                    iMax = i;
                    sumAfterMax = 0;
                }
                else
                {
                    sumAfterMax += A[i, j];
                }
            }
            if (iMax < 5) A[0, j] = sumAfterMax;

        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return null;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int iMax = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[iMax, j])
                    iMax = i;
            }
            if (B[j] > A[iMax, j]) A[iMax, j] = B[j];

        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A) ///////        ERROR
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int iMax = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[iMax, j])
                    iMax = i;
            }
            if ((A[0, j] + A[A.GetLength(0) - 1, j]) / 2.0 > A[iMax, j]) A[iMax, j] = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2.0;
            else A[iMax, j] = iMax; //+1      /////////     index вместо номера     

        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n < 0) return null;
        int[,] answer = new int[n,n*3];
        // code here
        Draw(answer);
        for (int i = 0; i < n; i++)
        {
            answer[i, i] = 1;
            answer[i,i+n] = 1;
            answer[i, i + 2*n] = 1;
        }
        // end
        Draw(answer);
        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        // end
        Draw(A);
        int iMax = 0;
        for (int i = 1; i < A.GetLength(0); i++)
        {
            if (A[i, i] > A[iMax, iMax]) iMax = i;
        }
        for (int i = 0; i < iMax; i++)
        {
            for (int j = i+1; j < A.GetLength(1); j++)
            {
                A[i, j] = 0;
            }
        }
        Draw(A);
        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;
        for (int i = 0; i < B.GetLength(0); i += 2)
        {
            int jMax1 = 0, jMax2 = 0;
            for(int j = 1; j < B.GetLength(1); j++)
            {
                if (B[i,j] > B[i, jMax1]) jMax1 = j;
            }

            for (int j = 1; j < B.GetLength(1); j++)
            {
                if (B[i+1, j] > B[i+1, jMax2]) jMax2 = j;
            }
            int temp = B[i, jMax1];
            B[i,jMax1] = B[i+1,jMax2];
            B[i+1,jMax2] = temp;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        Draw(A);
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1)/2; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, A.GetLength(1) - 1 - j];
                A[i, A.GetLength(1) - 1 - j] = temp;
            }
        }
        Draw(A);
        // end

        return A;
    }
    #endregion
    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_5(int[,] matrix, int k)
    {
        // code here

        // end

        return matrix;
    }
    public (int[], int[]) Task_3_6(int[,] matrix)
    {
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here

        // end

        return (upper, lower);
    }
    public int[] Task_3_7(int[] A, int[] B, int n)
    {
        int[] answer = default(int[]);

        // code here

        // end

        return answer;
    }
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    #endregion
}
