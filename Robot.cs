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
    public int roboX { get; set; }
    public int roboY { get; set; }
}