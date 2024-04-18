float n1, n2, sum, sub, mul, div;
int c;
Console.Write("Digite o primeiro numero: ");
n1 = float.Parse(Console.ReadLine());
Console.Write("Digite o segundo numero: ");
n2 = float.Parse(Console.ReadLine());
c = 1;
while (c != 0)
{
    Console.WriteLine("\nEscolha  uma opção\n \n[1]Soma\n[2]Subtração\n[3]Multiplicação\n[4]Divisao\n[5]Escolher novos numeros\n[0]Sair");
    c = int.Parse(Console.ReadLine());
    if (c == 1)
    {
        sum = n1 + n2;
        Console.WriteLine($"{n1} + {n2} = {sum}");
    }
    else if (c == 2)
    {
        sub = n1 - n2;
        Console.WriteLine($"{n1} - {n2} = {sub}");
    }
    else if (c == 3)
    {
        mul = n1 * n2;
        Console.WriteLine($"{n1} * {n2} = {mul}");
    }
    else if (c == 4)
    {
        if (n2 == 0) // && and, || or
        {
            do
            {
                Console.WriteLine("Impossivel dividir por 0");
                Console.WriteLine("Digite um  novo valor para n2");
                n2 = float.Parse(Console.ReadLine());
            } while (n2 == 0);

        }
        div = n1 / n2;
        Console.WriteLine($"{n1} / {n2} = {div}");
    }
    else if (c == 0)
    {
        break;
    }
    else if (c == 5)
    {
        Console.WriteLine("Digite o primeiro numero: ");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        n2 = float.Parse(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Valor invalido, digite um  valor entre 0 e 5");
    }
}