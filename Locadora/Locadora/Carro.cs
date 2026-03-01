class Carro
{
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public int Ano { get; set; }
    public int Preco { get; set; }
    public bool disponivel { get; set; }
    public string DescricaoResumida =>
        $"O véiculo {Modelo} pertence à marca {Marca}, é do ano {Ano} e custa R${Preco} por dia.";
    
    public void ExibirFicha()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Preco: {Preco}");
        if (disponivel)
        {
            Console.WriteLine("Veículo disponível para locação.");
        }
        else
        {
            Console.WriteLine("Veículo indisponível para locação.");
        }
    }

}