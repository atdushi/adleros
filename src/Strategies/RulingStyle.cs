using Spectre.Console;

namespace AdlerOS.Strategies;

using AdlerOS.Core;

// 1. Управляющий/Господствующий тип (Деструктивный)
public class RulingStyle : IStyleOfLife
{
    public string Name => "👑 Управляющий тип (Ruling Type)";

    public void HandleSocialTask(string taskDescription, ref double inferiorityIndex, ref double socialInterest)
    {
        AnsiConsole.MarkupLine($"[bold red][[🔥 СТИЛЬ]]:[/] Решаем задачу '{taskDescription}' через доминирование и подавление окружающих.");
        inferiorityIndex -= 15; // Временное ложное чувство превосходства
        socialInterest -= 20;  // Социальные связи разрушаются
    }
}