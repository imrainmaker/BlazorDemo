using BlazorDemo.Shared;
using System.Net.Http.Json;

namespace BlazorDemo.Client.Pages.DemoQuiz
{
    public partial class QuizPage
    {
        public string? Nom { get; set; } = null;
        public List<Quiz> AllQuiz { get; set; } = new();
        public List<bool> Reponses { get; set; } = new();
        public int NumeroQuestion { get; set; }
        public int Score { get; set; }


        protected override async Task OnInitializedAsync()
        {
            NumeroQuestion = 0;
            Score = 0;
            AllQuiz = await http.GetFromJsonAsync<List<Quiz>>("data/quiz.json") ?? new();
        }

        private void RecevoirReponse(bool rep)
        {
            Reponses.Add(rep);
            NumeroQuestion++;
        }

        public void CalculScore(List<Quiz> quiz, List<bool> rep)
        {
            foreach(Quiz q in quiz)
            {
                if(q.Reponse == rep[q.id - 1])
                {
                    Score++;
                }
            }
        }
    }
}
