using System;

class Verse
{
    public List<Word> _words = new List<Word>();
    private string _reference;
    private int count;
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
    public List<Word> GetWords(){
        return _words;
    }
    public void Display(bool AddNewLine = true)
    {
        System.Console.WriteLine(_reference);

        foreach(Word w in _words)
        {
            w.Display();
            System.Console.Write(" ");
        }
        System.Console.WriteLine(" ");
    }

    public Verse(string verse, string reference){
        _reference = reference;
        char[] delimiterChars = {' ', ',', '.', ':', '\t'};
        string[] words = verse.Split(delimiterChars);
        foreach (string wordStr in words)
        {
            Word word = new Word(wordStr);
            _words.Add(word);
        }
    }

    public int GetCount(){
        count = _words.Count;
        return count;
    }

    public bool IsAllHidden()
    {
        List<string> hiddenList = new List<string>();
        // while not all is hidden
        foreach(Word word in _words){
            if (word._hidden == false){
                hiddenList.Add("hidden");
            }
            else {
                hiddenList.Add("Not hidden");
            }
        }

        if (hiddenList.Contains("Not hidden")){
            return false;
        }
        else{
            return true;
        }
    }
}