Musica musica1 = new Musica();
musica1.nome = "Roxane";
musica1.artista = "The Police";
musica1.duracao = 273;
musica1.disponivel = true;
Console.WriteLine(musica1.disponivel);

Musica musica2 = new Musica();
musica2.nome = "Vertigo";
musica2.artista = "U2";
musica2.duracao = 348;
musica2.EscreveDisponivel(true);


musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();


