/* --- FUNÇÕES --- */

// Funções que respondem

string retornaCumprimento()
{
    string mensagem = "Oi";

    return mensagem;
}

Console.WriteLine(retornaCumprimento());

// Funções que não respondem 

void cumprimentarComTerminal() 
{
    Console.WriteLine("Olá!");
}

cumprimentarComTerminal();

/* --- CONDICIONAIS --- */

// Switch...Case...Break...Default

int indiceDoDiaDaSemana = 6;

switch (indiceDoDiaDaSemana)
{
    case 0:
        Console.WriteLine("Domingo");
        break;
    case 1:
        Console.WriteLine("Segunda");
        break;
    case 2:
        Console.WriteLine("Terça");
        break;
    case 3:
        Console.WriteLine("Quarta");
        break;
    case 4:
        Console.WriteLine("Quinta");
        break;
    case 5:
        Console.WriteLine("Sexta");
        break;
    case 6:
        Console.WriteLine("Sábado");
        break;
    default:
        Console.WriteLine("Valor informado não é válido.");
        break;
}

Console.WriteLine("n\n\n");

/* DESAFIO 01 */

// FUNÇÃO CALCULA IMC

string retornaDiagnosticoIMC(double alturaDoUsuario, double pesoDoUsuario) 
{
    string resultado = "";

    double IMC = pesoDoUsuario / (alturaDoUsuario * alturaDoUsuario);

    if (IMC >= 40) 
    {
        resultado = "Obesidade grave";
    }
    else if (IMC >= 30 && IMC < 40) 
    {
        resultado = "Obesidade";
    }
    else if (IMC >= 25 && IMC < 30) 
    {
        resultado = "Sobrepeso";
    }
    else if (IMC >= 18.5 && IMC < 25) 
    {
        resultado = "Normal";
    }
    else 
    {
        resultado = "Anêmico";
    }

    return resultado;
}

// MAIN
Console.WriteLine("Olá!");
Console.Write("Por favor, insira sua altura (m): ");

double altura = Convert.ToDouble(Console.ReadLine());

Console.Write("Por favor, insira o seu peso (kg): ");

double peso = Convert.ToDouble(Console.ReadLine());;

Console.WriteLine($"Seu diagnóstico é: {retornaDiagnosticoIMC(altura, peso)}");
