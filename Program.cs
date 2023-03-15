

//MOHAMMAD HOSSEIN KARIMI

int y;

int num;

string x;

ConsoleKeyInfo digree ;

do
{
    Console.WriteLine("\n ENTER THE SCORE");
    num = 0;
    do
    {
        keyboardnumberlocker();

        calculatenextdigit();

    } while (digree.Key.ToString() != "Enter");

        Console.WriteLine();

    y = num * 5;

        scorecalculater();

    Console.WriteLine("\n DO YOU WANT TO CALCULAT AGAIN ? ( PRESS Y OR N)");

        keyboardYESORNOlocker();

} while (x.ToLower() == "y");

Console.WriteLine(" \n GOOD LUCK");


//---------------------------------------------------------
//----------------------------METHODS----------------------
//---------------------------------------------------------
void keyboardnumberlocker()
{
    do
    {

        digree = Console.ReadKey(true);

    } while (digree.KeyChar.ToString() != "0" && digree.KeyChar.ToString() != "1" && digree.KeyChar.ToString() != "2" &&
            digree.KeyChar.ToString() != "3" && digree.KeyChar.ToString() != "4" && digree.KeyChar.ToString() != "5" &&
            digree.KeyChar.ToString() != "6" && digree.KeyChar.ToString() != "7" && digree.KeyChar.ToString() != "8" &&
            digree.KeyChar.ToString() != "9" && digree.Key.ToString() != "Enter");
}

void calculatenextdigit()
{
    if (digree.Key.ToString() != "Enter")
    {
        num = num * 10 + Convert.ToInt32(digree.KeyChar.ToString());

        Console.Write(digree.KeyChar);

    }
}

void scorecalculater()
{

    if (num < 0 || num > 20)
    {
        throw new Exception("INVALID NUMBER");
    }
    else if (num > 17 && num <= 20)
    {
        Console.WriteLine("CONGRATULATIONS, YOR KILL IT");
        Console.WriteLine("\n YOUR SCORE IS {0} ,  YORE RANK IS -A- AND YOUR SCORE BY PERCENTAGE IS {1}%", num, y);

    }
    else if (num > 15 && num <= 17)
    {
        Console.WriteLine("WELL DONE, YOU PASS THIS");
        Console.WriteLine("\n YOUR SCORE IS {0} ,  YORE RANK IS -B- AND YOUR SCORE BY PERCENTAGE IS {1}%", num, y);
    }
    else if (num > 10 && num <= 15)
    {
        Console.WriteLine("ACCEPTABLE, YOU PASS THIS");
        Console.WriteLine("\n YOUR SCORE IS {0} ,  YORE RANK IS -C- AND YOUR SCORE BY PERCENTAGE IS {1}%", num, y);
    }
    else if (num > 0 && num <= 10)
    {
        Console.WriteLine("UNFORTUNATLY YOU FAILED, TRY HARDER NEXT TIME");
        Console.WriteLine("\n YOUR SCORE IS {0} ,  YORE -FAILED- AND YOUR SCORE BY PERCENTAGE IS {1}%", num, y);
    }
}

void keyboardYESORNOlocker()
    {
    do
    {
        x = Console.ReadKey(true).KeyChar.ToString();

    } while (x.ToLower() != "y" & x.ToLower() != "n");
}
