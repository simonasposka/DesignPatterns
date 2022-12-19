namespace DesignPatterns.Memento;

public class Editor
{
    private Stack<Memento> StateHistory;
    private TextArea TextArea;

    public Editor()
    {
        StateHistory = new Stack<Memento>();
        TextArea = new TextArea();
    }

    public void Write(string text)
    {
        TextArea.SetText(text);
        StateHistory.Push(TextArea.TakeSnapshot());
        Console.WriteLine("text = " + TextArea.Text);
    }

    public void Undo()
    {
        TextArea.Restore(StateHistory.Pop());
        Console.WriteLine("text = " + TextArea.Text);
    }
}