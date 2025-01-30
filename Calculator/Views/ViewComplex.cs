using System;
namespace Calculator
{
    public interface IViewComplex
    {
        // Complex numbers
        string ComplexRealA { get; set; }
        string ComplexImgA { get; set; }
        string ComplexRealB { get; set; }
        string ComplexImgB { get; set; }
        string ComplexRealResult { get; set; }
        string ComplexImgResult { get; set; }

        // Events Complex
        event EventHandler CalculateComplexSum;
        event EventHandler CalculateComplexSubtract;
        event EventHandler CalculateComplexMultiply;
        event EventHandler CalculateComplexDivide;

        void ShowError(string message);
    }
}