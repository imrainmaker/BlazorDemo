using BlazorDemo.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Client.Pages.exoForm
{
    public partial class FormulaireJeu
    {
        private Jeu? MonJeu { get; set; }

        public FormulaireJeu()
        {
            MonJeu = new Jeu();
            MonJeu.DatedeSortie = DateTime.Now;

        }

        [Parameter]
        public EventCallback<Jeu> RetourneJeu { get; set; }

        private void OnSubmit(Jeu jeu)
        {
            MonJeu = new Jeu();
            MonJeu.DatedeSortie = DateTime.Now;
            RetourneJeu.InvokeAsync(jeu);
            
        }
    }
}
