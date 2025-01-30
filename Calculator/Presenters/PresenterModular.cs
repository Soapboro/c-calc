using System;
using System.Numerics;

namespace Calculator
{
    public class PresenterModular
    {
        private IViewModular _view;
        private ModNum _modularCalculator;

        public PresenterModular(IViewModular view)
        {
            _view = view;
            _modularCalculator = new ModNum();

            //Wire up event for Modular Number
            _view.CalculateModularSum += HandleModularSum;
            _view.CalculateModularSubtract += HandleModularSubtract;
            _view.CalculateModularMultiply += HandleModularMultiply;
            _view.CalculateModularDivide += HandleModularDivide;
        }

        private void HandleModularSum(object sender, EventArgs e)
        {
            try
            {
                _modularCalculator = GetModNum();
                _modularCalculator.findSum();
                _view.ModResult = Convert.ToString(_modularCalculator.getRes());
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        private void HandleModularSubtract(object sender, EventArgs e)
        {
            try
            {
                _modularCalculator = GetModNum();
                _modularCalculator.findSubstr();
                _view.ModResult = Convert.ToString(_modularCalculator.getRes());
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        private void HandleModularMultiply(object sender, EventArgs e)
        {
            try
            {
                _modularCalculator = GetModNum();
                _modularCalculator.findMult();
                _view.ModResult = Convert.ToString(_modularCalculator.getRes());
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        private void HandleModularDivide(object sender, EventArgs e)
        {
            try
            {
                _modularCalculator = GetModNum();
                _modularCalculator.findDiv();
                _view.ModResult = Convert.ToString(_modularCalculator.getRes());
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        private ModNum GetModNum()
        {
            return new ModNum(
                Convert.ToInt32(_view.ModNumberA),
                Convert.ToInt32(_view.ModNumberB), 
                Convert.ToInt32(_view.ModNumberN));
        }
    }
}