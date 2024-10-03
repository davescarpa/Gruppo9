namespace ProgettoGruppo9;
public class Studente
{
    public int Matricola { get; set; }
    public string? Nome { get; set; }
    public string? Cognome { get; set; }

    public Studente(string? cognome, string? nome, int matricola)
    {
        Cognome = cognome;
        Nome = nome;
        Matricola = matricola;
    }

    public override string ToString()
    {
        return $"matricola numero = {Matricola}, {Cognome} {Nome}  ";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Studente s = new Studente ("scarpa", "davide", 2082);
        System.Console.WriteLine(s);
        Console.ReadKey();
    }
}
