using CustomStack;

MyStack<int> stack = new MyStack<int>();

stack.Push(10);
stack.Push(30);

Console.WriteLine(stack.Size());
int element = stack.Peek();

Console.WriteLine(element);


MyStack<Test> testStack = new MyStack<Test>();

testStack.Push(new Test
{
    IntegerNumber = 123,
    Name = "sda"
});

Test t = testStack.Peek();

Console.WriteLine(t);

var converted = StringExtensions.ConvertUpper("asd");

string x = "Dsada";

Console.WriteLine(x.ConcatStrings("test"));
Console.WriteLine(x.ConvertUpper());

Console.WriteLine(converted);

List<int> ls = new List<int> { 1, 2, 2, 11, 1, 14, 34, 21 };
foreach (var i in ls)
{
    Console.Write($"{i} ");
}

ls.RemoveOdd();
Console.WriteLine();
foreach (var i in ls)
{
    Console.Write($"{i} ");
}