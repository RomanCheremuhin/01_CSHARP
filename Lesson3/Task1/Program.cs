double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denomenator = c + d;
    double resalt = numenator / denomenator;
    return resalt;
}

double resalt = CalculateFormula(1, 2, 3, 4);
System.Console.WriteLine(resalt);