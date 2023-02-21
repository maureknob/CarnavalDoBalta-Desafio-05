string[] units = { "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez",
    "onze", "doze", "treze", "quatorze", "quinze", "dezeseis", "dezesete", "dezoito", "dezenove" };
string[] dozens = new string[] { String.Empty, "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
string[] hundreds = new string[] { String.Empty, "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };
string[] thousands = new string[] { String.Empty, "mil", "dois mil", "três mil", "quatro mil", "cinco mil", "seis mil", "sete mil", "oito mil", "nove mil" };

// Console.Clear();
// Console.Write("Digite um valor: ");

// double.TryParse(Console.ReadLine(), out double value);

double value = 19.35;

void PrintValue(string value)
{
    var word = "reais";
    if (value == "um")
    {
        word = "real";
    }
    if (value == "cento")
    {
        value = "cem";
    }

    Console.WriteLine($"\n{value} {word}");
}

if (value < 100 && value >= 20)
{
    var rounded = (int)Math.Floor(value);
    var dozen = rounded / 10;
    var unit = rounded % 10;

    if (unit == 0)
    {
        PrintValue(dozens[dozen]);
    }
    else
    {
        PrintValue($"{dozens[dozen]} e {units[unit]}");
    }
}

if (value < 1000 && value >= 100)
{
    var rounded = (int)Math.Floor(value);
    var hundred = rounded / 100;
    var dozen = (rounded % 100) / 10;
    var unit = (rounded % 100) % 10;

    if (dozen == 0 && unit == 0)
    {
        PrintValue($"{hundreds[hundred]}");
    }
    else
    {
        if (unit == 0)
        {
            PrintValue($"{hundreds[hundred]} e {dozens[dozen]}");
        }
        else
        {
            PrintValue($"{hundreds[hundred]} e {dozens[dozen]} e {units[unit]}");
        }

    }
}

if (value < 20)
{
    PrintValue($"{units[(int)value]}");
}




