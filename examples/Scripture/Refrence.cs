class Reference {

    private List<Word> words = new List<Word>();

    private List<int> visibleIndices = new List<int>();
    
    private int visibleCount;
    
    public Reference(string reference) {
        string[] words = reference.Split(' ');
        for (int i = 0; i < words.Length; i++) {
            this.words.Add(new Word(words[i]));
            this.visibleIndices.Add(i);
        }
        this.visibleCount = words.Length;
    }
    public void HideWords(int amountToHide = 3)
    {
        Random random = new Random();
        for (int i = 0; i < amountToHide; i++)
        {
            if (this.visibleCount == 0)
            {
                break;
            }
            int index = random.Next(0, this.visibleCount);
            this.words[this.visibleIndices[index]].Hide();
            this.visibleIndices.RemoveAt(index);
            this.visibleCount--;
        }
    }

    public bool IsHidden() {
        return this.visibleCount == 0;
    }

    public override string ToString() {
        string result = "";
        foreach (Word word in words) {
            result += word.ToString() + " ";
        }
        return result.Trim();
    }
}