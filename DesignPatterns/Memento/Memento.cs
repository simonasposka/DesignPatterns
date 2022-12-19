namespace DesignPatterns.Memento;

public class Memento
{
    private string Text;

    public Memento(string textToSave)
    {
        Text = textToSave;
    }

    public string GetSavedText()
    {
        return Text;
    }
}