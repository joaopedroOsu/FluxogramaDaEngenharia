Console.WriteLine("--- Fluxograma da Engenharia ---");

Console.Write("O objeto está se movendo (S/N)? ");
bool estamovendo = Console.ReadLine().Trim().Substring(0, 1).ToUpper() == "S";

Console.Write("Deveria? ");
bool deveria = Console.ReadLine().Trim().Substring(0, 1).ToUpper() == "S";
string Mensagem;
if (!estamovendo)
{
if (!deveria)
{
Mensagem = "Otimo!";
}
else 
{
Mensagem = "Use WD-40.";
}
}
else 
{
if (deveria)
{
    Mensagem = "Otimo!";
}
else
{
Mensagem = "Use Silver Tape.";
}
}

Console.WriteLine();
Console.WriteLine(Mensagem);
