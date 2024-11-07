namespace UdemyDSAs
{
    public static class TestCases
    {
        public static List<int[]> GetArrayTestCases() =>
        [
            new int[] { 6, 1, 5, 0, 7, 4, 2 }, //Unordered base test case
            new int[] { 10, 6, 0, 8, 4, 2, 12 }, //Unordered even numbers
            new int[] { 11, 1, 7, 5, 3, 9, 13 }, //Unordered odd numbers
            new int[] { 3, -5, 1, 0, -1, 5, -3 }, //Unordered mix of negative and positive numbers
            new int[] { 6, 10, 4, 9, 8, 7, 5 }, //Unordered descending order
            new int[] { 0, 0, 0, 0, 0, 0, 0 }, //All zeros
            new int[] { 1 }, //Single element
            [], //Empty array
            new int[] { 400, 100, 500, 300, 200 }, //Unordered large values
            new int[] { 0, int.MinValue, int.MaxValue }, // Unordered boundary values
            new int[]
            {
                37, 3, 19, 25, 89, 17, 53, 9, 81, 99, 65, 27, 49, 5, 13, 75, 41, 93, 45, 1,
                11, 7, 63, 31, 55, 29, 23, 15, 87, 77, 39, 83, 67, 47, 35, 95, 91, 33,
                69, 21, 73, 43, 57, 59, 85, 97, 61, 79, 51
            }
        ];

        public static List<int> GetIntegerTestCases()
        {
            //Flattening the List<int[]> into a single List<int>
            var testCases = GetArrayTestCases();
            var flatTestCases = new List<int>();

            // foreach (var testCase in testCases)
            // {
            //     flatTestCases.AddRange(testCase); //Adding each array's elements to the list
            // }

            flatTestCases.AddRange(testCases.Last());
            
            return flatTestCases
                .Distinct()
                .ToList();
        }
    }
}