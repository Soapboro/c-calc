namespace Calculator
{
    public class RealNum: CalcInterface
    {
        private double aReal, bReal; //Действительные числа
        private double realResult; //Результат

        public RealNum(double a, double b)
        {
            this.aReal = a;
            this.bReal = b;
        }

        public RealNum()
        {
            this.aReal = this.bReal = 0;
        }

        public double getRes()
        {
            return realResult;
        }

        public void findSum()
        {
            realResult = aReal + bReal; //Сумма
        }

        public void findSubstr()
        {
            realResult = aReal - bReal; //Разность
        }

        public void findMult()
        {
            realResult = aReal * bReal; //Произведение
        }
       
        public void findDiv()
        {
            realResult = aReal / bReal; //Частное
        }
    }
}
