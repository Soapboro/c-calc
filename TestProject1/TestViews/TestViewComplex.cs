using System;
using Calculator;

namespace TestProject1.TestViews
{
    public class TestViewComplex : IViewComplex
    {
        public string ComplexRealA { get; set; }
        public string ComplexImgA { get; set; }
        public string ComplexRealB { get; set; }
        public string ComplexImgB { get; set; }
        public string ComplexRealResult { get; set; }
        public string ComplexImgResult { get; set; }

        public event EventHandler CalculateComplexSum;
        public event EventHandler CalculateComplexSubtract;
        public event EventHandler CalculateComplexMultiply;
        public event EventHandler CalculateComplexDivide;

        public string LastErrorMessage { get; private set; }

        public void ShowError(string message)
        {
            LastErrorMessage = message;
        }

        public void TriggerCalculateSum()
        {
            CalculateComplexSum?.Invoke(this, EventArgs.Empty);
        }

        public void TriggerCalculateSubtract()
        {
            CalculateComplexSubtract?.Invoke(this, EventArgs.Empty);
        }

        public void TriggerCalculateMultiply()
        {
            CalculateComplexMultiply?.Invoke(this, EventArgs.Empty);
        }

        public void TriggerCalculateDivide()
        {
            CalculateComplexDivide?.Invoke(this, EventArgs.Empty);
        }
    }
}