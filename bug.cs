public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Simulate an uncommon error: Accessing a disposed object
        using (var stream = new MemoryStream())
        {
            // ... some operations on the stream ...
        }

        //Error: Accessing the stream after it's been disposed
        stream.WriteByte(10);
    }
}