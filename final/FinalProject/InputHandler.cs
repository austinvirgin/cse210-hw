using System;
using System.Threading;

public class InputHandler
{
    private bool _spacebarPressed;
    private Thread _inputThread;

    private Bird _bird;
    private volatile bool _running;

    SoundManager soundManager = new SoundManager();

    public InputHandler(Bird bird)
    {
        // Constructor for InputHandler
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
        // Method to monitor user input
        while (_running)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Spacebar)
                {
                    _spacebarPressed = true;
                    _bird.Flap();
                    SoundManager.MainSound();
                    Thread.Sleep(100);
                }
            }
            Thread.Sleep(10); // Adjust sleep time if needed
        }
    }

    public bool IsSpacebarPressed()
    {
        // Method to check if the spacebar was pressed
        if (_spacebarPressed)
        {
            _spacebarPressed = false;
            return true;
        }
        return false;
    }

    public void Stop()
    {
        // Method to stop the input handler
        _running = false;
        _inputThread.Join();
        SoundManager.EndSound();
    }

    public bool ClickedEnter()
    {
        // Method to check if the Enter key was pressed
        Console.ReadLine();
        return true;
    }
}
