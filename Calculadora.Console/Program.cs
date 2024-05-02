using Calculadora.Console.Controllers;

CalculadoraController calculadora = new CalculadoraController();

Console.WriteLine(calculadora.Somar(2, 2));
Console.WriteLine(calculadora.Subtrair(2, 2));
Console.WriteLine(calculadora.Multiplicar(2, 2));
Console.WriteLine(calculadora.Dividir(2, 2));

List<string> list = calculadora.Historico();
foreach (var item in list)
{
    Console.WriteLine(item);
}