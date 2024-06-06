//Using vai utilizar apenas a parte em chaves do nosso código.
using System.Text.Json;
using HarmonySounds_API.Modelos;

using (HttpClient client = new()) //Aqui vamos dar um request nos dados fornecidos com esta URL e Retornalos no nosso terminal.
{
    //Detectar o erro e retornar ele para nós com o try e exception de catch
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        System.Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;  //var criar variavel sem definir um tipo\JsonSerializer = Vamos informar que desejamos criar uma lista dessa resposta em JSON.
        //É comunicado que a lista de músicas pode ser nula. Para garantir que não seja nula, adicionamos um sinal de exclamação após a resposta da lista de músicas. Dessa forma, ao realizar o parsing, precisamos de uma classe que não seja nula para receber os dados.
        musicas[1998].ExibirDetalhesDaMusica();
    }
    catch (Exception ex)
    {
        System.Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}