
using System;

namespace AdventOfCode.Y2018 {

    class SplashScreenImpl : AdventOfCode.SplashScreen {

        public void Show() {

            var color = Console.ForegroundColor;
            Write(0xffff66, "\n  __   ____  _  _  ____  __ _  ____     __  ____     ___  __  ____  ____         \n / _\\ (    \\/ )( ");
            Write(0xffff66, "\\(  __)(  ( \\(_  _)   /  \\(  __)   / __)/  \\(    \\(  __)        \n/    \\ ) D (\\ \\/ / ) _) /    /  )( ");
            Write(0xffff66, "   (  O )) _)   ( (__(  O )) D ( ) _)         \n\\_/\\_/(____/ \\__/ (____)\\_)__) (__)    \\__/(__)     \\");
            Write(0xffff66, "___)\\__/(____/(____)  2018\n\n                ");
            Write(0xcccccc, ".         .         .        .        .       25 ");
            Write(0xffff66, "**\n            ");
            Write(0xcccccc, ".        .         .        .       ");
            Write(0x886655, "\\  /      ");
            Write(0xcccccc, ".   24 ");
            Write(0xffff66, "**\n                         ");
            Write(0xcccccc, ".         .         ");
            Write(0x886655, "\\_\\_\\|_/__/      ");
            Write(0xcccccc, "23 ");
            Write(0xffff66, "**\n                  ");
            Write(0xcccccc, ".         .            .  ");
            Write(0xff0000, "o");
            Write(0x886655, "-_/");
            Write(0xcccccc, ".()");
            Write(0x886655, "__-------  ");
            Write(0xcccccc, "22 ");
            Write(0xffff66, "**\n              ");
            Write(0xcccccc, ".       .            ");
            Write(0xffff66, "*         ");
            Write(0x886655, "\\____            ");
            Write(0xcccccc, "21 ");
            Write(0xffff66, "**\n                          ");
            Write(0xcccccc, ".       ");
            Write(0xff0000, "|");
            Write(0xcccccc, "\\|            \\_");
            Write(0x886655, "\\_ ");
            Write(0xcccccc, "___  /  20 ");
            Write(0xffff66, "**\n                  ");
            Write(0xcccccc, ".               |");
            Write(0xff0000, "\\|              ");
            Write(0x886655, "/ |   ||   ");
            Write(0xcccccc, "19 ");
            Write(0xffff66, "**\n             ");
            Write(0xcccccc, ".           ");
            Write(0x66ff, "_________");
            Write(0xff0000, "|");
            Write(0xcccccc, "\\|");
            Write(0x66ff, "_________    ");
            Write(0x886655, "/  |   ||   ");
            Write(0xcccccc, "18 ");
            Write(0xffff66, "**\n                 ");
            Write(0x66ff, "___-----  ");
            Write(0xcccccc, "###########  ##### ");
            Write(0x66ff, "-----___        ");
            Write(0xcccccc, "17 ");
            Write(0xffff66, "**\n           ");
            Write(0x66ff, "___---  ");
            Write(0xcccccc, "###  #####    #########  #####     ");
            Write(0x66ff, "---___  ");
            Write(0xcccccc, "16 ");
            Write(0xffff66, "**\n                 ");
            Write(0xcccccc, ") ))          ) )                    __");
            Write(0xff0000, "__    ");
            Write(0xcccccc, "15 ");
            Write(0xffff66, "**\n              ");
            Write(0xff0000, ".-");
            Write(0xcccccc, "(");
            Write(0xff0000, "-");
            Write(0xcccccc, "((");
            Write(0xff0000, "-.     ");
            Write(0x9900, ".--");
            Write(0xcccccc, "(");
            Write(0x9900, "-");
            Write(0xcccccc, "(");
            Write(0x9900, "-.                  ");
            Write(0xff0000, "/ ");
            Write(0xcccccc, "_");
            Write(0xff0000, "\\ ");
            Write(0xcccccc, "\\   14 ");
            Write(0xffff66, "**\n              ");
            Write(0xff0000, "'------'_    ");
            Write(0x9900, "'------'_                ");
            Write(0xff0000, "|");
            Write(0xcccccc, "/|  |/");
            Write(0xff0000, "|  ");
            Write(0xcccccc, "13 ");
            Write(0xffff66, "**\n              ");
            Write(0xff0000, "|      | )   ");
            Write(0x9900, "|      | )               ");
            Write(0xcccccc, "|_|  ");
            Write(0xff0000, "|/");
            Write(0xcccccc, "|  12 ");
            Write(0xffff66, "**\n              ");
            Write(0xff0000, "|      |/    ");
            Write(0x9900, "|      |/                     ");
            Write(0xcccccc, "|/");
            Write(0xff0000, "|  ");
            Write(0xcccccc, "11 ");
            Write(0xffff66, "**\n              ");
            Write(0xff0000, "'------'     ");
            Write(0x9900, "'------'                      ");
            Write(0xff0000, "|/");
            Write(0xcccccc, "|  10 ");
            Write(0xffff66, "**\n                                              ");
            Write(0xff0000, "_     __   ");
            Write(0xcccccc, "|/");
            Write(0xff0000, "|  ");
            Write(0xcccccc, " 9 ");
            Write(0xffff66, "**\n                   ");
            Write(0xff0000, ".---_             _       ");
            Write(0x880000, "| ");
            Write(0xff0000, "|\\__");
            Write(0x880000, "/");
            Write(0xff0000, "_/)  |/");
            Write(0xcccccc, "|   8 ");
            Write(0xffff66, "**\n                  ");
            Write(0xff0000, "/ ");
            Write(0x880000, "/ ");
            Write(0xff0000, "/\\|      ");
            Write(0x999999, "__   ");
            Write(0x880000, ") ");
            Write(0xff0000, ")__   ");
            Write(0x880000, "_|");
            Write(0xff0000, "_|     /   ");
            Write(0xcccccc, "|/");
            Write(0xff0000, "|  ");
            Write(0xcccccc, " 7 ");
            Write(0xffff66, "**\n                ");
            Write(0xff0000, "/ ");
            Write(0x880000, "/ | ");
            Write(0xff0000, "\\ ");
            Write(0xffff66, "*    ");
            Write(0x999999, "/ / \\ ");
            Write(0x880000, "( ");
            Write(0xff0000, "(   \\_");
            Write(0x880000, "/");
            Write(0xff0000, "_/      /    |/");
            Write(0xcccccc, "|   6 ");
            Write(0xffff66, "**\n               ");
            Write(0xff0000, "/  ");
            Write(0x880000, "/  \\ ");
            Write(0xff0000, "\\    ");
            Write(0x999999, "| | \\/  ");
            Write(0x880000, "\\_");
            Write(0xff0000, "\\____________/     ");
            Write(0xcccccc, "|_|   5 ");
            Write(0xffff66, "**\n              ");
            Write(0xff0000, "/ ");
            Write(0x880000, "/  / \\  ");
            Write(0xff0000, "\\    ");
            Write(0x999999, "\\_\\______X_____X_____X_,         ");
            Write(0xcccccc, " 4 ");
            Write(0xffff66, "**\n            ");
            Write(0xcccccc, "./~~~~~~~~~~~\\.                                    3 ");
            Write(0xffff66, "**\n           ");
            Write(0xcccccc, "( .\",^. -\". '.~ )                                   2 ");
            Write(0xffff66, "**\n           ");
            Write(0xcccccc, "_'~~~~~~~~~~~~~'_________ ___ __ _  _   _    _      1 ");
            Write(0xffff66, "**\n           \n");
            
            Console.ForegroundColor = color;
            Console.WriteLine();
        }

       private static void Write(int rgb, string text){
           Console.Write($"\u001b[38;2;{(rgb>>16)&255};{(rgb>>8)&255};{rgb&255}m{text}");
       }
    }
}