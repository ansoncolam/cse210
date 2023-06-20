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
        for (int k = 0; k < numberToHide; k++) {
            Random randomNumber = new Random();
            int randNum = randomNumber.Next(1, wordCount);
            if (_words[randNum].IsHidden() == false) {
                _words[randNum].Hide();
            } else {
                k = k - 1;
            }
        }
    }

    //     public void HideRandomWords(int numberToHide) {
    //     int wordCount = _words.Count();
    //     for (int k = 0; k < numberToHide; k++) {
    //         Random randomNumber = new Random();
    //         int randNum = randomNumber.Next(1, wordCount);
    //         if (_words[randNum].IsHidden() == false) {
    //             _words[randNum].Hide();
    //         } else {
    //             k = k - 1;
    //         }
    //     }
    // }

    public void GetDisplayText() {
        Console.Write($"{_reference.GetDisplayText()} ");
        int wordCount = _words.Count();
        for (int j = 0; j < wordCount; j++) {
            Console.Write($"{_words[j].GetDisplayText()}");
            Console.Write(" ");
        }
        Console.WriteLine();
    }

    public bool IsCompletelyHidden() {
        int wordCount = _words.Count();
        int hiddenTotal = 0;
        for (int l = 0; l < wordCount; l++) {
            if (_words[l].IsHidden() == true) {
                hiddenTotal = hiddenTotal + 1;
            }
        }
        if (wordCount == hiddenTotal) {
            return true;
        } else {
            return false;
        }
    }
}