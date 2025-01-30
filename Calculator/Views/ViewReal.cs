using System;
namespace Calculator
{
    public interface IViewReal
    {
        // Real numbers
        string RealNumberA { get; set; }
        string RealNumberB { get; set; }
        string RealResult { get; set; }

        // EventsReal
        event EventHandler CalculateRealSum;
        event EventHandler CalculateRealSubtract;
        event EventHandler CalculateRealMultiply;
        event EventHandler CalculateRealDivide;

        void ShowError(string message);
    }
}