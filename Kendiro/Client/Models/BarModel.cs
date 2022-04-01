using Microsoft.AspNetCore.Components;

namespace Kendiro.Client.Models
{
    public class BarModel
    {
        public string Title { get; set; } = "DEFAULT TITLE";
        public string Icon { get; set; } = "fa-solid fa-ban-bug";
        public double Multiplier { get; set; } = 1;
        public int Score { get; set; } = 10;
        public int MaxValue { get; set; } = 1000;
        public int Money { get; set; } = 0;
        public int Wage { get; set; } = 12;
        public int Cost { get; set; } = 10;
    }
}
