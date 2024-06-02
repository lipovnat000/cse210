class Scripture
{
    private Reference reference;
    private string text;
    private List<Word> words;
    private static Random random = new Random();

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        this.text = text;

        this.words = new List<Word>();
        string[] textArray = text.Split(" ");
        foreach (string word in textArray) {
            this.words.Add(new Word(word));
        }
    }

   public void Practice(int amountToHide = 3)
    {
        string control = "";
        while (!AllWordsHidden() && control.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine(this.ToString());

            int hiddenInLoop = 0;
            while (hiddenInLoop < amountToHide && !AllWordsHidden())
            {
                int index = random.Next(0, this.words.Count);

                if (!this.words[index].IsHidden())
                {
                    this.words[index].Hide();
                    hiddenInLoop++;
                }
            }

            if (AllWordsHidden())
            {
                break;
            }

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            control = Console.ReadLine();
        }

        if (control.ToLower() != "quit")
        {
            for (int i = 0; i < this.words.Count; i++)
            {
                this.words[i].Hide();
            }

            Console.Clear();
            Console.WriteLine(this.ToString());
        }

        Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
        Console.ReadLine();
    }

    private bool AllWordsHidden()
    {
        return this.words.All(word => word.IsHidden());
    }


    public override string ToString() {

        string textString = "";

        textString += this.reference.ToString() + " ";

        foreach (Word word in this.words) {
            textString += word.ToString() + " ";
        }

        return textString;
    }

}

