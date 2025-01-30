using System;
using System.Numerics;

namespace Calculator
{
    public class CalculatorPresenter
    {
        private ICalculatorView _view;
        private RealNum _realCalculator;
        private ComplexNum _complexCalculator;
        private QuaternionNum _quaternionCalculator;
        private ModNum _modularCalculator;

        public CalculatorPresenter(ICalculatorView view)
        {
            _view = view;
            _realCalculator = new RealNum();
            _complexCalculator = new ComplexNum();
            _quaternionCalculator = new QuaternionNum();
            _modularCalculator = new ModNum();

            // Wire up events for Real Numbers
            _view.CalculateRealSum += HandleRealSum;
            _view.CalculateRealSubtract += HandleRealSubtract;
            _view.CalculateRealMultiply += HandleRealMultiply;
            _view.CalculateRealDivide += HandleRealDivide;

            // Wire up events for Quaternion
            _view.CalculateQuaternionSum += HandleQuaternionSum;
            _view.CalculateQuaternionSubtract += HandleQuaternionSubtract;
            _view.CalculateQuaternionMultiply += HandleQuaternionMultiply;
            _view.CalculateQuaternionDivide += HandleQuaternionDivide;
            // Wire up other events similarly
        }

        private void HandleRealSum(object sender, EventArgs e)
        {
            try
            {
                _realCalculator = new RealNum(
                    Convert.ToDouble(_view.RealNumberA),
                    Convert.ToDouble(_view.RealNumberB));
                _realCalculator.findSum();
                _view.RealResult = Convert.ToString(_realCalculator.getRes());
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        private void HandleRealSubtract(object sender, EventArgs e)
        {
            try
            {
                _realCalculator = new RealNum(
                    Convert.ToDouble(_view.RealNumberA),
                    Convert.ToDouble(_view.RealNumberB));
                _realCalculator.findSubstr();
                _view.RealResult = Convert.ToString(_realCalculator.getRes());
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        private void HandleRealMultiply(object sender, EventArgs e)
        {
            try
            {
                _realCalculator = new RealNum(
                    Convert.ToDouble(_view.RealNumberA),
                    Convert.ToDouble(_view.RealNumberB));
                _realCalculator.findMult();
                _view.RealResult = Convert.ToString(_realCalculator.getRes());
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }


        private void HandleRealDivide(object sender, EventArgs e)
        {
            try
            {
                _realCalculator = new RealNum(
                    Convert.ToDouble(_view.RealNumberA),
                    Convert.ToDouble(_view.RealNumberB));
                _realCalculator.findDiv();
                _view.RealResult = Convert.ToString(_realCalculator.getRes());
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        private void HandleQuaternionSum (object sender, EventArgs e)
        {
            try
            {
                _quaternionCalculator = new QuaternionNum(
                    Convert.ToSingle(_view.QuatRealA),
                    Convert.ToSingle(_view.QuatVecXA),
                    Convert.ToSingle(_view.QuatVecYA),
                    Convert.ToSingle(_view.QuatVecZA),
                    Convert.ToSingle(_view.QuatRealB),
                    Convert.ToSingle(_view.QuatVecXB),
                    Convert.ToSingle(_view.QuatVecYB),
                    Convert.ToSingle(_view.QuatVecZB));
                _quaternionCalculator.findSum();
                float bufReal;
                Vector3 bufVector;
                _quaternionCalculator.getRes(out bufReal, out bufVector);
                _view.QuatRealResult = Convert.ToString(bufReal);
                _view.QuatVecXResult = Convert.ToString(bufVector.X);
                _view.QuatVecYResult = Convert.ToString(bufVector.Y);
                _view.QuatVecZResult = Convert.ToString(bufVector.Z);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        private void HandleQuaternionSubtract(object sender, EventArgs e)
        {
            try
            {
                _quaternionCalculator = new QuaternionNum(
                    Convert.ToSingle(_view.QuatRealA),
                    Convert.ToSingle(_view.QuatVecXA),
                    Convert.ToSingle(_view.QuatVecYA),
                    Convert.ToSingle(_view.QuatVecZA),
                    Convert.ToSingle(_view.QuatRealB),
                    Convert.ToSingle(_view.QuatVecXB),
                    Convert.ToSingle(_view.QuatVecYB),
                    Convert.ToSingle(_view.QuatVecZB));
                _quaternionCalculator.findSubstr();
                float bufReal;
                Vector3 bufVector;
                _quaternionCalculator.getRes(out bufReal, out bufVector);
                _view.QuatRealResult = Convert.ToString(bufReal);
                _view.QuatVecXResult = Convert.ToString(bufVector.X);
                _view.QuatVecYResult = Convert.ToString(bufVector.Y);
                _view.QuatVecZResult = Convert.ToString(bufVector.Z);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        private void HandleQuaternionMultiply(object sender, EventArgs e)
        {
            try
            {
                _quaternionCalculator = new QuaternionNum(
                    Convert.ToSingle(_view.QuatRealA),
                    Convert.ToSingle(_view.QuatVecXA),
                    Convert.ToSingle(_view.QuatVecYA),
                    Convert.ToSingle(_view.QuatVecZA),
                    Convert.ToSingle(_view.QuatRealB),
                    Convert.ToSingle(_view.QuatVecXB),
                    Convert.ToSingle(_view.QuatVecYB),
                    Convert.ToSingle(_view.QuatVecZB));
                _quaternionCalculator.findMult();
                float bufReal;
                Vector3 bufVector;
                _quaternionCalculator.getRes(out bufReal, out bufVector);
                _view.QuatRealResult = Convert.ToString(bufReal);
                _view.QuatVecXResult = Convert.ToString(bufVector.X);
                _view.QuatVecYResult = Convert.ToString(bufVector.Y);
                _view.QuatVecZResult = Convert.ToString(bufVector.Z);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }
        private void HandleQuaternionDivide(object sender, EventArgs e)
        {
            try
            {
                _quaternionCalculator = new QuaternionNum(
                    Convert.ToSingle(_view.QuatRealA),
                    Convert.ToSingle(_view.QuatVecXA),
                    Convert.ToSingle(_view.QuatVecYA),
                    Convert.ToSingle(_view.QuatVecZA),
                    Convert.ToSingle(_view.QuatRealB),
                    Convert.ToSingle(_view.QuatVecXB),
                    Convert.ToSingle(_view.QuatVecYB),
                    Convert.ToSingle(_view.QuatVecZB));
                _quaternionCalculator.findDiv();
                float bufReal;
                Vector3 bufVector;
                _quaternionCalculator.getRes(out bufReal, out bufVector);
                _view.QuatRealResult = Convert.ToString(bufReal);
                _view.QuatVecXResult = Convert.ToString(bufVector.X);
                _view.QuatVecYResult = Convert.ToString(bufVector.Y);
                _view.QuatVecZResult = Convert.ToString(bufVector.Z);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }
    }
}