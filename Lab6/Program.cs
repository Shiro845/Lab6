namespace Lab6;
public static class Program
{
    public static void Main()
    {
        List<UiWindow> windows = new List<UiWindow>
        {
            new MainWindow("Головне меню"),
            new DialogWindow("Помилка підключення"),
            new ModalWindow("Налаштування")
        };

        foreach (var window in windows)
        {
            window.Draw();
        }
    }
}


public abstract class UiWindow
{
    protected string Title;

    public UiWindow(string title)
    {
        Title = title;
    }
    public abstract void Draw();
}

public class MainWindow : UiWindow
{
    public MainWindow(string title) : base(title) { }

    public override void Draw()
    {
        Console.WriteLine($"MainWindow \"{Title}\" було відмальовано успішно");
    }
}

public class ModalWindow : UiWindow
{
    public ModalWindow(string title) : base(title) { }

    public override void Draw()
    {
        Console.WriteLine($"ModalWindow \"{Title}\" було відмальовано успішно");
    }
}
public class DialogWindow : UiWindow
{
    public DialogWindow(string title) : base(title) { }

    public override void Draw()
    {
        Console.WriteLine($"DialogWindow \"{Title}\" було відмальовано успішно");
    }
}