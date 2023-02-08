using System;

class Verse
{
    private List<Word> _words = new List<Word>();
    public Verse(string verse)
    {
        char[] delimiterChars = {' ', ',', '.', ':', '\t'};
        string[] words = verse.Split(delimiterChars);
        foreach (string wordStr in words)
        {
            Word word = new Word(wordStr);
            _words.Add(word);
        } 
    }
    public void Display(bool AddNewLine = true)
    {
        foreach(Word w in _words)
        {
            w.Display();
            System.Console.Write(" ");
        }
        System.Console.WriteLine(" ");
    }

    public Verse()
    {

    }

}