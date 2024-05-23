using System;
class Entry {

    private string date = "";

    private string prompt = "";

    private string content = "";

    public Entry(string date, string prompt, string content) {
        this.date = date;
        this.prompt = prompt;
        this.content = content;
    }

    public void Display() {
        Console.WriteLine($"{this.prompt} [{date}]\n{this.content}\n");
    }
}