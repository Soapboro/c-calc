using System;
using System.Windows;
using System.Numerics;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        realCalc realnumCalc = new realCalc(); //Класс для операций с действительными
        complexCalc complexnumCalc = new complexCalc(); //Класс для операций с комплексными
        quantCalc quantnumCalc = new quantCalc(); //Класс для операций с кватернионами
        moduleCalc modnumCalc = new moduleCalc(); //Класс для операций с числами по модулю

        public Form1()
        {
            InitializeComponent(); //Запуск формы
        }

        private void realGetNumbers()
        {
            try
            {
                realnumCalc.aReal = Convert.ToDouble(realA.Text); //Получение значения из поля А
                realnumCalc.bReal = Convert.ToDouble(realB.Text); //Получение значения из поля В
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Если значение в поле некорректно - уведомляем пользователя
            }
        }

        private void updateRealRes()
        {
            realRes.Text = Convert.ToString(realnumCalc.realResult); //Обновление значения в поле результата
        }

        private void realSum_Click(object sender, EventArgs e)
        {
            realGetNumbers(); //Получение значений из полей
            realnumCalc.realSum(); //Сумма действительных
            updateRealRes(); //Обновление значения поля результата 
        }

        private void realSubstr_Click(object sender, EventArgs e)
        {
            realGetNumbers(); //Получение значений из полей
            realnumCalc.realSubstr(); //Вычитание действительных
            updateRealRes(); //Обновление значения поля результата 
        }

        private void realMult_Click(object sender, EventArgs e)
        {
            realGetNumbers(); //Получение значений из полей
            realnumCalc.realMult(); //Произведение действительных
            updateRealRes(); //Обновление значения поля результата 
        }

        private void realDiv_Click(object sender, EventArgs e)
        {
            realGetNumbers(); //Получение значений из полей
            realnumCalc.realDiv(); //Частное действительных
            updateRealRes(); //Обновление значения поля результата 
        }

        private void complexGetNum()
        {
            try
            {
                complexnumCalc.aComplexReal = Convert.ToDouble(complexRealA.Text); //Получение значения реальной части А
                complexnumCalc.bComplexReal = Convert.ToDouble(complexRealB.Text); //Получение значения реальной части В
                complexnumCalc.aComplexImg = Convert.ToDouble(complexImgA.Text); //Получение значения мнимой части А
                complexnumCalc.bComplexImg = Convert.ToDouble(complexImgB.Text); //Получение значения мнимой части В
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Если значение в поле некорректно - уведомляем пользователя
            }
        }

        private void updateComplexRes()
        {
            complexRealRes.Text = Convert.ToString(complexnumCalc.resComplexReal); //Обновление значения в поле реальной части результата
            complexImgRes.Text = Convert.ToString(complexnumCalc.resComplexImg); //Обновление значения в поле мнимой части результата
        }

        private void complexSum_Click(object sender, EventArgs e)
        {
            complexGetNum(); //Получение значений из полей
            complexnumCalc.complexSum(); //Сумма комплексных
            updateComplexRes(); //Обновление значения поля результата 
        }

        private void complexSubstr_Click(object sender, EventArgs e)
        {
            complexGetNum(); //Получение значений из полей
            complexnumCalc.complexSubstr(); //Вычитание комплексных
            updateComplexRes(); //Обновление значения поля результата 
        }

        private void complexMult_Click(object sender, EventArgs e)
        {
            complexGetNum(); //Получение значений из полей
            complexnumCalc.complexMult(); //Произведение комплексных
            updateComplexRes(); //Обновление значения поля результата 
        }

        private void complexDiv_Click(object sender, EventArgs e)
        {
            complexGetNum(); //Получение значений из полей
            complexnumCalc.complexDiv(); //Частное комплексных
            updateComplexRes(); //Обновление значения поля результата 
        }

        private void updateQuantRes()
        {
            quantRealRes.Text = Convert.ToString(quantnumCalc.resQuantReal); //Обновление значения в поле реальной части результата
            quantVecXRes.Text = Convert.ToString(quantnumCalc.vectorRes.X); //Обновление значения в поле X-координаты части результата
            quantVecYRes.Text = Convert.ToString(quantnumCalc.vectorRes.Y); //Обновление значения в поле Y-координаты части результата
            quantVecZRes.Text = Convert.ToString(quantnumCalc.vectorRes.Z); //Обновление значения в поле Z-координаты части результата
        }

        public void quantGetNum()
        {
            try
            {
                quantnumCalc.aQuantReal = Convert.ToSingle(quantRealA.Text); //Получение значения реальной части кватерниона А
                quantnumCalc.aVecX = Convert.ToSingle(quantVecXA.Text); //Получение значения X-координаты кватерниона А
                quantnumCalc.aVecY = Convert.ToSingle(quantVecYA.Text); //Получение значения Y-координаты кватерниона А
                quantnumCalc.aVecZ = Convert.ToSingle(quantVecZA.Text); //Получение значения Z-координаты кватерниона А

                quantnumCalc.bQuantReal = Convert.ToSingle(quantRealB.Text); //Получение значения реальной части кватерниона В
                quantnumCalc.bVecX = Convert.ToSingle(quantVecXB.Text); //Получение значения X-координаты кватерниона B
                quantnumCalc.bVecY = Convert.ToSingle(quantVecYB.Text); //Получение значения Y-координаты кватерниона B
                quantnumCalc.bVecZ = Convert.ToSingle(quantVecZB.Text); //Получение значения Z-координаты кватерниона B
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Если значение в поле некорректно - уведомляем пользователя
            }
        }

        private void quantSum_Click(object sender, EventArgs e)
        {
            quantGetNum(); //Получение значений из полей
            quantnumCalc.quantSum(); //Сумма кватернионов
            updateQuantRes(); //Обновление значения поля результата 
        }

        private void quantSubstr_Click(object sender, EventArgs e)
        {
            quantGetNum(); //Получение значений из полей
            quantnumCalc.quantSubstr(); //Вычитание кватернионов
            updateQuantRes(); //Обновление значения поля результата 
        }

        private void quantMult_Click(object sender, EventArgs e)
        {
            quantGetNum(); //Получение значений из полей
            quantnumCalc.quantMult(); //Произведение кватернионов
            updateQuantRes(); //Обновление значения поля результата 
        }

        private void quantDiv_Click(object sender, EventArgs e)
        {
            quantGetNum(); //Получение значений из полей
            quantnumCalc.quantDiv(); //Частное кватернионов
            updateQuantRes(); //Обновление значения поля результата 
        }

        private void modGetNum()
        {
            try
            {
                modnumCalc.aMod = Convert.ToInt32(modNumA.Text); //Получение значения числа А из поля
                modnumCalc.bMod = Convert.ToInt32(modNumB.Text); //Получение значения числа В из поля
                modnumCalc.nMod = Convert.ToInt32(modNumN.Text); //Получение модуля из поля
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Если значение в поле некорректно - уведомляем пользователя
            }
        }

        private void updateMouleRes()
        {
            modRes.Text = Convert.ToString(modnumCalc.res); //Обновление результата в поле
        }

        private void modSum_Click(object sender, EventArgs e)
        {
            modGetNum(); //Получение значений из полей
            modnumCalc.modSum(); //Сумма чисел по модулю
            updateMouleRes(); //Обновление результата
        }

        private void modSubstr_Click(object sender, EventArgs e)
        {
            modGetNum(); //Получение значений из полей
            modnumCalc.modSubstr(); //Вычитание чисел по модулю
            updateMouleRes(); //Обновление результата
        }

        private void modMult_Click(object sender, EventArgs e)
        {
            modGetNum(); //Получение значений из полей
            modnumCalc.modMult(); //Произведение чисел по модулю
            updateMouleRes(); //Обновление результата
        }

        private void modDiv_Click(object sender, EventArgs e)
        {
            modGetNum(); //Получение значений из полей
            modnumCalc.modDiv(); //Частное чисел по модулю
            updateMouleRes(); //Обновление результата
        }
    }

    public class realCalc
    {
        public double aReal, bReal; //Действительные числа
        public double realResult; //Результат

        public void realSum()
        {
            realResult = aReal + bReal; //Сумма
        }

        public void realSubstr()
        {
            realResult = aReal - bReal; //Разность
        }

        public void realMult()
        {
            realResult = aReal * bReal; //Произведение
        }

        public void realDiv()
        {
            realResult = aReal / bReal; //Частное
        }
    }

    public class complexCalc
    {
        public double aComplexReal, bComplexReal; //Комплексные (действительная часть)
        public double aComplexImg, bComplexImg; //Комплексные (мнимая часть)
        public double resComplexReal, resComplexImg; //Комплексные (результат)

        public void complexSum()
        {
            resComplexReal = aComplexReal + bComplexReal; //Сумма реальных частей
            resComplexImg = aComplexImg + bComplexImg; //Сумма мнимых частей
        }

        public void complexSubstr()
        {
            resComplexReal = aComplexReal - bComplexReal; //Разность реальных частей
            resComplexImg = aComplexImg - bComplexImg; //Разность мнимых частей
        }

        public void complexMult()
        {
            resComplexReal = aComplexReal * bComplexReal - aComplexImg * bComplexImg; //Произведение реальных частей
            resComplexImg = bComplexReal * aComplexImg + aComplexReal * bComplexImg; //Произведение мнимых частей
        }

        public void complexDiv()
        {
            resComplexReal = (aComplexReal * bComplexReal + aComplexImg * bComplexImg) / (bComplexReal * bComplexReal + bComplexImg * bComplexImg); //Частное реальных частей
            resComplexImg = (aComplexImg * bComplexReal - aComplexReal * bComplexImg) / (bComplexReal * bComplexReal + bComplexImg * bComplexImg); //Частное мнимых частей
        }
    }

    public class quantCalc
    {
        public float aQuantReal, bQuantReal; //кватернионы (действительная часть)
        public float aVecX, aVecY, aVecZ, bVecX, bVecY, bVecZ; //кватернионы (векторная часть)
        public float resQuantReal, resVecX, resVecY, resvecZ; //кватернион-результат

        public Vector3 vectorA; //Векторная часть кватерниона А
        public Vector3 vectorB; //Векторная часть кватерниона В
        public Vector3 vectorRes; //Векторная часть результирующего кватерниона В

        private void updateVectors()
        {
            vectorA = new Vector3(aVecX, aVecY, aVecZ); //Обновление вектора А
            vectorB = new Vector3(bVecX, bVecY, bVecZ); //Обновление вектора В
        }

        public void quantSum()
        {
            updateVectors(); //Обновление векторов
            resQuantReal = aQuantReal + bQuantReal; //Сумма реальных частей
            vectorRes = Vector3.Add(vectorA, vectorB); //Сумма векторов
        }

        public void quantSubstr()
        {
            updateVectors(); //Обновление векторов
            resQuantReal = aQuantReal - bQuantReal; //Вычитание реальных частей
            vectorRes = Vector3.Subtract(vectorA, vectorB); //Выычитание векторов
        }

        public void quantMult()
        {
            updateVectors(); //Обновление векторов
            resQuantReal = aQuantReal * bQuantReal - (float)Vector3.Dot(vectorA, vectorB); //Произведение реальной части
            vectorRes = Vector3.Cross(vectorA, vectorB) + Vector3.Multiply(bQuantReal, vectorA); //Произведение векторов
        }

        public void quantDiv()
        {
            updateVectors(); //Обновление векторов
            float norm2 = aQuantReal * aQuantReal + vectorB.X * vectorB.X + vectorB.Y * vectorB.Y + vectorB.Z * vectorB.Z; //Нахождение нормы
            vectorB = Vector3.Divide(-vectorB, norm2); //Обратный вектор
            resQuantReal = aQuantReal * bQuantReal - (float)Vector3.Dot(vectorA, vectorB); //Частное реальной части
            vectorRes = Vector3.Cross(vectorA, vectorB) + Vector3.Multiply(aQuantReal, vectorB) + Vector3.Multiply(bQuantReal, vectorA); //Умножение вектора на обратный
        }
    }

    public class moduleCalc
    {
        public int aMod, bMod, nMod; //Числа по модулю N
        public int res; //Результат

        public void modSum()
        {
            res = (aMod + bMod) % nMod; //Сумма
        }

        public void modSubstr()
        {
            res = (aMod + nMod - bMod) % nMod; //Вычитание
        }

        public void modMult()
        {
            res = (aMod * bMod) % nMod; //Произведение
        }

        public void modDiv()
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