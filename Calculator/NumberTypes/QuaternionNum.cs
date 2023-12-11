using System.Numerics;


namespace Calculator
{
    struct QuaternionNumber
    {
        public float real;
        public Vector3 vector;

        public QuaternionNumber(float real = 0, float vecX = 0, float vecY = 0, float vecZ = 0)
        {
            this.real = real;
            this.vector = new Vector3(vecX, vecY, vecZ);
        }
    }

    public class QuaternionNum : CalcInterface
    {
        private QuaternionNumber quatA;
        private QuaternionNumber quatB;
        private QuaternionNumber quatRes;

        public QuaternionNum()
        {
            this.quatA = new QuaternionNumber();
            this.quatB = new QuaternionNumber();
        }

        public QuaternionNum(float realA, float aVecX, float aVecY, float aVecZ,
            float realB, float bVecX, float bVecY, float bVecZ)
        {
            this.quatA = new QuaternionNumber(realA, aVecX, aVecY, aVecZ);
            this.quatB = new QuaternionNumber(realB, bVecX, bVecY, bVecZ);
        }

        public void getRes(out float real, out Vector3 vector)
        {
            real = quatRes.real;
            vector = quatRes.vector;
        }
        /// <summary>
        /// Метод суммирования кватернионов: A(д)+B(д)=C(д); A(вектор)+B(вектор)=C(вектор)
        /// </summary>
        public void findSum()
        {
            quatRes.real = quatA.real + quatB.real; //Сумма реальных частей
            quatRes.vector = Vector3.Add(quatA.vector, quatB.vector); //Сумма векторов
        }
        /// <summary>
        /// Метод вычитания кватернионов: A(д)-B(д)=C(д); A(вектор)-B(вектор)=C(вектор)
        /// </summary>
        public void findSubstr()
        {
            quatRes.real = quatA.real - quatB.real; //Вычитание реальных частей
            quatRes.vector = Vector3.Subtract(quatA.vector, quatB.vector); //Выычитание векторов
        }
        /// <summary>
        /// Метод умножения кватернионов: A(д)+B(д)-(A(вектор)+B(вектор))=C(д); 
        /// [A(вектор)*B(вектор)]+B(д)*A(вектор)=C(вектор)
        /// </summary>
        public void findMult()
        {
            quatRes.real = quatA.real * quatB.real - (float)Vector3.Dot(quatA.vector, quatB.vector); //Произведение реальной части
            quatRes.vector = Vector3.Cross(quatA.vector, quatB.vector) + Vector3.Multiply(quatB.real, quatA.vector)
                + Vector3.Multiply(quatA.real, quatB.vector); //Произведение векторов
        }
        /// <summary>
        /// Метод деления кватернионов (умножение на обратный вектор)
        /// норма = A(д)^2+B(вектор-x)^2+B(вектор-y)^2+B(вектор-z)^2
        /// B(вектор, обратный) = (-B(вектор)*норма)
        /// Далее операция производится аналогично умножению
        /// </summary>
        public void findDiv()
        {
            float norm2 = quatA.real * quatA.real + quatB.vector.X * quatB.vector.X +
                            + quatB.vector.Y * quatB.vector.Y + quatB.vector.Z * quatB.vector.Z; //Нахождение нормы
            Vector3 invVectorB = Vector3.Divide(-quatB.vector, norm2); //Обратный вектор
            quatRes.real = quatA.real * quatB.real - (float)Vector3.Dot(quatA.vector, quatB.vector); //Частное реальной части
            quatRes.vector = Vector3.Cross(quatA.vector, invVectorB) + Vector3.Multiply(quatA.real, invVectorB) +
                Vector3.Multiply(quatB.real, quatA.vector); //Умножение вектора на обратный
        }
    }
}