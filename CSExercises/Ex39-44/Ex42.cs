namespace CSExercises
{
    public class Ex42
    {
        public static int FindWord(string s1, string s2)
        {
            int index;
            if (s1.Contains(s2))
            {
                index = s1.IndexOf(s2);
                return index;
            }
            else return -1;
        }
    }
}
