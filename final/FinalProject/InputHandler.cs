using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;
class InputHandler
{
    public bool ClickedEnter(){
        Console.ReadLine();
        return true;
    }
    // public async Task<bool> SpaceBarPress(){
    //     ConsoleKeyInfo keyInfo = await Task.Run(() => Console.ReadKey(true));
    //     return keyInfo.Key == ConsoleKey.Spacebar;
    // }
}