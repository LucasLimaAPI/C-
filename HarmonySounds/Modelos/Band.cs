using System;
using System.Collections.Generic;
using System.Linq;

namespace HarmonySounds.Modelos
{
    internal class Band
    {
        private readonly List<Album> albuns = new List<Album>();
        private readonly List<Evaluation> notes = new List<Evaluation>();

        public Band(string name)
        {
            Name = name;
        }

        public string Name { get; }
        
        public double Media
        {
            get
            {
                if (notes.Count == 0) return 0;
                else return notes.Average(e => e.Note);
            }
        }

        public List<Album> Albuns => albuns;

        public List<Evaluation> Notas => notes;

        public void AdicionarNota(Evaluation avaliacao)
        {
            notes.Add(avaliacao);
        }

        public void AddAlbum(Album album)
        {
            albuns.Add(album);
        }

        public void ShowDiscografy()
        {
            Console.WriteLine($"Discografia da banda {Name}");
            foreach (Album album in albuns)
            {
                Console.WriteLine($"Álbum: {album.Name} ({album.TotalDuration})");
            }
        }
    }
}
