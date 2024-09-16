using Lab1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double result = 0;
            double resTask1 = Task1.Convertor(32, "F", "C");
            Assert.Equal(result, resTask1);
        }
        [Fact]
        public void Test2()
        {
            string word = "мадам";
            bool resTask2 = Task2.Polindrom(word);
            Assert.True(resTask2);

            string word2 = "bobus";
            bool res2Task2 = Task2.Polindrom(word2);
            Assert.False(res2Task2);
        }
        [Fact]
        public void Test3()
        {
            int month = 6;
            int countRab = Task3.CountOfRabbits(month);
            Assert.Equal(21, countRab);

            int month2 = 1;
            int countRab2 = Task3.CountOfRabbits(month2);
            Assert.Equal(2, countRab2);
        }
    }
}