namespace CSExercises
{
    public class Ex43
    {
        public static int Hex(int i)
        {
            int j,s=i%2;
            int[] remain;
            remain = new int[100];
            for (j = 0; j < 100; j++)
                do
                {
                    remain[j] = i % 2;
                    i = i / 2;
                    s = s + remain[j] * 10^i;
                } while (i >= 2);

                return s;
        }
    }
}
