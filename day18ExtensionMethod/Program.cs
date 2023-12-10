namespace day18ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 12345;
            //Console.WriteLine(x.Mirror());


            //var emp = new {id = 1, name = "sara", salary = 1000};

            //Console.WriteLine(emp.GetType().Name);


            //List <int > list1 = new List<int> { 1,2,3,4,5,6,7,8,9};
            //List <int> result = Enumerable.Where (list1, x => x%2 != 0).ToList ();
            //foreach (var x in result)
            //{
            //    Console.WriteLine (x);


            //}






            List<int> lst = new List<int>() { 1,2,3,4,5,6,7,8,9};
            var ls = lst.Where(i=> i%2==0).ToList();
            Console.WriteLine(lst.GetType());

            lst.Remove(2);
            lst.AddRange(new int[] {10,11,12,13,14});

            foreach (int i in ls.ToList())
            {
                Console.WriteLine($"{i}");
            }
            lst.AddRange(new int[] { 15,16, 17, 18, 19 });

            Console.WriteLine("  ");

            foreach (int i in ls)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("");




        }
    }
}