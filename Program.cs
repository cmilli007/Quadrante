double x, y;
string ponto;

Console.WriteLine("--Qual o quadrante do seu valor no Plano Cartesiano?--");

Console.WriteLine("Digite o ponto desejado:");

Console.Write("Digite a coordenada x: ");
x = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a coordenada y: ");
y = Convert.ToDouble(Console.ReadLine());

if (x == 0 && y == 0) ponto = "eixo inicial";
else if (x == 0) ponto = "o eixo das ordenadas";
else if (y == 0) ponto = "o eixo das abscissas";
else if (y > 0)
{
    if (x > 0)
        ponto = "o quadrante 1";
    else
        ponto = "o quadrante 2";
}
else
{
    if (x < 0)
        ponto = "o quadrante 3";
    else
        ponto = "o quadrante 4";
}

Console.WriteLine($"\nO ponto ({x}, {y}) fica n{ponto}.");
