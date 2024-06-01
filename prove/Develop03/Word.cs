using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.InteropServices;
class Word{
    private bool _hidden;
    private string _word;

    public Word(string word, bool hidden = false){
        _word = word;
        _hidden = hidden;
    }
    
    public void SetHidden(bool hidden){
        _hidden = hidden;
    }

    public bool GetHidden(){
        return _hidden;
    }

    public void SetWord(string word){
        _word = word;
    }

    public string GetWord(){
        return _word;
    }

    public void DisplayWord(){
        if (_hidden){
            int wordlen = _word.Length;
            for (int i = 0; i < wordlen; i++){
                Console.Write("_");
            }
            Console.Write(" ");
        }
        else{
            Console.Write($"{_word} ");
        }
    }
    public bool AllHidden(){
        if (_hidden)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
        public int Amount(){
        if (_hidden)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }
}