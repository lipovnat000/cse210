// This class generates prompts for a writing exercise.
public static class PromptGenerator
{
    // An array of prompts.
    private static readonly string[] prompts = {
        "Describe a memorable event from your childhood.",
        "What are your goals for the next five years?",
        "Write about someone who has had a significant impact on your life.",
        "What are you grateful for today?",
        "Describe a challenge you faced and how you overcame it.",
        "What are your thoughts on your current job or studies?",
        "Write about a place you would like to visit and why.",
        "What is your favorite hobby and why do you enjoy it?",
        "Describe a recent book you read and what you learned from it.",
        "What are your thoughts on the importance of self-care?"
    };
    
    // This method returns a random prompt from the prompts array.
    // Returns:
    //     A random prompt as a string.
    public static string GetPrompt()
    {
        // Create a new instance of the Random class.
        Random rand = new Random();
        
        // Generate a random index within the range of the prompts array.
        int index = rand.Next(prompts.Length);
        
        // Return the prompt at the generated index.
        return prompts[index];
    }
}
