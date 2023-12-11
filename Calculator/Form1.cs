using System;
using System.Numerics;
using System.Windows.Forms;

namespace Calculator
{
    /// <summary>
    /// Класс формы, открывающейся при запуске калькулятора.
    /// Содержит методы, обрабатывающие события "нажатие кнопки".
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Экземпляр класса для работы с действительными числами.
        /// Действительное число - числа, которые могут быть записаны в виде конечной или бесконечной десятичной дроби.
        /// </summary>
        RealNum realnumCalc = new RealNum(); 
        /// <summary>
        /// Экземпляр класса для работы с комплексными числами.
        /// Комплексные числа - числа вида a+ib, где a - вещественная часть, b - множитель при мнимой единице i.
        /// </summary>
        ComplexNum complexnumCalc = new ComplexNum();
        /// <summary>
        /// Экземпляр класса для работы с кватернионами.
        /// Кватернионы — система гиперкомплексных чисел, образующая векторное пространство с размерностью 4 над полем вещественных чисел.
        /// </summary>
        QuaternionNum quatnumCalc = new QuaternionNum();
        /// <summary>
        /// Экземпляр класса для работы с числами по модулю N.
        /// Число по модулю N - выражение типа M(mod N) равняющееся остатку от деления M на N.
        /// </summary>
        ModNum modnumCalc = new ModNum();

