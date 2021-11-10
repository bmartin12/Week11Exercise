using System;
using static System.Console;
using System.Media;

namespace AudioDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer spookyPlayer = new SoundPlayer("Fun_House.wav");
            spookyPlayer.Load();
            //spookyPlayer.Play();
            spookyPlayer.PlayLooping();
            ForegroundColor = ConsoleColor.White;
            WriteLine(@"
                                              ,           ^'^  _
                                              )               (_) ^'^
         _/\_                    .---------. ((        ^'^
         (('>                    )`'`'`'`'`( ||                 ^'^
    _    /^|                    /`'`'`'`'`'`\||           ^'^
    =>--/__|m---               /`'`'`'`'`'`'`\|
         ^^           ,,,,,,, /`'`'`'`'`'`'`'`\      ,
                     .-------.`|`````````````|`  .   )
                    / .^. .^. \|  ,^^, ,^^,  |  / \ ((
                   /  |_| |_|  \  |__| |__|  | /,-,\||
        _         /_____________\ |')| |  |  |/ |_| \|
       (')         |  __   __  |  '==' '=='  /_______\     _
      (' ')        | /  \ /  \ |   _______   |,^, ,^,|    (')
       \  \        | |--| |--| |  ((--.--))  ||_| |_||   (' ')
     _  ^^^ _      | |__| |('| |  ||  |  ||  |,-, ,-,|   /  /
   ,' ',  ,' ',    |           |  ||  |  ||  ||_| |_||   ^^^
.,,|RIP|,.|RIP|,.,,'==========='==''=='==''=='=======',,....,,,,.,ldb
== Credits ==
Music: 'Fun House' by Coyote Hearing from youtube.com/audiolibrary
Art: Haunted house by ldb from https://www.asciiart.eu/holiday-and-events/halloween
");
            ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n(Press any key to exit)");
            Console.ReadKey();
        }
    }
}
