class Program
{
    static void Main()
    {
        List<Produto> produtos = new List<Produto>();

        int opcao;

        do
        {
            Console.WriteLine("\n1.Cadastrar produto");
            Console.WriteLine("2.Listar produtos");
            Console.WriteLine("3.Calcular valor do estoque");
            Console.WriteLine("4.Encerrar sistema");
            Console.WriteLine("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite seu nome: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Digite o preço do produto: ");
                    decimal preco = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Quantidade em estoque: ");
                    int quantidade = int.Parse(Console.ReadLine());

                    if (string.IsNullOrWhiteSpace(nome))
                    {
                        Console.WriteLine("Nome inválido.");
                    }
                    else if (preco < 0)
                    {
                        Console.WriteLine("Preço inválido");
                    }
                    else if (quantidade < 0)
                    {
                        Console.WriteLine("Quantidade inválida");
                    }
                    else
                    {
                        Produto produto = new Produto
                        {
                            Nome = nome,
                            Preco = preco,
                            Quantidade = quantidade
                        };

                        produtos.Add(produto);

                        Console.WriteLine("Produto cadastrado com sucesso");

                    }
                    break;

                case 2:
                    if (produtos.Count == 0)
                    {
                        Console.WriteLine("Não há produtos cadastrados");
                    }
                    else
                    {
                        foreach (Produto produto1 in produtos)
                        {
                            Console.WriteLine($"Nome: {produto1.Nome}");
                            Console.WriteLine($"Preço: R$ {produto1.Preco:F2}");
                            Console.WriteLine($"Quantidade: {produto1.Quantidade}");
                        }
                    }
                    break;

                case 3:
                    if (produtos.Count == 0)
                    {
                        Console.WriteLine("Não há produtos cadastrados");
                    }
                    else
                    {
                        foreach (Produto produto1 in produtos)
                        {
                            decimal valorEstoque = produto1.Preco * produto1.Quantidade;
                            Console.WriteLine($"{produto1.Nome}: R$ {valorEstoque:F2}");
                        }
                    }
                    break;


                case 4:
                    Console.WriteLine("Saindo do sistema...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != 4);

        Console.WriteLine("Sistema finalizado");
    }
}