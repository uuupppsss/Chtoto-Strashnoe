// класс для ввода данных
using System.Drawing;
using System.Runtime.CompilerServices;

internal class DrawRobotCommand : IRobotCommand
{
    private Robot robot;

    public void Execute()
    {
        Paint.GetInstance().Graphics.FillEllipse(Brushes.BlueViolet, robot.roboX, robot.roboY, 5, 5);
    }
}

