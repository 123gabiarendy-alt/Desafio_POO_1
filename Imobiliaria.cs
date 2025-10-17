#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;

public class Imobiliaria 
{
    private readonly List<Imovel> imoveis = [];
    private int proximoId = 1;

    //metodos 
    // 1 Cadastrar Imóvel

    public void CadastrarImovel() 
    {
        Console.WriteLine("Cadastro de imóvel");
        Console.Write("Tipo (1- Casa, 2- Apartamento): ");
        string tipo = Console.ReadLine();
        

        Console.Write("Endereço (Rua/Avenida): ");
        string endereco = Console.ReadLine();
        Console.Write("Numero: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("\n-- Dados do Proprietário --");
        Console.Write("Nome: ");
        string nomeProprietario = Console.ReadLine();
        Console.Write("CPF: ");
        string cpfProprietario = Console.ReadLine();
        Console.Write("Telefone: ");
        string telefoneProprietario = Console.ReadLine();
        Proprietario proprietario = new Proprietario(nomeProprietario, cpfProprietario, telefoneProprietario);

        if(tipo == "1")
        {
            imoveis.Add(new Casa(proximoId, endereco, numero, proprietario));
        }
        else if (tipo == "2")
        {
            imoveis.Add(new Apartamento(proximoId, endereco, numero, proprietario));

        }
        else
        {
            Console.WriteLine("Tipo inválido");
            return;
        }
        proximoId++;
        Console.WriteLine("\nImóvel cadastrado com sucesso!");    
    }

    // 2- Listar Imóveis 
    public void ListarImoveis()
    {
        Console.WriteLine("\n--- Lista de Imóveis Cadastrados ---");
        if (!imoveis.Any())
        {
            Console.WriteLine("Nenhum imóvel cadastrado. ");
            return;
        }
        foreach (var imovel in imoveis)
        {
            string tipo;
            if(imovel is Casa)
            {
                tipo = "Casa";
            }
            else
            {
                tipo = "Apartamento";
            }

            Console.WriteLine($"\nID: {imovel.Id} | Tipo: {tipo}");
            Console.WriteLine($"Endereço: {imovel.Endereco}, {imovel.Numero}");
            Console.WriteLine($"Status: {imovel.ObterStatusAluguel()}");
            Console.WriteLine($"Proprietário: {imovel.Proprietario.ContatoProprietario()}");



        }
    }   

    // 3. Alugar Imóvel
    public void AlugarImovel()
    {
        Console.Write("Digite o ID do imóvel para alugar: ");
        int id = int.Parse(Console.ReadLine());
        var imovel = imoveis.FirstOrDefault(i => i.Id == id);
        if (imovel != null)
        {
            imovel.Alugar();
        }
        else
        {
            Console.WriteLine("Imóvel não encontrado :( .");
        }
    }

    // 4- Disponibilizar Imóvel
    public void  DisponibilizarImovel()
    {
        Console.Write("Digite o ID do imóvel para disponibilizá-lo: ");
        int id = int.Parse(Console.ReadLine());
        var imovel = imoveis.FirstOrDefault(i => i.Id == id);
        if (imovel != null)
        {
            imovel.Disponibilizar();
        }
        else
        {
            Console.WriteLine("Imóvel não encontrado :( .");
        }
    } 
    //5. Calcular o valor do aluguel por período
    public void CalcularValorAluguel()
    {
        Console.Write("Digite o ID do imóvel: ");
        int id = int.Parse(Console.ReadLine());
        var imovel = imoveis.FirstOrDefault(i => i.Id == id);
        if (imovel != null)
        {
            Console.Write("Digite a quantidade de dias: ");
            int dias = int.Parse(Console.ReadLine());
            double valor = imovel.CalcularAluguel(dias);
            Console.WriteLine($"O valor do aluguel por {dias} dias é: R$ {valor:F2}");
        }
        else
        {
            Console.WriteLine("Imóvel não encontrado :( .");
        }
    }
    //Excluir imóvel 
    public void ExcluirImovel()
    {
        Console.Write("Digite o ID do imóvel para excluir: ");
        int id = int.Parse(Console.ReadLine());
        var imovel = imoveis.FirstOrDefault(i => i.Id == id);
        if (imovel != null)
        {
            imoveis.Remove(imovel);
            Console.WriteLine("Imóvel excluído com sucesso!");
            int dias = int.Parse(Console.ReadLine());
            double valor = imovel.CalcularAluguel(dias);
            Console.WriteLine($"O valor do aluguel por {dias} dias é: R$ {valor:F2}");
        }
        else
        {
            Console.WriteLine("Imóvel não encontrado :( .");
        }
    }

}