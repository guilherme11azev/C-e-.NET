class Musica
{
    public string nome;
    public string artista;
    public interface duracao;
    public bool disponivel {  get; set; }


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (disponivel)
        {
            Console.WriteLine("Disponível no seu plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+.");  
        }
    }
}