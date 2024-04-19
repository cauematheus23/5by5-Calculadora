float n1, n2, n3,n4,res;
int c;
Console.Write("Digite o primeiro numero: ");
n1 = float.Parse(Console.ReadLine());
do
{
    Console.WriteLine("Digite um valor para n2 que seja diferente de 0");
    n2 = float.Parse(Console.ReadLine());
} while (n2 == 0);
do
{
    Console.WriteLine("Digite um valor para n3 que seja diferente de 0");
    n3 = float.Parse(Console.ReadLine());
} while (n3 == 0);
do
{
    Console.WriteLine("Digite um valor para n4 que seja diferente de 0");
    n4 = float.Parse(Console.ReadLine());
} while (n3 == 0);
c = 1;
while (c != 0)
{
    Console.WriteLine("\nEscolha  uma opção\n \n[1]Soma\n[2]Subtração\n[3]Multiplicação\n[4]Divisao\n[5]Escolher numeros\n[0]Sair");
    c = int.Parse(Console.ReadLine());
    if (c == 1)
    {
        res = n1 + n2 + n3 + n4;
        Console.WriteLine($"{n1} + {n2} + {n3} + {n4} = {res}");
    }
    else if (c == 2)
    {
        res = n1 - n2 - n3 - n4;
        Console.WriteLine($"{n1} - {n2} - {n3} - {n4} = {res}");
    }
    else if (c == 3)
    {
        res = n1 * n2 * n3 * n4;
        Console.WriteLine($"{n1} * {n2} * {n3} * {n4} = {res}");
    }
    else if (c == 4)
    {
        res = n1 / n2 /n3 /n4;
        Console.WriteLine($"{n1} / {n2} / {n3} / {n4} = {res}");
    }
    else if (c == 0)
    {
        break;
    }
    else if (c == 5)
    {
        Console.Write("Digite o primeiro numero: ");
        n1 = float.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine("Digite um valor para n2 que seja diferente de 0");
            n2 = float.Parse(Console.ReadLine());
        } while (n2 == 0);
        do
        {
            Console.WriteLine("Digite um valor para n3 que seja diferente de 0");
            n3 = float.Parse(Console.ReadLine());
        } while (n3 == 0);
        do
        {
            Console.WriteLine("Digite um valor para n4 que seja diferente de 0");
            n4 = float.Parse(Console.ReadLine());
        } while (n3 == 0);
    }
    else
    {
        Console.WriteLine("Valor invalido, digite um  valor entre 0 e 5");
    }
}