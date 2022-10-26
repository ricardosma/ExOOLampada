// See https://aka.ms/new-console-template for more information
/*Console.BackgroundColor = ConsoleColor.Cyan;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Hello, World!");
Console.Write("teste");
Console.ReadLine();*/

using ExOO;
Lampada l = new Lampada();
Console.WriteLine("Digite a marca da lampada: ");
l.marca = Console.ReadLine();
Console.WriteLine("Digite a potência da lampada: ");
l.potencia = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a cor da lampada: ");
l.cor = Console.ReadLine();
Console.WriteLine("Digite 1 para ligar a lampada ou 0 para desligar: ");
int op = int.Parse(Console.ReadLine());
if (op == 1)
{
    l.ligada = true;
}
else
{
    l.ligada = false;
}

while (true)
{
    Console.WriteLine("Digite 1 para mudar a cor da lâmpada: ");
    Console.WriteLine("Digite 2 para desligar a lâmpada: ");
    Console.WriteLine("Digite 3 para ligar a lâmpada: ");
    Console.WriteLine("Digite 4 para apresentar os dados da lâmpada: ");
    Console.WriteLine("Digite 5 para sair do programa: ");

    op = int.Parse(Console.ReadLine());
    if(op == 1)
    {
        Console.WriteLine("Digite a nova cor da lampada: ");
        string nvcor = Console.ReadLine();
        l.mudaCor(nvcor);
        Console.Clear();
    }
    else if(op == 2)
    {
        Console.Clear();
        l.desligaLampada();

    }
    else if(op == 3)
    {
        Console.Clear();
        l.ligaLampada();
    }
    else if(op == 4)
    {
        Console.Clear();
        l.apresentaDados();

    }
    else if (op == 5)
    {
        break;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Toma tenecia e digita um valor correto!");
    }

}





l.ligaLampada();
l.apresentaDados();






