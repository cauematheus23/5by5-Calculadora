float n1;
float n2;

Console.WriteLine("Digite o primeiro numero: ");
n1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
n2 = float.Parse(Console.ReadLine());

float soma = n1 + n2;
float subtracao = n1 - n2;
float multiplicacao = n1 * n2;
if (n2 == 0) // && and, || or
{
    Console.WriteLine("Impossivel dividir por 0");
}
else
{
    float divisao = n1 / n2;
    Console.WriteLine($"Soma é igual: {soma}\nSubtração é igual: {subtracao}\nMultiplicação é igual {multiplicacao}\nDivisão é igual: {divisao}");

}






