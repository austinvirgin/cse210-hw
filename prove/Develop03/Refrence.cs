using System;
using System.Collections.Concurrent;
using System.Runtime;
using System.Runtime.CompilerServices;
class Refrence{
    private string _book = "2nd Nephi";
    private int _chapter = 2;
    private int _verse;
    public List<Verse> _verses = new List<Verse>();

    public Refrence(int verse1){
        _book = "2nd Nephi";
        _chapter = 2;
        Verse newverse = new Verse(verse1);
        newverse.SetVerseNum(verse1);
        _verses.Add(newverse);
    }
    public Refrence(int verse1, int verse2){
        _book = "2nd Nephi";
        _chapter = 2;
        int[] verses = {verse1, verse2};
        foreach (int verse in verses){
            Verse newverse = new Verse(verse);
            newverse.SetVerseNum(verse);
            _verses.Add(newverse);
        }
    }
    public int GetChapter(){
        return _chapter;
    }

    public void SetChapter(int chapter){
        _chapter = chapter;
    }

    public int GetVerse(){
        return _verse;
    }

    public void SetVerse(int verse){
        _verse = verse;
    }

    public string GetBook(){
        return _book;
    }
    public void SetBook(string book){
        _book = book;
    }
    
    public void DisplayVerse(){
        foreach (Verse verse in _verses)
        {
            Console.Write($"{verse.GetVerseNum()} ");
            verse.DisplayWords();
            Console.WriteLine("");
            Console.WriteLine("");
        }

    }
    public int Count(){
        return _verses.Count;
    }

    public bool AllHidden(){
        foreach (Verse verse in _verses)
        {
            if (verse.AllHidden() == false){
                return false;
            }
        }
        return true;
    }
        public int AllNonHiddenNum(){
        int amount = 0;
        foreach (Verse verse in _verses)
        {
            amount += verse.Amount();
        }
        return amount;
    }
}