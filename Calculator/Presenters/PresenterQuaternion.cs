using System;
using System.Numerics;

namespace Calculator
{
    public class PresenterQuaternion
    {
        private IViewQuaternion _view;
        private QuaternionNum _quaternionCalculator;

        public PresenterQuaternion(IViewQuaternion view)
        {
            _view = view;
            _quaternionCalculator = new QuaternionNum();

            // Wire up events for Quaternion
            _view.CalculateQuaternionSum += HandleQuaternionSum;
            _view.CalculateQuaternionSubtract += HandleQuaternionSubtract;
            _view.CalculateQuaternionMultiply += HandleQuaternionMultiply;
            _view.CalculateQuaternionDivide += HandleQuaternionDivide;
        }
        private void HandleQuaternionSum(object sender, EventArgs e)
        {
            try
            {
                _quaternionCalculator = GetQuaternionNum();
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
                _quaternionCalculator = GetQuaternionNum();
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
                _quaternionCalculator = GetQuaternionNum();
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
                _quaternionCalculator = GetQuaternionNum();
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

        private QuaternionNum GetQuaternionNum()
        {
            return new QuaternionNum(Convert.ToSingle(_view.QuatRealA),
                    Convert.ToSingle(_view.QuatVecXA),
                    Convert.ToSingle(_view.QuatVecYA),
                    Convert.ToSingle(_view.QuatVecZA),
                    Convert.ToSingle(_view.QuatRealB),
                    Convert.ToSingle(_view.QuatVecXB),
                    Convert.ToSingle(_view.QuatVecYB),
                    Convert.ToSingle(_view.QuatVecZB));
        }
    }
}