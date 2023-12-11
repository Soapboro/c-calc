namespace Calculator
{
    public struct ComplexNumber
    {
        public double real;
        public double img;

        public ComplexNumber(double real = 0, double img = 0)
        {
            this.real = real;
            this.img = img;
        }
    }
    
    public class ComplexNum: CalcInterface
    {
        private ComplexNumber aComplex;
        private ComplexNumber bComplex;
        private ComplexNumber resComplex;

        public ComplexNum(double aReal, double aImg, double bReal, double bImg)
        {
            aComplex = new ComplexNumber(aReal, aImg);
            bComplex = new ComplexNumber(bReal, bImg);
        }

        public ComplexNum()
        {
            aComplex = new ComplexNumber();
            bComplex = new ComplexNumber();
        }

        public void getRes(out double real, out double img)
        {
            real = resComplex.real;
            img = resComplex.img;
        }

        /// <summary>
        /// Метод суммирования комплексных чисел: A(д)+B(д)=C(д); A(мн)+B(мн)=C(мн)
        /// </summary>
        public void findSum()
        {
            resComplex.real = aComplex.real + bComplex.real; //Сумма реальных частей
            resComplex.img = aComplex.img + bComplex.img; //Сумма мнимых частей
        }
        /// <summary>
        /// Метод вычитания комплексных чисел: A(д)-B(д)=C(д); A(мн)-B(мн)=C(мн)
        /// </summary>
        public void findSubstr()
        {
            resComplex.real = aComplex.real - bComplex.real; //Разность реальных частей
            resComplex.img = aComplex.img - bComplex.img; //Разность мнимых частей
        }
        /// <summary>
        /// Метод умножения комплексных чисел: A(д)*B(д)-A(мн)*B(мн)=C(д); 
        /// B(д)*A(мн)+A(д)*B(мн)=C(мн);
        /// </summary>
        public void findMult()
        {
            resComplex.real = aComplex.real * bComplex.real - aComplex.img * bComplex.img; //Произведение реальных частей
            resComplex.img = bComplex.real * aComplex.img + aComplex.real * bComplex.img; //Произведение мнимых частей
        }
        /// <summary>
        /// Метод деления комплексных чисел: 
        /// (A(д)*B(д)+A(мн)*B(мн))/(B(д)*B(д)+B(мн)*B(мн))=C(д); 
        /// (B(д)*A(мн)-A(д)*B(мн))/(B(д)*B(д)+B(мн)*B(мн))=C(мн);
        /// </summary>
        public void findDiv()
        {
            resComplex.real = (aComplex.real * bComplex.real + aComplex.img * bComplex.img) /
                (bComplex.real * bComplex.real + bComplex.img * bComplex.img); //Частное реальных частей
            resComplex.img = (aComplex.img * bComplex.real - aComplex.real * bComplex.img) /
                (bComplex.real * bComplex.real + bComplex.img * bComplex.img); //Частное мнимых частей
        }
    }
}