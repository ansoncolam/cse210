public class PromptGenerator {
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt() {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What did you do today?");
        _prompts.Add("What is one thing that made you laugh today?");
        _prompts.Add("what is your plan for the coming weekend?");
        Random randomGenerator = new Random();
        string randomPrompt = _prompts[randomGenerator.Next(1, _prompts.Count)];
        return randomPrompt;
        
    }
}