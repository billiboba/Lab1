namespace Lab1
{
    public class Task2
    {
        public static bool Polindrom(string word)
        {
            string word_polindrom = new string(word.Reverse().ToArray());
            bool isPalindrome = word == word_polindrom;
            return isPalindrome;
        }
    }
}
