using CadastroBandasConsoleApp2026;
using System;

class Program
{
    static void addBanda(List<Banda> listaBandas)
    {
        Banda novaBanda = new Banda();
        Console.WriteLine("Entre com os dados da Banda");
        Console.Write("Nome da banda:");
        novaBanda.nome = Console.ReadLine();
        Console.Write("Genero da banda:");
        novaBanda.genero = Console.ReadLine();
        Console.Write("Integrantes da banda:");
        novaBanda.integrantes = int.Parse(Console.ReadLine());
        Console.Write("Ranking da banda:");
        novaBanda.ranking = int.Parse(Console.ReadLine());
        listaBandas.Add(novaBanda); // colocando a nova banda no vetor

    }

    static void mostrarBandas(List<Banda> listaBandas)
    {
        Console.WriteLine("*** Bandas Cadastradas ***");
        for(int  i = 0; i < listaBandas.Count; i++)
        {
            Console.WriteLine("*** Dados da Banda " + (i+1) +"***");
            Console.WriteLine($"Nome:{listaBandas[i].nome}");
            Console.WriteLine($"Genero:{listaBandas[i].genero}");
            Console.WriteLine($"Integrantes:{listaBandas[i].integrantes}");
            Console.WriteLine($"Ranking:{listaBandas[i].ranking}\n");
        }

    }

    static int menu()
    {
        Console.WriteLine("=== SISTEMA DE CADASTRO DE BANDAS ===");
        Console.WriteLine("1 - Adicionar Banda");
        Console.WriteLine("2 - Mostrar Bandas");
        Console.WriteLine("3 - Buscar Banda");
        Console.WriteLine("0 - Sair");
        Console.Write("Escolha uma opção: ");
        return int.Parse(Console.ReadLine());
    }
    static void Main()
    {
        List<Banda> listaBandas = new List<Banda>(); // vetor de bandas
        int opcao;
        do
        {
            opcao = menu();
            switch (opcao) {
                case 1: addBanda(listaBandas); 
                    break;
                case 2: mostrarBandas(listaBandas);
                    break;
                case 0: Console.WriteLine("Saindo...");
                    break;
            }// fim switch
            Console.ReadKey();
            Console.Clear();
        } while (opcao != 0);

    }// fim main

}
