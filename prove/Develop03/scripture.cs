using System;

class Scripture
{
    public List<Verse> _verses = new List<Verse>();

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

    public bool HideWords(int numberWordsClear)
    {
        foreach (int value in Enumerable.Range(1, numberWordsClear)){

            Random random = new Random();
            Verse v = new Verse(verseStr);
            int randomIndex = random.Next((v._words).Count());
            v = _verses[randomIndex];
        }
    }

    public bool IsAllHidden()
    {

        // while not all is hidden
        foreach(Verse v in _verses){
            if (v.IsAllHidden() == false){
                return false;
            }
        }
        return true;
    }

}