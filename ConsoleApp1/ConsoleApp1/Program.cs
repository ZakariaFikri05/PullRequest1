// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
class Studente
{
    public Studente(int matricola, string cognome, string nome)
    {
        Matricola = matricola;
        Cognome = cognome;
        Nome = nome;
    }

    public Studente()
    {
    }
    public int Matricola { get; set; }
    public string Cognome { get; set; }
    public string Nome { get; set; }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, world");
        Studente s = new Studente();
    }
}
    public int Matricola { get; set; }
    public string Cognome { get; set; }
    public string Nome { get; set; }
}
