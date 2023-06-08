using BlazorDemo.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Client.Pages.exoForm
{
    public partial class GameDetails
    {
        [Parameter]
        public Jeu MonJeu { get; set; }
    }
}
