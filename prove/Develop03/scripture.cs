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

    public bool HideWords()
    {
        foreach (Verse v in _verses){

            Random random = new Random();
            int randomIndex = random.Next((v._words).Count);
            v._words[randomIndex] = HideWord();
        }
    }

    public bool IsAllHidden()
    {
        // while not all is hidden
        foreach(Verse verse in _verses){
            if verse(IsAllHidden()){
                
            }
        }
    }

}