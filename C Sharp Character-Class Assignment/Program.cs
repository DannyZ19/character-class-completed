// Create a Character class

// TASK 1 \\ 
class Character 
{
     
    public string Name;
    public string PhraseOne;
    public string PhraseTwo;
    public int level = 0;
   
    // Define constructor method
    public Character(string name, string phrase1, string phrase2)
    {
        Name = name;
        PhraseOne = phrase1;
        PhraseTwo = phrase2;
        
        
    }

    // Methods (Functions / Behaviour)
    public void Speak(int phraseNum)
    {
        if (phraseNum == 1)
        {
            Console.WriteLine(PhraseOne);
        } else if (phraseNum == 2)
        {
            Console.WriteLine(PhraseTwo);
        }
        

    }

    public void SetLevel(int newLevel)
    {
        int finalLevel = level + newLevel;
        Console.WriteLine($"Character is now level {finalLevel}! ");
    }




    // TASK 2 \\ 

    static void Main(string[] args)
    {
        Character Po = new Character("Kung Fu Panda", "Skadoosh", "You have been blinded by pure awesomeness!");
        Character Parker = new Character("Spiderman", "My Spider-Sense is tingling", "Your friendly neighbourhood Spider-Man");


        // TASK 3 \\
        Po.Speak(1);
        Po.SetLevel(2);
        Po.Speak(2);
    }
   
}
