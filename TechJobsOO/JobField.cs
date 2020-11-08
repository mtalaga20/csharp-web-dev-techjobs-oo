using System;

public abstract class JobField
{
    
    public int Id { get; }
    private static int nextId = 1;
    public string Value { get; set; }

    public JobField()
    {
        Id = nextId;
        nextId++;
    }
    public JobField(string value)
    {
        Value = value;
    }

    public abstract bool Equals(object obj);

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }


    public override string ToString()
    {
        return Value;
    }
}
   
