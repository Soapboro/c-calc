using System;
using Calculator;

namespace TestProject1.TestViews
{
    public class TestViewReal : IViewReal
    {
        public string RealNumberA { get; set; }
        public string RealNumberB { get; set; }
        public string RealResult { get; set; }

        public event EventHandler CalculateRealSum;
        public event EventHandler CalculateRealSubtract;
        public event EventHandler CalculateRealMultiply;
        public event EventHandler CalculateRealDivide;

        public string LastErrorMessage { get; private set; }

        public void ShowError(string message)
        {
            LastErrorMessage = message;
        }

        public void TriggerCalculateSum()
        {
            CalculateRealSum?.Invoke(this, EventArgs.Empty);
        }

        public void TriggerCalculateSubtract()
        {
            CalculateRealSubtract?.Invoke(this, EventArgs.Empty);
        }

        public void TriggerCalculateMultiply()
        {
            CalculateRealMultiply?.Invoke(this, EventArgs.Empty);
        }

        public void TriggerCalculateDivide()
        {
            CalculateRealDivide?.Invoke(this, EventArgs.Empty);
        }
    }
}