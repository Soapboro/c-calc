using System;
using System.Numerics;

namespace Calculator
{
    public class PresenterComplex
    {
        private IViewComplex _view;
        private ComplexNum _complexCalculator;

        public PresenterComplex(IViewComplex view)
        {
            _view = view;
            _complexCalculator = new ComplexNum();

            // Wire up events for Complex Numbers
            _view.CalculateComplexSum += HandleComplexSum;
            _view.CalculateComplexSubtract += HandleComplexSubtract;
            _view.CalculateComplexMultiply += HandleComplexMultiply;
            _view.CalculateComplexDivide += HandleComplexDivide;
        }

        private void HandleComplexDivide(object sender, EventArgs e)
        {
            try
            {
                _complexCalculator = GetComplexNumber();

                _complexCalculator.findDiv();
                double bufReal;
                double bufImg;
                _complexCalculator.getRes(out bufReal, out bufImg);
                _view.ComplexRealResult = Convert.ToString(bufReal);
                _view.ComplexImgResult = Convert.ToString(bufImg);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        private void HandleComplexMultiply(object sender, EventArgs e)
        {
            try
            {
                _complexCalculator = GetComplexNumber();

                _complexCalculator.findMult();
                double bufReal;
                double bufImg;
                _complexCalculator.getRes(out bufReal, out bufImg);
                _view.ComplexRealResult = Convert.ToString(bufReal);
                _view.ComplexImgResult = Convert.ToString(bufImg);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        private void HandleComplexSubtract(object sender, EventArgs e)
        {
            try
            {
                _complexCalculator = GetComplexNumber();

                _complexCalculator.findSubstr();
                double bufReal;
                double bufImg;
                _complexCalculator.getRes(out bufReal, out bufImg);
                _view.ComplexRealResult = Convert.ToString(bufReal);
                _view.ComplexImgResult = Convert.ToString(bufImg);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        private void HandleComplexSum(object sender, EventArgs e)
        {
            try
            {
                _complexCalculator = GetComplexNumber();

                _complexCalculator.findSum();
                double bufReal;
                double bufImg;
                _complexCalculator.getRes(out bufReal, out bufImg);
                _view.ComplexRealResult = Convert.ToString(bufReal);
                _view.ComplexImgResult = Convert.ToString(bufImg);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        public ComplexNum GetComplexNumber()
        {
            return new ComplexNum(
                Convert.ToDouble(_view.ComplexRealA),
                Convert.ToDouble(_view.ComplexImgA),
                Convert.ToDouble(_view.ComplexRealB),
                Convert.ToDouble(_view.ComplexImgB));
        }
    }
}