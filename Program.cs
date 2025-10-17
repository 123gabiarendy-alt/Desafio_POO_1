using System;

class Program
{
    public static void Main(strings[] args)
    {
        Imobiliaria imobiliaria = new Imobiliaria();
        bool executando = true;

        Console.WriteLine("Bem-vindo ao Sistema dde Gestão da Imobiliaria Bons Sonhos! ");
        while (executando)
        {
            Console.WriteLine("\n------------ MENU PRINCIPAL --------------");
            Console.WriteLine("1. Cadastrar Imóvel");
            Console.WriteLine("2. Listar Imóvel");
            Console.WriteLine("3. Alugar Imóvel");
            Console.WriteLine("4. Disponibilizar Imóvel");
            Console.WriteLine("5. Calcular valor do aluguel");
            Console.WriteLine("6. Excluir Imóvel");
            Console.WriteLine("7. Sair");
            Console.Write("Escolha uma opção: ")

            string opcao = Console.ReadLine();
            Console.Clear();

            try
            {
                switch (opcao)
                {
                    case "1":
                        imobiliaria.CadastrarImovel();
                        break;
                    case "2":
                        imobiliaria.ListarImoveis();
                        break;
                    case "3":
                        imobiliaria.AlugarImovel();
                        break;
                    case "4":
                        imobiliaria.DisponibilizarImovel();
                        break;
                    case "5":
                        imobiliaria.CalcularValorAluguel();
                        break;
                    case "6":
                        imobiliaria.ExcluirImovel();
                        break;

                    case "7": 
                        executando = false;
                        Console.WriteLine("Saindo do sistema...")    
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");  
                        break;  

                }
            }
            catch (Format.Exception)
            {
                Console.WriteLine("Erro: Entrada inválida. Por favor, digite um número quando solicitado.");   
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");   
                
            }

            if (executando)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }    
    }
}