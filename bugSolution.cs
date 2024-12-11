public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Correct: All stream operations are within the using block
        using (var stream = new MemoryStream())
        {
            // ... some operations on the stream ...
            stream.WriteByte(10);
        }
    }
}