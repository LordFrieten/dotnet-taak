class WordMaker
{
    public static List<WordMaker> listing;//maakt lijstje van alle woorden aan
    private static int hoeveelLetters;//controleert hoeveel letters je mag hebben
    
    public static int getHoeveelLetters(){//enkel get zodra gezet
        return hoeveelLetters;
    }
    
    private static int hoeveelStrings;//vglbaar met vorige variabele
    public static int getHoeveelStrings(){
        return hoeveelStrings;
    }
    private string word;// laatste woord ip het einde van de string, spaart een for loop uit
    public string getWord(){
        return word;
    }
    private void addString(string addingString){// er wordt enkel toegevoegd
        word += addingString;
    }
    private List<string> listOfWords;// oefening vraagt om dit bij te houden, dus wordt dit bijgehouden
    public void addWordToList(string newword){
        if(WordMaker.getHoeveelLetters()>=(word+newword).Length) {
            addString(newword);
            listOfWords.Add(newword);
        }
    }
    public string toString(){// finale string
        string result = "";
        foreach (string newword in listOfWords){
            result += newword + "+";
        }
        result +="="+ getWord();
        return result;
    }
    static WordMaker(){//static, gebeurt eerste keer dat een constructor gevraagd wordt
        listing = new List<WordMaker>();
        hoeveelLetters=6;// woorbereiding tot expansie
        hoeveelStrings=2;// voorbereiding tot expansie met meer woorden (werkt nog niet)

    }
    public WordMaker(){// constructor
        word = "";
        listOfWords = new List<string>();
        listing.Add(this);
    }

} 

