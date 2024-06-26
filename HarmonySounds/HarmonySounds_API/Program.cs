﻿//Using vai utilizar apenas a parte em chaves do nosso código. CTRL + K + C
using System.Text.Json;
using HarmonySounds_API;
using HarmonySounds_API.Filtros;
using HarmonySounds_API.Modelos;

using (HttpClient client = new()) //Aqui vamos dar um request nos dados fornecidos com esta URL e Retornalos no nosso terminal.
{
    //Detectar o erro e retornar ele para nós com o try e exception de catch
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");// puxando a API 
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;  //var criar variavel sem definir um tipo\JsonSerializer = Vamos informar que desejamos criar uma lista dessa resposta em JSON.
        //É comunicado que a lista de músicas pode ser nula. Para garantir que não seja nula, adicionamos um sinal de exclamação após a resposta da lista de músicas. Dessa forma, ao realizar o parsing, precisamos de uma classe que não seja nula para receber os dados.
        // musicas[1998].ExibirDetalhesDaMusica();

        LinqFilter.FiltrarMusicasEmCsharp(musicas);
        musicas[0].ExibirDetalhesDaMusica();

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenadas(musicas);
        //LinqFilter.FiltrarArtistaPorGeneroMusical(musicas,"rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        
        // var musicasPreferidasDoLucas = new MusicasPreferidas("Lucas");
        // musicasPreferidasDoLucas.AdicionarMusicasFavoritas(musicas[1]);
        // musicasPreferidasDoLucas.AdicionarMusicasFavoritas(musicas[355]);
        // musicasPreferidasDoLucas.AdicionarMusicasFavoritas(musicas[231]);
        // musicasPreferidasDoLucas.AdicionarMusicasFavoritas(musicas[1444]);
        // musicasPreferidasDoLucas.AdicionarMusicasFavoritas(musicas[22]);

        // musicasPreferidasDoLucas.ExibirMusicasFavoritas();

        // var musicasPreferidasDoFelipe = new MusicasPreferidas("Felipe");
        // musicasPreferidasDoFelipe.AdicionarMusicasFavoritas(musicas[3]);
        // musicasPreferidasDoFelipe.AdicionarMusicasFavoritas(musicas[100]);
        // musicasPreferidasDoFelipe.AdicionarMusicasFavoritas(musicas[203]);
        // musicasPreferidasDoFelipe.AdicionarMusicasFavoritas(musicas[306]);
        // musicasPreferidasDoFelipe.AdicionarMusicasFavoritas(musicas[1123]);

        // musicasPreferidasDoFelipe.ExibirMusicasFavoritas();

        // musicasPreferidasDoFelipe.GerarArquivoJson();


    }
    catch (Exception ex)
    {
        System.Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}