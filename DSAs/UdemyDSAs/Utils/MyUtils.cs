using System.Collections;

namespace UdemyDSAs.Utils
{
    public static class MyUtils
    {
        public static void Display<TSource>(TSource source)
        {
            if (source is IEnumerable collection)
            {
                foreach (var item in collection)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(source);
            }
        }

        public static void InvokeSortMethod(IEnumerable<int[]> testCases, Func<int[], int[]> method, string methodName)
        {
            Console.WriteLine($"Testing {methodName} on all test cases:");
            Console.WriteLine("--------------------------------------------------");

            foreach (var testCase in testCases)
            {
                Console.WriteLine("  * Original Array:");
                Display(testCase);

                Console.WriteLine($"\n=> {methodName} Result:");
                Display(method((int[])testCase.Clone()));

                Console.WriteLine("--------------------------------------------------");
            }
        }

        public static void InvokeSearchMethod(IEnumerable<int[]> testCases, Func<int[], int> method, string methodName)
        {
            Console.WriteLine($"Testing {methodName} on all test cases:");
            Console.WriteLine("--------------------------------------------------");
            
            foreach (var testCase in testCases)
            {
                Console.WriteLine("  * Original Array:");
                Display(testCase);

                Console.WriteLine($"\n=> {methodName} Result:");
                Display(method((int[])testCase.Clone()));

                Console.WriteLine("--------------------------------------------------");
            }
        }
        
        public static void InvokeRecursionMethod(IEnumerable<int> testCases, Action<int> method, string methodName)
        {
            Console.WriteLine($"Testing {methodName} on all test cases:");
            Console.WriteLine("--------------------------------------------------");
            
            foreach (var testCase in testCases)
            {
                Console.WriteLine("  * Original Array:");
                Display(testCase);

                Console.WriteLine($"\n=> {methodName} Result:");

                Console.WriteLine("--------------------------------------------------");
            }
        }
    }
}