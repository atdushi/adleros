using AdlerOS.Strategies;

namespace AdlerOS.Core;

public class AdlerianMind
{
    private double _inferiorityIndex = 40.0; // Стартовое чувство неполноценности
    private double _socialInterest = 30.0;   // Стартовый социальный интерес
    private IStyleOfLife _currentStyle = new RulingStyle(); // Дефолтный деструктивный стиль

    public double InferiorityIndex => _inferiorityIndex;
    public double SocialInterest => _socialInterest;
    public string StyleName => _currentStyle.Name;

    public void SetStyleOfLife(IStyleOfLife newStyle) => _currentStyle = newStyle;

    public void ExecuteSocialTask(string description)
    {
        _inferiorityIndex += 15; // Каждая жизненная задача бросает вызов и временно поднимает неполноценность

        if (_inferiorityIndex > 80)
        {
            throw new Exception("[💥 КОМПЛЕКС НЕПОЛНОЦЕННОСТИ]: Индекс неполноценности критический! Система парализована чувством собственной ничтожности и отказывается от борьбы.");
        }

        _currentStyle.HandleSocialTask(description, ref _inferiorityIndex, ref _socialInterest);
    }

    public void Compensate(CompensationDelegate compensation)
    {
        compensation(ref _inferiorityIndex, ref _socialInterest);

        // Коррекция границ
        if (_inferiorityIndex < 0) _inferiorityIndex = 0;
        if (_socialInterest < 0) _socialInterest = 0;
    }
}