        /// <summary>
        /// Инициализация формы.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод получения значений действительных чисел A и B из соответствующих полей.
        /// После получения значений они конвертируются в формат double.
        /// Если значения неверны - пользователь получит сообщение об ошибке.
        /// </summary>
        private void realGetNumbers()
        {
            try
            {
                realnumCalc = new RealNum(Convert.ToDouble(realA.Text), Convert.ToDouble(realB.Text)); //Получение значений из полей 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Если значение в полях некорректно - уведомляем пользователя
            }
        }
        /// <summary>
        /// Метод обновления значения поля "Результат". Вызывается после проведения вычислений.
        /// </summary>
        private void updateRealRes()
        {
            realRes.Text = Convert.ToString(realnumCalc.getRes()); //Обновление значения в поле результата
        }
        /// <summary>
        /// Метод обработки события "Нажата кнопка "Сумма" на вкладке "Действительные числа".
        /// Производится сложение действительных чисел, вызывается метод обновления значения в поле "Результат".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void realSum_Click(object sender, EventArgs e)
        {
            realGetNumbers(); //Получение значений из полей
            realnumCalc.findSum(); //Сумма действительных
            updateRealRes(); //Обновление значения поля результата 
        }
        /// <summary>
        /// Метод обработки события "Нажата кнопка "Разность" на вкладке "Действительные числа".
        /// Производится вычитание действительных чисел, вызывается метод обновления значения в поле "Результат".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void realSubstr_Click(object sender, EventArgs e)
        {
            realGetNumbers(); //Получение значений из полей
            realnumCalc.findSubstr(); //Вычитание действительных
            updateRealRes(); //Обновление значения поля результата 
        }
        /// <summary>
        /// Метод обработки события "Нажата кнопка "Произведение" на вкладке "Действительные числа".
        /// Производится умножение действительных чисел, вызывается метод обновления значения в поле "Результат".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void realMult_Click(object sender, EventArgs e)
        {
            realGetNumbers(); //Получение значений из полей
            realnumCalc.findMult(); //Произведение действительных
            updateRealRes(); //Обновление значения поля результата 
        }
        /// <summary>
        /// Метод обработки события "Нажата кнопка "Частное" на вкладке "Действительные числа".
        /// Производится деление действительных чисел, вызывается метод обновления значения в поле "Результат".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void realDiv_Click(object sender, EventArgs e)
        {
            realGetNumbers(); //Получение значений из полей
            realnumCalc.findDiv(); //Частное действительных
            updateRealRes(); //Обновление значения поля результата 
        }
        /// <summary>
        /// Метод получения действительных и мнимых частей комплексных чисел A и B из соответствующих полей.
        /// После получения значений все части чисел конвертируются в формат double.
        /// Если значения неверны - пользователь получит сообщение об ошибке.
        /// </summary>
        private void complexGetNum()
        {
            try
            {
                complexnumCalc = new ComplexNum(Convert.ToDouble(complexRealA.Text), Convert.ToDouble(complexImgA.Text),
                    Convert.ToDouble(complexRealB.Text), Convert.ToDouble(complexImgB.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Если значение в поле некорректно - уведомляем пользователя
            }
        }
        /// <summary>
        /// Метод обновления значения поля "Результат" для комплексных чисел. Вызывается после проведения вычислений.
        /// </summary>
        private void updateComplexRes()
        {
            double bufReal, bufImg;
            complexnumCalc.getRes(out bufReal, out bufImg);
            complexRealRes.Text = Convert.ToString(bufReal); //Обновление значения в поле реальной части результата
            complexImgRes.Text = Convert.ToString(bufImg); //Обновление значения в поле мнимой части результата
        }
        /// <summary>
        /// Метод обработки события "Нажата кнопка "Сумма" на вкладке "Комплексные числа".
        /// Производится сложение комплексных чисел, вызывается метод обновления значений в поле "Результат".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void complexSum_Click(object sender, EventArgs e)
        {
            complexGetNum(); //Получение значений из полей
            complexnumCalc.findSum(); //Сумма комплексных
            updateComplexRes(); //Обновление значения поля результата 
        }
        /// <summary>
        /// Метод обработки события "Нажата кнопка "Разность" на вкладке "Комплексные числа".
        /// Производится вычитание комплексных чисел, вызывается метод обновления значений в поле "Результат".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void complexSubstr_Click(object sender, EventArgs e)
        {
            complexGetNum(); //Получение значений из полей
            complexnumCalc.findSubstr(); //Вычитание комплексных
            updateComplexRes(); //Обновление значения поля результата 
        }
        /// <summary>
        /// Метод обработки события "Нажата кнопка "Произведение" на вкладке "Комплексные числа".
        /// Производится умножение комплексных чисел, вызывается метод обновления значений в поле "Результат".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void complexMult_Click(object sender, EventArgs e)
        {
            complexGetNum(); //Получение значений из полей
            complexnumCalc.findMult(); //Произведение комплексных
            updateComplexRes(); //Обновление значения поля результата 
        }
        /// <summary>
        /// Метод обработки события "Нажата кнопка "Частное" на вкладке "Комплексные числа".
        /// Производится деление комплексных чисел, вызывается метод обновления значений в поле "Результат".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void complexDiv_Click(object sender, EventArgs e)
        {
            complexGetNum(); //Получение значений из полей
            complexnumCalc.findDiv(); //Частное комплексных
            updateComplexRes(); //Обновление значения поля результата 
        }
        /// <summary>
        /// Метод обновления значения полей "Результат" для кватернионов. Вызывается после проведения вычислений.
        /// </summary>
        private void updatequatRes()
        {
            float bufReal;
            Vector3 bufVector;
            quatnumCalc.getRes(out bufReal, out bufVector);

            quatRealRes.Text = Convert.ToString(bufReal); //Обновление значения в поле реальной части результата
            quatVecXRes.Text = Convert.ToString(bufVector.X); //Обновление значения в поле X-координаты части результата
            quatVecYRes.Text = Convert.ToString(bufVector.Y); //Обновление значения в поле Y-координаты части результата
            quatVecZRes.Text = Convert.ToString(bufVector.Z); //Обновление значения в поле Z-координаты части результата
        }
        /// <summary>
        /// Метод получения векторных и действительных частей кватернионов A и B из соответствующих полей.
        /// После получения значений все части чисел конвертируются в формат float (single).
        /// Если значения неверны - пользователь получит сообщение об ошибке.
        /// </summary>
        public void quatGetNum()
        {
            try
            {
                quatnumCalc = new QuaternionNum(Convert.ToSingle(quatRealA.Text), Convert.ToSingle(quatVecXA.Text),
                    Convert.ToSingle(quatVecYA.Text), Convert.ToSingle(quatVecZA.Text), Convert.ToSingle(quatRealB.Text),
                    Convert.ToSingle(quatVecXB.Text), Convert.ToSingle(quatVecYB.Text), Convert.ToSingle(quatVecZB.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Если значение в поле некорректно - уведомляем пользователя
            }
        }
        /// <summary>
        /// Метод обработки события "Нажата кнопка "Сумма" на вкладке "Кватернионы".
        /// Производится сложение кватернионов, вызывается метод обновления значений в полях типа "Результат". 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quatSum_Click(object sender, EventArgs e)
        {
            quatGetNum(); //Получение значений из полей
            quatnumCalc.findSum(); //Сумма кватернионов
            updatequatRes(); //Обновление значения поля результата 
        }
        /// <summary>
        /// Метод обработки события "Нажата кнопка "Разность" на вкладке "Кватернионы".
        /// Производится вычитание кватернионов, вызывается метод обновления значений в полях типа "Результат". 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quatSubstr_Click(object sender, EventArgs e)
        {
            quatGetNum(); //Получение значений из полей
            quatnumCalc.findSubstr(); //Вычитание кватернионов
            updatequatRes(); //Обновление значения поля результата 
        }
        /// <summary>
        /// Метод обработки события "Нажата кнопка "Произведение" на вкладке "Кватернионы".
        /// Производится умножение кватернионов, вызывается метод обновления значений в полях типа "Результат". 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quatMult_Click(object sender, EventArgs e)
        {
            quatGetNum(); //Получение значений из полей
            quatnumCalc.findMult(); //Произведение кватернионов
            updatequatRes(); //Обновление значения поля результата 
        }
        /// <summary>
        /// Метод обработки события "Нажата кнопка "Частное" на вкладке "Кватернионы".
        /// Производится деление кватернионов, вызывается метод обновления значений в полях типа "Результат". 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quatDiv_Click(object sender, EventArgs e)
        {
            quatGetNum(); //Получение значений из полей
            quatnumCalc.findDiv(); //Частное кватернионов
            updatequatRes(); //Обновление значения поля результата 
        }
        /// <summary>
        /// Метод получения значений чисел A,B и модуля N из соответствующих полей.
        /// После все значения чисел конвертируются в формат int.
        /// Если значения неверны - пользователь получит сообщение об ошибке.
        /// </summary>
        private void modGetNum()
        {
            try
            {
                modnumCalc = new ModNum(Convert.ToInt32(modNumA.Text), Convert.ToInt32(modNumB.Text),
                    Convert.ToInt32(modNumN.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Если значение в поле некорректно - уведомляем пользователя
            }
        }
        /// <summary>
        /// Метод обновления значения поля "Результат" для чисел по модулю N. Вызывается после проведения вычислений.
        /// </summary>
        private void updateMouleRes()
        {
            modRes.Text = Convert.ToString(modnumCalc.getRes()); //Обновление результата в поле
        }
        /// <summary>
        /// Метод обработки события "Нажата кнопка "Сумма" на вкладке "Числа по модулю N".
        /// Производится сложение чисел по модулю, вызывается метод обновления значения в поле "Результат". 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modSum_Click(object sender, EventArgs e)
        {
            modGetNum(); //Получение значений из полей
            modnumCalc.findSum(); //Сумма чисел по модулю
            updateMouleRes(); //Обновление результата
        }
        /// <summary>
        /// Метод обработки события "Нажата кнопка "Разность" на вкладке "Числа по модулю N".
        /// Производится вычитание чисел по модулю, вызывается метод обновления значения в поле "Результат". 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modSubstr_Click(object sender, EventArgs e)
        {
            modGetNum(); //Получение значений из полей
            modnumCalc.findSubstr(); //Вычитание чисел по модулю
            updateMouleRes(); //Обновление результата
        }
        /// <summary>
        /// Метод обработки события "Нажата кнопка "Произведение" на вкладке "Числа по модулю N".
        /// Производится умножение чисел по модулю, вызывается метод обновления значения в поле "Результат". 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modMult_Click(object sender, EventArgs e)
        {
            modGetNum(); //Получение значений из полей
            modnumCalc.findMult(); //Произведение чисел по модулю
            updateMouleRes(); //Обновление результата
        }
        /// <summary>
        /// Метод обработки события "Нажата кнопка "Частное" на вкладке "Числа по модулю N".
        /// Производится деление чисел по модулю, вызывается метод обновления значения в поле "Результат". 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modDiv_Click(object sender, EventArgs e)
        {
            modGetNum(); //Получение значений из полей
            modnumCalc.findDiv(); //Частное чисел по модулю
            updateMouleRes(); //Обновление результата
        }
    }
}