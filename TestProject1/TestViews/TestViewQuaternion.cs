using System;
using Calculator;

namespace TestProject1.TestViews
{
    public class TestViewQuaternion : IViewQuaternion
    {
        public string QuatRealA { get; set; }
        public string QuatVecXA { get; set; }
        public string QuatVecYA { get; set; }
        public string QuatVecZA { get; set; }
        public string QuatRealB { get; set; }
        public string QuatVecXB { get; set; }
        public string QuatVecYB { get; set; }
        public string QuatVecZB { get; set; }
        public string QuatRealResult { get; set; }
        public string QuatVecXResult { get; set; }
        public string QuatVecYResult { get; set; }
        public string QuatVecZResult { get; set; }

        public event EventHandler CalculateQuaternionSum;
        public event EventHandler CalculateQuaternionSubtract;
        public event EventHandler CalculateQuaternionMultiply;
        public event EventHandler CalculateQuaternionDivide;

        public string LastErrorMessage { get; private set; }

        public void ShowError(string message)
        {
            LastErrorMessage = message;
        }

        public void TriggerCalculateSum()
        {
            CalculateQuaternionSum?.Invoke(this, EventArgs.Empty);
        }

        public void TriggerCalculateSubtract()
        {
            CalculateQuaternionSubtract?.Invoke(this, EventArgs.Empty);
        }

        public void TriggerCalculateMultiply()
        {
            CalculateQuaternionMultiply?.Invoke(this, EventArgs.Empty);
        }

        public void TriggerCalculateDivide()
        {
            CalculateQuaternionDivide?.Invoke(this, EventArgs.Empty);
        }
    }
}