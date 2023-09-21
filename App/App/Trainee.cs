

public class Trainee
{
    public string Name { get; set; }
    public int ID { get; set; }
    public override string ToString()
    {
        return Name;
    }
    public override bool Equals(object obj)
    {
        return ID == ((Trainee)obj).ID;
    }
    public override int GetHashCode()
    {
        return ID;
    }
}