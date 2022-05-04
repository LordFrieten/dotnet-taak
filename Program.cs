class ReadFromFile
{
    static void Main()//applicatie runt met standaard dotnet run van dotnet sdk
    {
        // bron: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file
        string[] lines = System.IO.File.ReadAllLines(@"input.txt");// kan makkelijk aangepast worden omdat het maar 1 keer wordt gedeclareerd, gebruik test.txt omdat
        
        foreach (string line in lines){
        
            foreach (string line2 in lines)//nadeel: moet nog een techniek bedenken om dubbels te verwijderen, eerste actie gaat bijzonder traag
        {
            WordMaker newword = new WordMaker();
            newword.addWordToList(line);
            newword.addWordToList(line2);
            
            
               
                
            }
        
        }

        foreach (string word in WordMaker.allUnique()){//poging tot dubbels uit presentatie te halen
            Console.WriteLine(word);
        }
    }
   
}
