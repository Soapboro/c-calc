using System;
namespace Calculator
{
    public interface IViewQuaternion
    {
        // Quaternion numbers
        string QuatRealA { get; set; }
        string QuatVecXA { get; set; }
        string QuatVecYA { get; set; }
        string QuatVecZA { get; set; }
        string QuatRealB { get; set; }
        string QuatVecXB { get; set; }
        string QuatVecYB { get; set; }
        string QuatVecZB { get; set; }
        string QuatRealResult { get; set; }
        string QuatVecXResult { get; set; }
        string QuatVecYResult { get; set; }
        string QuatVecZResult { get; set; }

        // EventsQuaternion
        event EventHandler CalculateQuaternionSum;
        event EventHandler CalculateQuaternionSubtract;
        event EventHandler CalculateQuaternionMultiply;
        event EventHandler CalculateQuaternionDivide;

        void ShowError(string message);
    }
}