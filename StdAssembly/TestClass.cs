namespace ClassLibrary1;

public class TestClass
{
    
    private readonly Dictionary<int, string> _dict = new()
    {
        {1, "one"},
        {2, "two"},
        {3, "three"}
    };
    
    public  string TestMethod(int key)
    {
       

        return _dict.TryGetValue(key, out var value) ? value : "not found";
    }
}