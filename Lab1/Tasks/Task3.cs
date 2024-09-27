namespace Lab1
{
    public class Task3
    {
        public static int CountOfRabbits(int month)
        {
            if (month == 0)
            {
                return 1;
            }
            if (month == 1)
            {
                return 2;
            }

            int previous = 1;
            int current = 2;

            for (int i = 2; i <= month; i++)
            {
                int temp = current;
                current += previous;
                previous = temp;
            }

            return current;

        }
    }
}
