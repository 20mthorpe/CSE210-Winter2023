class Wand
{
    private string _wood;
    private string _core;
    private string _length;
    private string _flexibility;
    public Wand(string wood, string core, string length, string flexibility)
    {
        _wood = wood;
        _core = core;
        _length = length;
        _flexibility = flexibility;
    }
    public void DisplayWandInfo()
    {
        System.Console.WriteLine($"Your Wand is made out of {_wood} wood.");
        System.Console.WriteLine($"Your Wand's core is made out of {_core}.");
        System.Console.WriteLine($"Your Wand is {_length} inches long.");
        System.Console.WriteLine($"Your Wand has {_flexibility} flexibility.");
    }
}