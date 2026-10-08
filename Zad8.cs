void DecToHex(int liczba)
{
    if (liczba == 0)
    {
        Console.WriteLine("0");
        return;
    }

    char[] znaki = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
    string hex = "";

    while (liczba > 0)
    {
        hex = znaki[liczba % 16] + hex;
        liczba /= 16;
    }

    Console.WriteLine(hex);
}

DecToHex(255);
