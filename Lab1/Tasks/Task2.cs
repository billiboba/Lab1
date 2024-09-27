namespace Lab1
{
    public class Task2
    {
        public static bool Polindrom(string word)
        {
            word = word.ToLower();
            string word_polindrom = new(word.Reverse().ToArray());
            bool isPalindrome = word == word_polindrom;
            return isPalindrome;
        }
    }
}
