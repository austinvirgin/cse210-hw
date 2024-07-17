using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

public class InputHandler
{
    private bool _spacebarPressed;
    private Thread _inputThread;

    private Bird _bird;
    private volatile bool _running;

    public InputHandler(Bird bird)
    {
        _bird = bird;
        _spacebarPressed = false;
        _running = true;
        _inputThread = new Thread(MonitorInput)
        {
            IsBackground = true
        };
        _inputThread.Start();
    }

    private void MonitorInput()
    {
        while (_running)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Spacebar)
                {
                    _spacebarPressed = true;
                    Console.WriteLine("Spacebar pressed!");
                    _bird.Flap();
                    Thread.Sleep(100);
                }
            }
            Thread.Sleep(10); // Adjust sleep time if needed
        }
    }

    public bool IsSpacebarPressed()
    {
        if (_spacebarPressed)
        {
            _spacebarPressed = false;
            return true;
        }
        return false;
    }

    public void Stop()
    {
        _running = false;
        _inputThread.Join();
    }

    public bool ClickedEnter()
    {
        Console.ReadLine();
        return true;
    }
}