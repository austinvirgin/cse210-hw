using System;
using System.Threading;
{
    
}
public class InputHandler
{
    // private bool _spacebarPressed;
    // private Thread _inputThread;
    // private volatile bool _running;

    // public InputHandler(){
    //     _spacebarPressed = false;
    //     _running = true;
    //     _inputThread = new Thread(MonitorInput);
    //     _inputThread.Start();
    // }

    // private void MonitorInput(){
    //     while (_running)
    //     {
    //         if (Console.KeyAvailable)
    //         {
    //             var key = Console.ReadKey(true);
    //             if (key.Key == ConsoleKey.Spacebar){
    //                 _spacebarPressed = true;
    //             }
    //         }
    //         Thread.Sleep(10);
    //     }
    // }

    // public bool IsSpacebarPressed(){
    //     if (_spacebarPressed){
    //         _spacebarPressed = false;
    //         return true;
    //     }
    //     return false;
    // }

    // public void Stop(){
    //     _running = false;
    //     _inputThread.Join();
    // }

    public bool ClickedEnter(){
        Console.ReadLine();
        return true;
    }

    public async Task<bool> SpaceBarPress(){
        if (Console.KeyAvailable){
        ConsoleKeyInfo keyInfo = await Task.Run(() => Console.ReadKey(true));
        return keyInfo.Key == ConsoleKey.Spacebar;}
        return false;
    }

}