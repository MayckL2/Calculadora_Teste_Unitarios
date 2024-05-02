using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Console.Controllers
{
    public class CalculadoraController
    {
        private List<string> _historico = new List<string>();

        // Realiza calculo de somar
        public float Somar(float num1, float num2)
        {
            float result = num1 + num2;
            _historico.Add($"{num1} + {num2} = {result}");
            return result;
        }

        // Realiza calculo de subtrair
        public float Subtrair(float num1, float num2)
        {
            float result = num1 - num2;
            _historico.Add($"{num1} - {num2} = {result}");
            return result;
        }

        // Realiza calculo de multiplicar
        public float Multiplicar(float num1, float num2)
        {
            float result = num1 * num2;
            _historico.Add($"{num1} x {num2} = {result}");
            return result;
        }

        // Realiza calculo de divisão
        public float Dividir(float num1, float num2)
        {
            float result = num1 / num2;
            _historico.Add($"{num1} / {num2} = {result}");
            return result;
        }

        // Retorna os 3 ultimos calculos salvos no historico
        public List<string> Historico()
        {
            _historico.RemoveRange(3, _historico.Count - 3);
            return _historico;
        }
    }
}
