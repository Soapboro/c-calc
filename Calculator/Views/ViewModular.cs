using System;
namespace Calculator
{
    public interface IViewModular
    {
        // Modular numbers
        string ModNumberA { get; set; }
        string ModNumberB { get; set; }
        string ModNumberN { get; set; }
        string ModResult { get; set; }

        //Events Modular
        event EventHandler CalculateModularSum;
        event EventHandler CalculateModularSubtract;
        event EventHandler CalculateModularMultiply;
        event EventHandler CalculateModularDivide;

        void ShowError(string message);
    }
}