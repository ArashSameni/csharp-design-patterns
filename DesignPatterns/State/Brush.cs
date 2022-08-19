namespace DesignPatterns.State;

public class Brush : ITool
{
    // Handle
    public void MouseDown()
    {
        Console.WriteLine("Drawing something on canvas...");
    }
}