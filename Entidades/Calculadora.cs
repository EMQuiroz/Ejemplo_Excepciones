namespace Entidades
{
    public static class Calculadora
    {
        public static int Sumar(string operandoA,string operandoB)
        {
            int numA = int.Parse(operandoA);
            int numB = int.Parse(operandoB);

            return numA + numB;
        }

        public static int Restar(string operandoA, string operandoB)
        {
            int numA = int.Parse(operandoA);
            int numB = int.Parse(operandoB);

            return numA - numB;
        }

        public static int Dividir(string operandoA, string operandoB)
        {
            int numA = int.Parse(operandoA);
            int numB = int.Parse(operandoB);

            return numA / numB;
        }

        public static int Multiplicar(string operandoA, string operandoB)
        {
            int numA = int.Parse(operandoA);
            int numB = int.Parse(operandoB);

            return numA * numB;
        }


    }
}