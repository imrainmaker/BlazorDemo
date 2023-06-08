using BlazorDemo.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Client.Pages.DemoQuiz
{
    public partial class QuizBox
    {
        [EditorRequired]
        [Parameter]
        public Quiz Questions { get; set; }

        [Parameter]
        public EventCallback<bool> Reponse { get; set; }

        public void ResponseToParent(bool rep)
        {
            Reponse.InvokeAsync(rep);
        }
    }
}
