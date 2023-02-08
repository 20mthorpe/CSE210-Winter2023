using System;

class Scripture
{
    private List<Verse> _verses = new List<Verse>();

    public Scripture(List<string> verses)
    {
        foreach (string verseStr in verses)
        {
            Verse verse = new Verse(verseStr);
            _verses.Add(verse);
        }
    }

    public void Display()
    {
        foreach(Verse v in _verses)
        {
            v.Display();
        }
    }

    public bool HideWords(int count)
    {

    }

    public bool IsAllHidden()
    {
        // while not all is hidden
    }

}