using System;
using System.Numerics;
using System.Windows.Forms;

namespace Calculator
{
    /// <summary>
    /// Класс формы, открывающейся при запуске калькулятора.
    /// Содержит методы, обрабатывающие события "нажатие кнопки".
    /// </summary>
    public partial class Form1 : Form, IViewReal, IViewQuaternion, IViewComplex, IViewModular
    {
        //private readonly CalculatorPresenter _presenter;
        private readonly PresenterReal _presenterReal;
        private readonly PresenterQuaternion _presenterQuaternion;
        private readonly PresenterComplex _presenterComplex;
        private readonly PresenterModular _presenterModular;

        public Form1()
        {
            InitializeComponent();
            _presenterReal = new PresenterReal(this);
            _presenterQuaternion = new PresenterQuaternion(this);
            _presenterComplex = new PresenterComplex(this);
            _presenterModular = new PresenterModular(this);
        }

        #region ICalculatorView Properties
        // Real numbers
        public string RealNumberA
        {
            get => realA.Text;
            set => realA.Text = value;
        }
        public string RealNumberB
        {
            get => realB.Text;
            set => realB.Text = value;
        }
        public string RealResult
        {
            get => realRes.Text;
            set => realRes.Text = value;
        }

        // Complex numbers
        public string ComplexRealA
        {
            get => complexRealA.Text;
            set => complexRealA.Text = value;
        }
        public string ComplexImgA
        {
            get => complexImgA.Text;
            set => complexImgA.Text = value;
        }
        public string ComplexRealB
        {
            get => complexRealB.Text;
            set => complexRealB.Text = value;
        }
        public string ComplexImgB
        {
            get => complexImgB.Text;
            set => complexImgB.Text = value;
        }
        public string ComplexRealResult
        {
            get => complexRealRes.Text;
            set => complexRealRes.Text = value;
        }
        public string ComplexImgResult
        {
            get => complexImgRes.Text;
            set => complexImgRes.Text = value;
        }

        // Quaternion numbers
        public string QuatRealA
        {
            get => quatRealA.Text;
            set => quatRealA.Text = value;
        }
        public string QuatVecXA
        {
            get => quatVecXA.Text;
            set => quatVecXA.Text = value;
        }
        public string QuatVecYA
        {
            get => quatVecYA.Text;
            set => quatVecYA.Text = value;
        }
        public string QuatVecZA
        {
            get => quatVecZA.Text;
            set => quatVecZA.Text = value;
        }
        public string QuatRealB
        {
            get => quatRealB.Text;
            set => quatRealB.Text = value;
        }
        public string QuatVecXB
        {
            get => quatVecXB.Text;
            set => quatVecXB.Text = value;
        }
        public string QuatVecYB
        {
            get => quatVecYB.Text;
            set => quatVecYB.Text = value;
        }
        public string QuatVecZB
        {
            get => quatVecZB.Text;
            set => quatVecZB.Text = value;
        }
        public string QuatRealResult
        {
            get => quatRealRes.Text;
            set => quatRealRes.Text = value;
        }
        public string QuatVecXResult
        {
            get => quatVecXRes.Text;
            set => quatVecXRes.Text = value;
        }
        public string QuatVecYResult
        {
            get => quatVecYRes.Text;
            set => quatVecYRes.Text = value;
        }
        public string QuatVecZResult
        {
            get => quatVecZRes.Text;
            set => quatVecZRes.Text = value;
        }

        // Modular numbers
        public string ModNumberA
        {
            get => modNumA.Text;
            set => modNumA.Text = value;
        }
        public string ModNumberB
        {
            get => modNumB.Text;
            set => modNumB.Text = value;
        }
        public string ModNumberN
        {
            get => modNumN.Text;
            set => modNumN.Text = value;
        }
        public string ModResult
        {
            get => modRes.Text;
            set => modRes.Text = value;
        }
        #endregion

        #region Events
        public event EventHandler CalculateRealSum;
        public event EventHandler CalculateRealSubtract;
        public event EventHandler CalculateRealMultiply;
        public event EventHandler CalculateRealDivide;

        public event EventHandler CalculateComplexSum;
        public event EventHandler CalculateComplexSubtract;
        public event EventHandler CalculateComplexMultiply;
        public event EventHandler CalculateComplexDivide;

        public event EventHandler CalculateQuaternionSum;
        public event EventHandler CalculateQuaternionSubtract;
        public event EventHandler CalculateQuaternionMultiply;
        public event EventHandler CalculateQuaternionDivide;

        public event EventHandler CalculateModularSum;
        public event EventHandler CalculateModularSubtract;
        public event EventHandler CalculateModularMultiply;
        public event EventHandler CalculateModularDivide;
        #endregion

        #region Button Click Handlers
        private void realSum_Click(object sender, EventArgs e)
        {
            CalculateRealSum?.Invoke(this, EventArgs.Empty);
        }

        private void realSubstr_Click(object sender, EventArgs e)
        {
            CalculateRealSubtract?.Invoke(this, EventArgs.Empty);
        }

        private void realMult_Click(object sender, EventArgs e)
        {
            CalculateRealMultiply?.Invoke(this, EventArgs.Empty);
        }

        private void realDiv_Click(object sender, EventArgs e)
        {
            CalculateRealDivide?.Invoke(this, EventArgs.Empty);
        }

        private void quatDiv_Click (object sender, EventArgs e)
        {
            CalculateQuaternionDivide?.Invoke(this, EventArgs.Empty);
        }

        private void quatMult_Click (object sender, EventArgs e)
        {
            CalculateQuaternionMultiply?.Invoke(this, EventArgs.Empty);
        }

        private void quatSubstr_Click (object sender, EventArgs e)
        {
            CalculateQuaternionSubtract?.Invoke(this, EventArgs.Empty);
        }
        
        private void quatSum_Click (object sender, EventArgs e)
        {
            CalculateQuaternionSum?.Invoke(this, EventArgs.Empty);
        }

        private void complexSum_Click (object sender, EventArgs e)
        {
            CalculateComplexSum?.Invoke(this, EventArgs.Empty);
        }

        private void complexSubstr_Click (object sender, EventArgs e)
        {
            CalculateComplexSubtract?.Invoke(this, EventArgs.Empty);
        }

        private void complexMult_Click (object sender, EventArgs e)
        {
            CalculateComplexMultiply?.Invoke(this, EventArgs.Empty);
        }

        private void complexDiv_Click (object sender, EventArgs e)
        {
            CalculateComplexDivide?.Invoke(this, EventArgs.Empty);
        }

        private void modSum_Click (object sender, EventArgs e)
        {
            CalculateModularSum?.Invoke(this, EventArgs.Empty);
        }

        private void modSubstr_Click (object sender, EventArgs e)
        {
            CalculateModularSubtract?.Invoke(this, EventArgs.Empty);
        }

        private void modMult_Click (object sender, EventArgs e)
        {
            CalculateModularMultiply?.Invoke(this, EventArgs.Empty);
        }

        private void modDiv_Click (object sender, EventArgs e)
        {
            CalculateModularDivide?.Invoke(this, EventArgs.Empty);
        }
        #endregion

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}