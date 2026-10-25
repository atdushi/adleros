namespace AdlerOS.Core;

// Делегат позволяет компенсировать неполноценность, оперируя приватными метриками по ссылке
public delegate void CompensationDelegate(ref double inferiorityIndex, ref double socialInterest);
