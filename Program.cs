class ReadFromFile
{
    static void Main()
    {
        // bron: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file
        string[] lines = System.IO.File.ReadAllLines(@"test.txt");// kan makkelijk aangepast worden omdat het maar 1 keer wordt gedeclareerd, gebruik test.txt omdat
        
        foreach (string line in lines){
        int check=1;
        while (check <WordMaker.getHoeveelStrings()){
            foreach (string line2 in lines)//nadeel: moet nog een techniek bedenken om dubbels te verwijderen, eerste actie gaat bijzonder traag
        {
            WordMaker newword = new WordMaker();
            newword.addWordToList(line);
            newword.addWordToList(line2);
            
            
               
                check++;
            }
        }
        }
        foreach (WordMaker word in WordMaker.listing){
            Console.WriteLine(word.toString());
        }
    }
   
}
