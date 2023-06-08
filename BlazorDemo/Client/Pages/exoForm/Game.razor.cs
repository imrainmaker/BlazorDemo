using BlazorDemo.Shared;

namespace BlazorDemo.Client.Pages.exoForm
{
    public partial class Game
    {
        private List<Jeu> Jeux { get; set; } = new List<Jeu>();
        private Jeu? JeuSelectionne { get; set; } = null;


        private void RecevoirReponse(Jeu jeu)
        {
            jeu.Id = Jeux.Count + 1;
            Jeux.Add(new Jeu { Id = jeu.Id, Nom = jeu.Nom, Genre = jeu.Genre, DatedeSortie = jeu.DatedeSortie, Note = jeu.Note });
        }

        private void Selection(int id)
        {
            JeuSelectionne = Jeux[id - 1];
        }
    }
}
