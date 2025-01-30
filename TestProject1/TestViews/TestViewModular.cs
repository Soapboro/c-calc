using System;
using Calculator;

namespace TestProject1.TestViews
{
    public class TestViewModular : IViewModular
    {
        public string ModNumberA { get; set; }
        public string ModNumberB { get; set; }
        public string ModNumberN { get; set; }
        public string ModResult { get; set; }

        public event EventHandler CalculateModularSum;
        public event EventHandler CalculateModularSubtract;
        public event EventHandler CalculateModularMultiply;
        public event EventHandler CalculateModularDivide;

        public string LastErrorMessage { get; private set; }

        public void ShowError(string message)
        {
            LastErrorMessage = message;
        }

        public void TriggerCalculateSum()
        {
            CalculateModularSum?.Invoke(this, EventArgs.Empty);
        }

        public void TriggerCalculateSubtract()
        {
            CalculateModularSubtract?.Invoke(this, EventArgs.Empty);
        }

        public void TriggerCalculateMultiply()
        {
            CalculateModularMultiply?.Invoke(this, EventArgs.Empty);
        }

        public void TriggerCalculateDivide()
        {
            CalculateModularDivide?.Invoke(this, EventArgs.Empty);
        }
    }
}