using System;
namespace Calculator
{
    public interface ICalculatorView
    {
        // Real numbers
        string RealNumberA { get; set; }
        string RealNumberB { get; set; }
        string RealResult { get; set; }

        // Complex numbers
        string ComplexRealA { get; set; }
        string ComplexImgA { get; set; }
        string ComplexRealB { get; set; }
        string ComplexImgB { get; set; }
        string ComplexRealResult { get; set; }
        string ComplexImgResult { get; set; }

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

        // Modular numbers
        string ModNumberA { get; set; }
        string ModNumberB { get; set; }
        string ModNumberN { get; set; }
        string ModResult { get; set; }

        // EventsReal
        event EventHandler CalculateRealSum;
        event EventHandler CalculateRealSubtract;
        event EventHandler CalculateRealMultiply;
        event EventHandler CalculateRealDivide;

        // EventsQuaternion
        event EventHandler CalculateQuaternionSum;
        event EventHandler CalculateQuaternionSubtract;
        event EventHandler CalculateQuaternionMultiply;
        event EventHandler CalculateQuaternionDivide;
        // Add similar events for complex, quaternion and modular operations

        void ShowError(string message);
    }
}