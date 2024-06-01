using System.Dynamic;

class Verse{
    private int _verseNumber;
    public List<Word> _words;
    public Verse(int verse){
        _words = new List<Word>();
        if (verse == 11){
            verse11();
        }
        else if (verse == 12){
            verse12();
        }
    }
    public List<Word> GetWords(){
        return _words;
    }
    public void AddWord(Word word){
        _words.Add(word);
    }

    public int GetVerseNum(){
        return _verseNumber;
    }

    public void SetVerseNum(int verseNumber){
        _verseNumber = verseNumber;
    }
    public void DisplayWords(){
        foreach (Word word in _words){
            word.DisplayWord();
        }
    }

    public void verse11(){
        string[] words = {"For", "it", "must", "needs", "be,", "that", "there", "is", "an", "opposition", 
            "in", "all", "things.", "If", "not", "so,", "my", "firstborn", "in", "the", 
            "wilderness,", "righteousness", "could", "not", "be", "brought", "to", "pass,", 
            "neither", "wickedness,", "neither", "holiness", "nor", "misery,", "neither", 
            "good", "nor", "bad.", "Wherefore,", "all", "things", "must", "needs", "be", 
            "a", "compound", "in", "one;", "wherefore,", "if", "it", "should", "be", "one", 
            "body", "it", "must", "needs", "remain", "as", "dead,", "having", "no", "life", 
            "neither", "death,", "nor", "corruption", "nor", "incorruption,", "happiness", 
            "nor", "misery,", "neither", "sense", "nor", "insensibility."};
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }


    public void verse12(){
        List<string> words = new List<string> { "Wherefore,", "it", "must", "needs", "have", 
        "been", "created", "for", "a", "thing", "of", "naught;", "wherefore", "there", "would", 
        "have", "been", "no", "purpose", "in", "the", "end", "of", "its", "creation.", "Wherefore,", 
        "this", "thing", "must", "needs", "destroy", "the", "wisdom", "of", "God", "and", "his", 
        "eternal", "purposes,", "and", "also", "the", "power,", "and", "the", "mercy,", "and", "the", 
        "justice", "of", "God." };
        foreach (string word in words){
            _words.Add(new Word(word));
        }
    }
    public int Count(){
        return _words.Count;
    }

    public bool AllHidden(){
        foreach (Word word in _words)
        {
            if  (word.AllHidden() == false){
                return false;
            }
        }
        return true;
    }
    public int Amount(){
        int amount = 0;
        foreach (Word word in _words)
        {
            amount += word.Amount();
        }
        return amount;
    }
}