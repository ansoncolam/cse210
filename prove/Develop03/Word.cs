public class Word {
    
    private string _text;
    private bool _isHidden;

    public Word(string text) {
        _text = text;
        _isHidden = false;
    }

    public void Hide() {
        int textLength = _text.Length;
        _text = new string('_', textLength);
        _isHidden = true;
    }

    // public void Show() {
    //     _isHidden = false;
    // }

    public bool IsHidden() {
        if (_isHidden == true) {
            return true;
        } else {
            return false;
        }
    }

    public string GetDisplayText() {
        return _text;
    }
}