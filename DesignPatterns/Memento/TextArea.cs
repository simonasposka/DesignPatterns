namespace DesignPatterns.Memento;

public class TextArea
{
    public string Text { get; set; }

    public void SetText(string text)
    {
        Text = text;
    }

    public void Restore(Memento memento)
    {
        Text = memento.GetSavedText();
    }

    public Memento TakeSnapshot()
    {
        return new Memento(Text);
    }
}