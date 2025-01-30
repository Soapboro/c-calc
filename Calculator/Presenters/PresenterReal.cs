using System;
using System.Numerics;

namespace Calculator
{
    public class PresenterReal
    {
        private IViewReal _view;
        private RealNum _realCalculator;


        public PresenterReal(IViewReal view)
        {
            _view = view;
            _realCalculator = new RealNum();

            // Wire up events for Real Numbers
            _view.CalculateRealSum += HandleRealSum;
            _view.CalculateRealSubtract += HandleRealSubtract;
            _view.CalculateRealMultiply += HandleRealMultiply;
            _view.CalculateRealDivide += HandleRealDivide;
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
    }
}