void ObliczPi(int n)
{
    double suma = 0.0;
    double znak = 1.0;

    for (int i = 0; i < n; i++)
    {
        suma += znak / (2 * i + 1);
        znak = -znak;
    }

    Console.WriteLine(4 * suma);
}

ObliczPi(1000);
