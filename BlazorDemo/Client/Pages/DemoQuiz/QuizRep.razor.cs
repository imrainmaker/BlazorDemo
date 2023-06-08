using BlazorDemo.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Client.Pages.DemoQuiz
{
    public partial class QuizRep
    {
        [Parameter]
        public Quiz Questions { get; set; }
        [Parameter]
        public bool Reponses { get; set; }
        [Parameter]
        public int Score { get; set; }

    }
}
