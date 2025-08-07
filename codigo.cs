using System;

class CalculadoraString
{
    static void Main()
    {
        Console.WriteLine("Calculadora solo con string");
        Console.Write("Escribe el primer numero: ");
        string num1 = Console.ReadLine();

        Console.Write("Escribe el segundo numero: ");
        string num2 = Console.ReadLine();

        Console.Write("Operacion? (+, -, *, /): ");
        string op = Console.ReadLine();

        string resultado = "";

        if (op == "+")
        {
            int r = Convert.ToInt32(num1) + Convert.ToInt32(num2);
            resultado = r.ToString();
        }
        else if (op == "-")
        {
            int r = Convert.ToInt32(num1) - Convert.ToInt32(num2);
            resultado = r.ToString();
        }
        else if (op == "*")
        {
            int r = Convert.ToInt32(num1) * Convert.ToInt32(num2);
            resultado = r.ToString();
        }
        else if (op == "/")
        {
            if (num2 == "0")
            {
                resultado = "no puedes dividir por cero";
            }
            else
            {
                int r = Convert.ToInt32(num1) / Convert.ToInt32(num2);
                resultado = r.ToString();
            }
        }
        else
        {
            resultado = "operacion no valida, checa el simbolo";
        }

        Console.WriteLine("Resultado : " + resultado);
    }
}
