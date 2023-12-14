// класс для ввода данных
internal class Controller
{
    private MainCommander mainCommander;
    private Field field;
    public Controller (MainCommander mainCommander)
    {
        this.mainCommander = mainCommander;
        mainCommander.SetInterpretator(new FieldCommander());
    }

    // цикл по запросу команды
    internal void StartListner()
    {
        Console.WriteLine("input 25 field symbols (1 - free cell, 2 - wall, 3 - robot start, 4 - target point)");
        string fieldString = Console.ReadLine();
        int[] fieldArray = new int[fieldString.Length];
        for (int i = 0; i < fieldString.Length; i++)
        {
            fieldArray[i] = int.Parse(fieldString[i].ToString());
        }
        // первый запрос на 25 символов (рисование поля) передается mainCommander в метод Execute
        mainCommander.Execute(fieldArray);
        // смена интерпретатора у mainCommander на RobotCommander
        mainCommander.SetInterpretator(new RobotCommander());
        // остальные запросы передаются туда же (цикл, пока робот не достигнет конечной точки)
        while (!field.CheckRobotEndGame())
        {
            Console.WriteLine("input command (1-up; 2-down; 3-left; 4-right)");
            string command=Console.ReadLine();
        }
    }
}
