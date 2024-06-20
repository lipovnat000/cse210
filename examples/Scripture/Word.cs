class Word {

    private string word;

    private bool visible;

    public Word(string word) {
        this.word = word;
        this.visible = true;
    }

    public void Hide() {
        this.visible = false;
    }

    public bool IsHidden() {
        return !this.visible;
    }

    public void Show() {
        this.visible = true;
    }

    public override string ToString() {
        if (this.visible) {
            return word;
        } else {
            string result = "";
            foreach (char c in word)
            {
                if (char.IsLetterOrDigit(c))
                {
                    result += "_";
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }
    }
}