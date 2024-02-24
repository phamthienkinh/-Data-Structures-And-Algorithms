namespace WayTooLongWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new Reader();
            var n = reader.NextInt();
            var testcase = new List<string>();
            for (var i = 0; i < n; i++)
            {
                testcase.Add(reader.Next());
            }
            foreach (var curentTest in testcase)
            {

                if (curentTest.Length > 10)
                {
                    var lenghtBetween = curentTest.Length - 2;

                    var firstChar = curentTest[0].ToString();
                    var lastChar = curentTest[curentTest.Length - 1].ToString();
                    Console.WriteLine(firstChar + lenghtBetween + lastChar);
                }
                if (curentTest.Length <= 10)
                {
                    Console.WriteLine(curentTest);
                }
            }
        }
    }
    class Reader
    {
        private int index = 0;
        private string[] tokens;
        public string Next()
        {
            while (tokens == null || tokens.Length <= index)
            {
                tokens = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                index = 0;
            }
            return tokens[index++];
        }
        public int NextInt()
        {
            return int.Parse(Next());
        }

        public long NextLong()
        {
            return long.Parse(Next());
        }

        public double NextDouble()
        {
            return double.Parse(Next());
        }
    }
}
