namespace Lab6;
public static class Program
{
    public static void Main()
    {
        List<UiWindow> windows = new List<UiWindow>
        {
            new MainWindow("Головне меню", 1000, 800),
            new DialogWindow("Помилка підключення", 200, 100),
            new ModalWindow("Налаштування", 1500, 1000)
        };

        foreach (var window in windows)
        {
            window.Draw();
            if (window is IResizable resizableWindow)
            {
                resizableWindow.Resize();
            }
            else
            {
                Console.WriteLine("Розмір вікна не може бути змінений користувачем");
            }
        }
    }
}

public interface IResizable
{
    void Resize();
}

public abstract class UiWindow
{
    protected string? Title;
    protected int Width;
    protected int Height;

    public UiWindow(string title, int width, int height)
    {
        Title = title;
        Width = width;
        Height = height;
    }
    public abstract void Draw();
}

public class MainWindow : UiWindow, IResizable
{
    public MainWindow(string title, int width, int height) : base(title, width, height) { }

    public override void Draw()
    {
        Console.WriteLine($"MainWindow \"{Title}\" {Width}x{Height}, було відмальовано успішно");
    }

    public void Resize()
    {
        Console.WriteLine("Розмір вікна може бути змінений користувачем");
    }
}

public class ModalWindow : UiWindow, IResizable
{
    public ModalWindow(string title, int width, int height) : base(title, width, height) { }

    public override void Draw()
    {
        Console.WriteLine($"ModalWindow \"{Title}\" {Width}x{Height}, було відмальовано успішно");
    }
    public void Resize()
    {
        Console.WriteLine("Розмір вікна може бути змінений користувачем");
    }
}
public class DialogWindow : UiWindow
{
    public DialogWindow(string title, int width, int height) : base(title, width, height) { }

    public override void Draw()
    {
        Console.WriteLine($"DialogWindow \"{Title}\" {Width}x{Height}, було відмальовано успішно");
    }
}