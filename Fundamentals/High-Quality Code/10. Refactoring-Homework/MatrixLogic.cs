namespace Matrix
{
    public class MatrixLogic
    {
        private const int RotationTimes = 8;
        private static int[] DirectionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
        private static int[] DirectionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };

        public static void Change(ref int dx, ref int dy)
        {
            int cd = 0;
            for (int count = 0; count < RotationTimes; count++)
            {
                if (DirectionsX[count] == dx && DirectionsY[count] == dy)
                {
                    cd = count;
                    break;
                }
            }

            if (cd == 7)
            {
                dx = DirectionsX[0];
                dy = DirectionsY[0];
                return;
            }

            dx = DirectionsX[cd + 1];
            dy = DirectionsY[cd + 1];
        }

        public static bool Check(int[,] arr, int x, int y)
        {
            for (int i = 0; i < RotationTimes; i++)
            {
                if (x + DirectionsX[i] >= arr.GetLength(0) 
                    || x + DirectionsX[i] < 0)
                {
                    DirectionsX[i] = 0;
                }

                if (y + DirectionsY[i] >= arr.GetLength(0) 
                    || y + DirectionsY[i] < 0)
                {
                    DirectionsY[i] = 0;
                }
            }

            for (int i = 0; i < RotationTimes; i++)
            {
                if (arr[x + DirectionsX[i], y + DirectionsY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static void FindCell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    if (arr[row, col] == 0)
                    {
                        x = row;
                        y = col;
                        return;
                    }
                }
            }
        }
    }
}
