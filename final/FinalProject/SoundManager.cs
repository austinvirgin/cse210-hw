using System;
using System.Media;
using System.Security.Cryptography.X509Certificates;

class SoundManager
{
    public static void MainSound()
    {
       using(SoundPlayer player = new("MusicStart.wav")){

        player.PlaySync();
       }
        
        
    }
}
