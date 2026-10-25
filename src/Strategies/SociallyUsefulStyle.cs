using Spectre.Console;

namespace AdlerOS.Strategies;

using AdlerOS.Core;

// 2. Социально-полезный тип (Здоровый)
public class SociallyUsefulStyle : IStyleOfLife
{
    public string Name => "🤝 Социально-полезный тип (Socially Useful)";

    public void HandleSocialTask(string taskDescription, ref double inferiorityIndex, ref double socialInterest)
    {
        AnsiConsole.MarkupLine($"[bold green][[🌱 СТИЛЬ]]:[/] Решаем задачу '{taskDescription}' через сотрудничество и взаимопомощь.");
        inferiorityIndex -= 10; // Здоровая компенсация через реальные достижения
        socialInterest += 25;  // Рост общности с людьми
    }
}