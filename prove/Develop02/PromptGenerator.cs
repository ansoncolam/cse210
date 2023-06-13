public class PromptGenerator {

    public static string GetRandomPrompt() {
        
        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts.Add("What did you do today?");
        prompts.Add("What is one thing that made you laugh today?");
        prompts.Add("what is your plan for the coming weekend?");

        Random randomGenerator = new Random();
        int randNumber = randomGenerator.Next(1, prompts.Count);

        return prompts[randNumber];

    }

}