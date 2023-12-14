// класс поля
internal class Field
{
    // тут организовать синглтон и хранение ячеек в свойстве Cells
    static Field instance;
    public static Field GetInstance()
    {
        if (instance == null)
            instance = new Field();
        return instance;
    }
    public int[,] Cells { get; set; }

    internal bool CheckRobotEndGame(Robot robot)
    { 
        // сравнение координат робота с координатами
        // финишной точки
    }
}

