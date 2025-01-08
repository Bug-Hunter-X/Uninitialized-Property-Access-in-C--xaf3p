public class MyClass
{
    public int MyProperty { get; set; } = 0; // Initialize MyProperty

    public void MyMethod()
    {
        // Accessing a property after it's initialized leads to expected behavior.
        Console.WriteLine(MyProperty); // Now using initialized property
    }
}