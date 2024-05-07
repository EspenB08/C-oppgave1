
using System.Data;

public class Adc
{
    public string? Typing { get; set; }
    public string? Name { get; set; }

 
public Adc(string? typing, string? name)
{
    Typing = typing;
    Name = name;

}

public void GetAdc()
{
       
    Console.WriteLine($"Champion name: {Name}, Champion class: {Typing}");
}
}