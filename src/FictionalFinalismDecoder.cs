using Spectre.Console;

namespace AdlerOS.Decorators;

public class FictionalFinalismDecoder
{
    public void Overcompensation(ref double inferiorityIndex, ref double socialInterest)
    {
        AnsiConsole.MarkupLine("\n[bold magenta][[ФИКТИВНЫЙ ФИНАЛИЗМ]][/]: Активирована сверхкомпенсация! Цель — 'Абсолютное Превосходство Над Всем Миром'.");

        inferiorityIndex -= 50; // Нам кажется, что мы уничтожили слабость...
        socialInterest -= 30;  // ...но мы отдалились от человечества на световые годы

        AnsiConsole.MarkupLine("[bold yellow][[СТРЕМЛЕНИЕ К ПРЕВОСХОДСТВУ]][/]: 'Я выше этих ничтожных смертных!'");
    }

    public void DevelopOrganInferiority(ref double inferiorityIndex, ref double socialInterest)
    {
        AnsiConsole.MarkupLine("\n[bold magenta][[ФИКТИВНЫЙ ФИНАЛИЗМ]][/]: Бегство в болезнь / уязвимость интерфейсов как оправдание бездействия.");

        inferiorityIndex += 30; // Чувство неполноценности взлетает
        socialInterest -= 5;   // Требуем к себе внимания, не давая ничего взамен
    }
}