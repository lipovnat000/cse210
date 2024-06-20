class Scripture {
    
    private string book;

    private int chapter;

    private int verseStart;

    private int verseEnd;

    private Reference reference;

    public Scripture(string book, int chapter, int verseStart, string reference) {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = verseStart;
        this.reference = new Reference(reference);
    }

    public Scripture(string book, int chapter, int verseStart, int verseEnd, string reference) {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = verseEnd;
        this.reference = new Reference(reference);
    }

    public void Practice(int amountToHide = 3) {
        bool running = true;
        while (running) {
            Console.Clear();
            
            if (this.reference.IsHidden()) {
                // Show one last time with everything hidden before automatically quitting.
                running = false;
                Console.WriteLine("You have hidden all the words. Press enter to continue.");
            }
            else{
                Console.WriteLine($"{this}\n\nPress enter to continue or type 'quit' to finish.");
            }
            
            string input = Console.ReadLine();
            if (input == "quit") {
                break;
            }
            this.reference.HideWords(amountToHide);
        }
    }

    public override string ToString() {
        string result = book + " " + chapter + ":" + verseStart;
        if (verseStart != verseEnd) {
            result += "-" + verseEnd;
        }
        result += " " + reference.ToString();
        return result;
    }
}