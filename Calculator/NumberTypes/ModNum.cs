using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public class ModNum: CalcInterface
    {
        private int aMod, bMod, nMod; //Числа по модулю N
        private int res; //Результат

        public ModNum()
        {
            this.aMod = this.bMod = this.nMod = 0;
        }

        public ModNum(int aMod, int bMod, int nMod)
        {
            this.aMod = aMod;
            this.bMod = bMod;
            this.nMod = nMod;
        }

        public int getRes()
        {
            return res;
        }
        /// <summary>
        /// Метод суммирования чисел по модулю N: (A+B) mod N = C
        /// </summary>
        public void findSum()
        {
            res = (aMod + bMod) % nMod; //Сумма
        }
        /// <summary>
        /// Метод вычитания чисел по модулю N: (A+N-B) mod N = C
        /// </summary>
        public void findSubstr()
        {
            res = (aMod + nMod - bMod) % nMod; //Вычитание
        }
        /// <summary>
        /// Метод умножения чисел по модулю N: (A*B) mod N = C
        /// </summary>
        public void findMult()
        {
            res = (aMod * bMod) % nMod; //Произведение
        }
        /// <summary>
        /// Метод деления чисел по модулю N: (A*B^(N-2)) mod N = C
        /// </summary>
        public void findDiv()
        {
            int notPrime = 0;
            if (nMod > 1)
            {
                for (int i = 2; i < nMod; i++) //Проверка основания (простое число)
                {
                    if (nMod % i == 0)
                        notPrime = 1; //Не простое число
                }
            }
            if (notPrime == 1) //Если основание - не простое число
                MessageBox.Show("Модуль должен быть простым!");
            else
                res = (int)(aMod * Math.Pow(bMod, nMod - 2)) % nMod; //Частное
        }
    }
}
