public class Scripture {

    private Reference _reference;
    private List<Word> _words;
    
    public Scripture(Reference reference, string text) {

        _reference = reference;
        _words = new List<Word>();
        List<string> myList = text.Split(" ").ToList();
        foreach (string part in myList) {
            Word myWord = new Word(part);
            _words.Add(myWord);
        }

    }

    public void HideRandomWords(int numberToHide) {

        int wordCount = _words.Count();
        int shownTotal = 0;

        for (int i = 0; i < wordCount; i++) {
            if (_words[i].IsHidden() == false) {
                shownTotal = shownTotal + 1;
            }
        }

        if (shownTotal <= numberToHide) {
            for (int i = 0; i < wordCount; i++) {
                _words[i].Hide();
            }
        } else {
            for (int i = 0; i < numberToHide; i++) {
                Random randomNumber = new Random();
                int randNum = randomNumber.Next(0, wordCount);
                if (_words[randNum].IsHidden() == false) {
                    _words[randNum].Hide();
                } else {
                    i = i - 1;
                }
            }
        }
        
    }

    public void GetDisplayText() {
        Console.Write($"{_reference.GetDisplayText()} ");
        int wordCount = _words.Count();
        for (int i = 0; i < wordCount; i++) {
            Console.Write($"{_words[i].GetDisplayText()}");
            Console.Write(" ");
        }
        Console.WriteLine();
    }

    public bool IsCompletelyHidden() {

        int wordCount = _words.Count();
        int shownTotal = 0;

        for (int i = 0; i < wordCount; i++) {
            if (_words[i].IsHidden() == false) {
                shownTotal = shownTotal + 1;
            }
        }

        if (shownTotal == 0) {
            return true;
        } else {
            return false;
        }

    }
    
}