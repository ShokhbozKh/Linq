namespace linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
            };

            var linkResult = from item in numbers
                             where item % 2 == 0
                             select item;

            foreach (var item in linkResult)
            {
                Console.WriteLine(item);
            }
        }
    }
}
