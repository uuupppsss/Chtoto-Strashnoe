// класс робота
internal class Robot
{
    // организовать синглтон и хранение текущих координат
    static Robot instance;
    public static Robot GetInstance()
    {
        if (instance == null)
            instance = new Robot();
        return instance;
    }
    public int X { get; set; }
    public int Y { get; set; }
}