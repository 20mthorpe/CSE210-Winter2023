using System;

class Word
{
    private String _text = "";
    public bool _hidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Display()
    {
        if (_hidden)
        {
            foreach(char c in _text)
            {
                Console.Write("_");
            }
        } else {
            System.Console.Write(_text);
        }
    }

    public void HideWord(){
        _hidden = true;
    }
}