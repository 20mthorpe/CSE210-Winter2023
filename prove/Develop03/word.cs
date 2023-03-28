using System;

class Word
{
    private String _text = "";
    public bool _hidden = false;

    public Word(string text)
    {
        _text = text;
    }
    public bool IsHiddenW()
    {
        if (_hidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
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
    public void Hide(){
        _hidden = true;
    }
}