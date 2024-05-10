// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");








int myNum = 5;
double myDoubleNum = 10.92F;
string myText = "kekmek var her";

Console.WriteLine(myText);
Console.WriteLine(myDoubleNum);
Console.WriteLine(myNum);


string[] midLaner = { "Sylas", "Syndra", "Xerath", "Azir", "Corki", "Ziggs" };
//Console.WriteLine(midLaner[0]);

for (int i = 0; i < midLaner.Length; i++)
    Console.WriteLine(midLaner[i]);

List<string> Jungler = new List<string>();

Jungler.Add("Graves");
Jungler.Add("Hecarim");
Jungler.Add("Evelynn");
Jungler.Add("Kha'zix");
Jungler.Add("Lee sin");
Jungler.Add("Elise");

Jungler.Remove("Hecarim");
foreach (string s in Jungler)
    Console.WriteLine(s);

Adc adc = new Adc("Utility", "Ashe");
Adc adc1 = new Adc("Dps", "Kog'Maw");
Adc adc2 = new Adc("Dps", "Draven");


adc.GetAdc();
adc1.GetAdc();
adc2.GetAdc();

string sentance = "Never give up. you cant give up.";

string[] subs = sentance.Split(' ', '.');

foreach(string sub in subs)
{
    Console.WriteLine($"Substring: {sub}");
}


// doesnt work
//class Programs
//{
//    public static int AddNumber(int a, int b)
//    {
//        return a + b;
//    }
//    static void Main()
//    {
//        Console.WriteLine(AddNumber(6, 6));
//    }
//}