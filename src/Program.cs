using AdlerOS.Core;
using AdlerOS.Decorators;
using AdlerOS.Strategies;
using Spectre.Console;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var mind = new AdlerianMind();
        var finalism = new FictionalFinalismDecoder();

        while (true)
        {
            AnsiConsole.Write(new FigletText("AdlerOS v9.0").Color(Color.DeepSkyBlue1));
            AnsiConsole.MarkupLine("[bold italic cyan]Система индивидуальной психологии Альфреда Адлера запущена успешно.[/]\n");

            // 1. Отрисовка дашборда Spectre.Console
            var table = new Table();
            table.AddColumn("[bold yellow]Психическая метрика[/]");
            table.AddColumn("[bold green]Текущий уровень[/]");
            table.AddColumn("[bold blue]Состояние рантайма[/]");

            string inferiorityStatus = mind.InferiorityIndex > 60 ? "[red]Пред-коллапс (Комплекс)[/]" : "[green]Прогрессивный стимул[/]";
            string socialStatus = mind.SocialInterest < 20 ? "[red]Невротическая изоляция[/]" : "[green]Здоровая интеграция[/]";

            table.AddRow("📉 Индекс Неполноценности (Inferiority)", $"{mind.InferiorityIndex}%", inferiorityStatus);
            table.AddRow("🤝 Социальный Интерес (Gemeinschaftsgefühl)", $"{mind.SocialInterest}%", socialStatus);
            table.AddRow("🛤️ Активный Стиль Жизни (Style of Life)", mind.StyleName, "[grey]Динамический паттерн[/]");

            AnsiConsole.Write(new Align(table, HorizontalAlignment.Center));

            // 2. Интерактивное Меню Действий
            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Выберите [underline yellow]социальную задачу[/] или вектор компенсации:")
                    .PageSize(10)
                    .AddChoices(new[] {
                        "💼 Выполнить рабочую задачу (Тест Стиля Жизни)",
                        "🚀 [[Превосходство]] Запустить Сверхкомпенсацию фиктивной цели",
                        "🎭 [[Бегство]] Симулировать слабость интерфейсов для ухода от задач",
                        "🌱 Сменить Стиль Жизни на Социально-Полезный",
                        "👑 Вернуть Господствующий Стиль Жизни",
                        "❌ Выйти из симуляции Адлера"
                    }));

            if (choice.StartsWith("❌")) break;

            try
            {
                if (choice.StartsWith("💼"))
                {
                    mind.ExecuteSocialTask("Дедлайн по рефакторингу legacy-модуля");
                }
                else if (choice.StartsWith("🚀"))
                {
                    mind.Compensate(finalism.Overcompensation);
                }
                else if (choice.StartsWith("🎭"))
                {
                    mind.Compensate(finalism.DevelopOrganInferiority);
                }
                else if (choice.StartsWith("🌱"))
                {
                    mind.SetStyleOfLife(new SociallyUsefulStyle());
                    AnsiConsole.MarkupLine("[green]Вы осознали важность общества. Стиль жизни изменен.[/]");
                }
                else if (choice.StartsWith("👑"))
                {
                    mind.SetStyleOfLife(new RulingStyle());
                    AnsiConsole.MarkupLine("[red]Эго снова жаждет власти над потоками и ресурсами.[/]");
                }
            }
            catch (Exception ex)
            {
                AnsiConsole.WriteException(ex, ExceptionFormats.ShortenEverything);
                AnsiConsole.MarkupLine("\n[bold yellow][[🛠️ ТЕРАПИЯ]]:[/] Развертывание здравого смысла... Сброс индекса неполноценности до безопасных 40%.");
                mind.Compensate((ref double inf, ref double soc) => { inf = 40; soc += 10; });
            }

            AnsiConsole.MarkupLine("\n[grey]Нажмите любую клавишу для продолжения психического цикла...[/]");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}