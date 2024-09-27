namespace Lab1
{
    public class Task3
    {
        public static int CountOfRabbits(int month)
        {
            int previous = 1;
            int current = 1;
            for (int i = 0; i < month; i++) 
            {
                if(month == 0)
                {
                    return 1;
                }
                if(month == 1) 
                {
                    return 2;
                }
                int temp = current;
                current += previous;
                previous = temp;
            }
            return current;
            
        }
    }
}
