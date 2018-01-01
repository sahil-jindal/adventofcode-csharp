
using System;

namespace AdventOfCode.Y2016 {

    class SplashScreenImpl : AdventOfCode.SplashScreen {

        public void Show() {

            var color = Console.ForegroundColor;
            Write(ConsoleColor.Yellow, "\n  __   ____  _  _  ____  __ _  ____     __  ____     ___  __  ____  ____         \n / _\\ (    \\/ )( ");
            Write(ConsoleColor.Yellow, "\\(  __)(  ( \\(_  _)   /  \\(  __)   / __)/  \\(    \\(  __)        \n/    \\ ) D (\\ \\/ / ) _) /    /  )( ");
            Write(ConsoleColor.Yellow, "   (  O )) _)   ( (__(  O )) D ( ) _)         \n\\_/\\_/(____/ \\__/ (____)\\_)__) (__)    \\__/(__)     \\");
            Write(ConsoleColor.Yellow, "___)\\__/(____/(____)  2016\n\n           (       (    (  ( ((*)) )  )    )       )               \n    ");
            Write(ConsoleColor.Yellow, "       ");
            Write(ConsoleColor.DarkGray, "                    |                                   \n                             +-|---+       ");
            Write(ConsoleColor.DarkGray, "                        \n                            /  |  /|                               \n       ");
            Write(ConsoleColor.DarkGray, "                    +-----+ |                               \n                           |::");
            Write(ConsoleColor.Yellow, ":");
            Write(ConsoleColor.DarkGray, "::| |                          25 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, "        +----+  |::");
            Write(ConsoleColor.Green, ":");
            Write(ConsoleColor.DarkGray, "::| |---+      +-----------+   24 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, "       /    / \\ |:");
            Write(ConsoleColor.Green, ":::");
            Write(ConsoleColor.DarkGray, ":| |  /|     / \\\\\\\\\\\\ [] /|   23 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, "      /    / / \\|");
            Write(ConsoleColor.Green, ":::::");
            Write(ConsoleColor.DarkGray, "| | / |    / \\\\\\\\\\\\ [] / |   22 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, "     /    / / / \\::");
            Write(ConsoleColor.DarkGreen, ":");
            Write(ConsoleColor.DarkGray, "::|/ /  |   +-----------+  |   21 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, "    +----+ / / / \\------+ ------|::::");
            Write(ConsoleColor.Blue, ":");
            Write(ConsoleColor.DarkGray, ":");
            Write(ConsoleColor.Blue, ":");
            Write(ConsoleColor.DarkGray, "::::|  |   20 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, "    |-----\\ / / / \\=====| ------|:");
            Write(ConsoleColor.Blue, ":");
            Write(ConsoleColor.DarkGray, ":::");
            Write(ConsoleColor.Blue, ":");
            Write(ConsoleColor.DarkGray, ":::");
            Write(ConsoleColor.Blue, ":");
            Write(ConsoleColor.DarkGray, ":|  |   19 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, "    |------\\ / / / \\====|   |   |");
            Write(ConsoleColor.Blue, ":::");
            Write(ConsoleColor.DarkGray, ":");
            Write(ConsoleColor.Blue, ":::");
            Write(ConsoleColor.DarkGray, ":");
            Write(ConsoleColor.Blue, ":::");
            Write(ConsoleColor.DarkGray, "|  |   18 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, "    |-------\\ / / / +===|   |   |:::");
            Write(ConsoleColor.Blue, ":");
            Write(ConsoleColor.DarkGray, ":::");
            Write(ConsoleColor.Blue, ":");
            Write(ConsoleColor.DarkGray, ":::|  |   17 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, "    |--------\\ / / /|===|   |   |:::");
            Write(ConsoleColor.Blue, ":");
            Write(ConsoleColor.DarkGray, ":::");
            Write(ConsoleColor.Blue, ":");
            Write(ConsoleColor.DarkGray, ":::|  |   16 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, "    |---------\\ / / |===|   |  /|");
            Write(ConsoleColor.Blue, ":::");
            Write(ConsoleColor.DarkGray, ":");
            Write(ConsoleColor.Blue, ":::");
            Write(ConsoleColor.DarkGray, ":");
            Write(ConsoleColor.Blue, ":::");
            Write(ConsoleColor.DarkGray, "|  |   15 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, "    |----------\\ /  |===|  /  //|:");
            Write(ConsoleColor.Blue, ":");
            Write(ConsoleColor.DarkGray, ":::");
            Write(ConsoleColor.Blue, ":");
            Write(ConsoleColor.DarkGray, ":::");
            Write(ConsoleColor.Blue, ":");
            Write(ConsoleColor.DarkGray, ":| /    14 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, "    +-----------+   |===| /  //||::::");
            Write(ConsoleColor.Blue, ":");
            Write(ConsoleColor.DarkGray, ":");
            Write(ConsoleColor.Blue, ":");
            Write(ConsoleColor.DarkGray, "::::|/     13 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, "    |");
            Write(ConsoleColor.Red, ":");
            Write(ConsoleColor.DarkGray, ":");
            Write(ConsoleColor.Red, ":");
            Write(ConsoleColor.DarkGray, "::::::::|   |===|/__//___________________  12 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, "    |");
            Write(ConsoleColor.Red, ":::");
            Write(ConsoleColor.DarkGray, ":");
            Write(ConsoleColor.Green, ":::");
            Write(ConsoleColor.DarkGray, "::::|   |______//|_____...._________   11 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, "    |");
            Write(ConsoleColor.Red, ":");
            Write(ConsoleColor.DarkGray, ":");
            Write(ConsoleColor.Red, ":");
            Write(ConsoleColor.DarkGray, ":");
            Write(ConsoleColor.Green, ":");
            Write(ConsoleColor.DarkGray, ":");
            Write(ConsoleColor.Green, ":");
            Write(ConsoleColor.DarkGray, "::::|   |     //| ____/ /_/___         10 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, " ---|::::");
            Write(ConsoleColor.Green, ":::");
            Write(ConsoleColor.DarkGray, "::::|   |--------|[][]|_|[][]_\\------   9 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, "----|::");
            Write(ConsoleColor.Red, ":");
            Write(ConsoleColor.DarkGray, ":");
            Write(ConsoleColor.Red, ":");
            Write(ConsoleColor.DarkGray, "::::::|   |---------------------------    8 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, " || |::");
            Write(ConsoleColor.Red, ":::");
            Write(ConsoleColor.DarkGray, ":");
            Write(ConsoleColor.Green, ":::");
            Write(ConsoleColor.DarkGray, "::|   |  //| ||  / / / ||      ||     7 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, " || |::");
            Write(ConsoleColor.Red, ":");
            Write(ConsoleColor.DarkGray, ":");
            Write(ConsoleColor.Red, ":");
            Write(ConsoleColor.DarkGray, ":");
            Write(ConsoleColor.Green, ":");
            Write(ConsoleColor.DarkGray, ":");
            Write(ConsoleColor.Green, ":");
            Write(ConsoleColor.DarkGray, "::|   | //|  || /   /  ||  ");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "   ||     6 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, "    |::::::");
            Write(ConsoleColor.Green, ":::");
            Write(ConsoleColor.DarkGray, "::|   |//|     / / /      ");
            Write(ConsoleColor.DarkGreen, ">");
            Write(ConsoleColor.Green, "o");
            Write(ConsoleColor.DarkGreen, "<        ");
            Write(ConsoleColor.DarkGray, " 5 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, "    |::::");
            Write(ConsoleColor.Red, ":");
            Write(ConsoleColor.DarkGray, ":");
            Write(ConsoleColor.Red, ":");
            Write(ConsoleColor.DarkGray, "::::|   //|     /   /   ___");
            Write(ConsoleColor.DarkGreen, ">");
            Write(ConsoleColor.Blue, "@");
            Write(ConsoleColor.DarkGreen, ">");
            Write(ConsoleColor.Red, "O");
            Write(ConsoleColor.DarkGreen, "<");
            Write(ConsoleColor.DarkGray, "____    4 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, "    |::::");
            Write(ConsoleColor.Red, ":::");
            Write(ConsoleColor.DarkGray, ":");
            Write(ConsoleColor.Green, ":::");
            Write(ConsoleColor.DarkGray, "|  //|     / / /   /  ");
            Write(ConsoleColor.DarkGreen, ">");
            Write(ConsoleColor.Red, "O");
            Write(ConsoleColor.DarkGreen, ">");
            Write(ConsoleColor.Green, "o");
            Write(ConsoleColor.DarkGreen, "<");
            Write(ConsoleColor.Blue, "@");
            Write(ConsoleColor.DarkGreen, "<");
            Write(ConsoleColor.DarkGray, "  /    3 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, "    |::::");
            Write(ConsoleColor.Red, ":");
            Write(ConsoleColor.DarkGray, ":");
            Write(ConsoleColor.Red, ":");
            Write(ConsoleColor.DarkGray, ":");
            Write(ConsoleColor.Green, ":");
            Write(ConsoleColor.DarkGray, ":");
            Write(ConsoleColor.Green, ":");
            Write(ConsoleColor.DarkGray, "| //|     /   /   /    ");
            Write(ConsoleColor.Gray, "_| |_");
            Write(ConsoleColor.DarkGray, "  /     2 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.DarkGray, "    |::::::::");
            Write(ConsoleColor.Green, ":::");
            Write(ConsoleColor.DarkGray, "|//|     / / /   /___________/      1 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "  ==============//======+...+====================       \n             - - - - - - -// - - -/   / - -");
            Write(ConsoleColor.Gray, " - - - - - - - -        \n           ==============//|==============================         \n       ");
            Write(ConsoleColor.Gray, "                 //|                                        \n           \n");
            
            Console.ForegroundColor = color;
            Console.WriteLine();
        }

       private static void Write(ConsoleColor color, string text){
           Console.ForegroundColor = color;
           Console.Write(text);
       }
    }
}