using UdemyDSAs;
using UdemyDSAs.LinkedList;

var integerArrayTestCases = TestCases.GetArrayTestCases();
var integerTestCases = TestCases.GetIntegerTestCases();

// MyUtils.InvokeRecursionMethod(integerTestCases, Recursion.Calculate, nameof(Recursion.Calculate));
// MyUtils.InvokeRecursionMethod(integerTestCases, Recursion.TreeCalculate, nameof(Recursion.TreeCalculate));
// MyUtils.InvokeRecursionMethod(integerTestCases, Recursion.HeadCalculate, nameof(Recursion.HeadCalculate));
//
// MyUtils.InvokeSearchMethod(integerArrayTestCases, input => Search.RecursionBinary(input, 1, 0, input.Length - 1), nameof(Search.RecursionBinary));
//
// MyUtils.InvokeSortMethod(integerArrayTestCases, Sort.Selection, nameof(Sort.Selection));
// MyUtils.InvokeSortMethod(integerArrayTestCases, Sort.Insertion, nameof(Sort.Insertion));
// MyUtils.InvokeSortMethod(integerArrayTestCases, Sort.Bubble, nameof(Sort.Bubble));
// MyUtils.InvokeSortMethod(integerArrayTestCases, Sort.Shell, nameof(Sort.Shell));
// MyUtils.InvokeSortMethod(integerArrayTestCases, input => Sort.Merge(input, 0, input.Length - 1), nameof(Sort.Merge));
// MyUtils.InvokeSortMethod(integerArrayTestCases, input => Sort.Quick(input, 0, input.Length - 1), nameof(Sort.Quick));


var linkedList = new LinkedList();
linkedList.AddLast(10);
linkedList.AddLast(20);
linkedList.AddLast(50);
linkedList.AddLast(60);
linkedList.AddLast(90);