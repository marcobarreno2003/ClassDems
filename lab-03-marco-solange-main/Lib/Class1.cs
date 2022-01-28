namespace Lib; // Marco Barreno & Solange Ruiz / 25 January 2022 / IStringList
interface IStringList
{
    void Append(string value);

    // index of 0 refers to the first item
    string GetAt(int index);

    int GetLength();
}
public class StringArrayList : IStringList
{
    private string [] values;
    private int valuecount;
    public StringArrayList(int initialCapacity = 10)
    {
        values = new string [initialCapacity];
        valuecount = 0;
    }

    public void Append(string value)
    {
        values[valuecount++] = value; 
    }

    public string GetAt(int index)
    {
        
        return "fixme";
    }

    public int GetLength()
    {
        
        return valuecount;
    }

    public int GetCapacity()
    {
        
        return values.Length;
    }


}
