using System;

class Scripture
{
    public List<Verse> _verses = new List<Verse>();

    public Scripture(List<Verse> verses)
    {
        _verses = verses;
    }

    public void Display()
    {
        foreach(Verse v in _verses)
        {
            v.Display();
        }
    }

    public void HideWords(int numberWordsClear)
    {
        int i = 0;
        while ((i<numberWordsClear) && (!IsAllHidden()))
        {
            //pick a random verse and set to v
            Random rnd = new Random();
            int rnd_verse = rnd.Next(_verses.Count());
            //if v is not all hidden ask verse to hide a word
            if (_verses[rnd_verse].IsAllHiddenV() == false)
            {
                _verses[rnd_verse].HideWord();
                i++;
            }
        }
    }

    public bool IsAllHidden()
    {
        // while not all is hidden
        foreach(Verse v in _verses){
            if (v.IsAllHiddenV() == false){
                return false;
            }
        }
        return true;
    }

}