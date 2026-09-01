List<string> pessoas = new List<string>();
string opcao = "";

while (opcao != "0")
{
    Console.Clear();

    Console.WriteLine("=================================");
    Console.WriteLine("       SISTEMA DE CADASTRO");
    Console.WriteLine("=================================");
    Console.WriteLine("1 - Cadastrar pessoa");
    Console.WriteLine("2 - Listar pessoas");
    Console.WriteLine("3 - Buscar pessoa");
    Console.WriteLine("4 - Editar pessoa");
    Console.WriteLine("5 - Excluir pessoa");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("=================================");

    Console.Write("Escolha uma opção: ");
    opcao = Console.ReadLine() ?? "";

    if (opcao == "1")
    {
        Console.Clear();

        Console.WriteLine("=== CADASTRAR PESSOA ===");

        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine() ?? "";

        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("O nome não pode ficar vazio.");
        }
        else
        {
            pessoas.Add(nome);
            Console.WriteLine("Pessoa cadastrada com sucesso!");
        }

        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();
    }
    else if (opcao == "2")
    {
        Console.Clear();

        Console.WriteLine("=== PESSOAS CADASTRADAS ===");

        if (pessoas.Count == 0)
        {
            Console.WriteLine("Nenhuma pessoa cadastrada.");
        }
        else
        {
            for (int i = 0; i < pessoas.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {pessoas[i]}");
            }
        }

        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();
    }
    else if (opcao == "3")
    {
        Console.Clear();

        Console.WriteLine("=== BUSCAR PESSOA ===");

        Console.Write("Digite o nome que deseja buscar: ");
        string busca = Console.ReadLine() ?? "";

        bool encontrada = false;

        foreach (string pessoa in pessoas)
        {
            if (pessoa.Contains(busca, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Pessoa encontrada: {pessoa}");
                encontrada = true;
            }
        }

        if (!encontrada)
        {
            Console.WriteLine("Pessoa não encontrada.");
        }

        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();
    }
    else if (opcao == "4")
    {
        Console.Clear();

        Console.WriteLine("=== EDITAR PESSOA ===");

        if (pessoas.Count == 0)
        {
            Console.WriteLine("Nenhuma pessoa cadastrada.");
        }
        else
        {
            for (int i = 0; i < pessoas.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {pessoas[i]}");
            }

            Console.Write("\nDigite o número da pessoa que deseja editar: ");
            string entrada = Console.ReadLine() ?? "";

            if (int.TryParse(entrada, out int indice) &&
                indice >= 1 &&
                indice <= pessoas.Count)
            {
                Console.Write("Digite o novo nome: ");
                string novoNome = Console.ReadLine() ?? "";

                if (!string.IsNullOrWhiteSpace(novoNome))
                {
                    pessoas[indice - 1] = novoNome;
                    Console.WriteLine("Pessoa editada com sucesso!");
                }
                else
                {
                    Console.WriteLine("O nome não pode ficar vazio.");
                }
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
        }

        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();
    }
    else if (opcao == "5")
    {
        Console.Clear();

        Console.WriteLine("=== EXCLUIR PESSOA ===");

        if (pessoas.Count == 0)
        {
            Console.WriteLine("Nenhuma pessoa cadastrada.");
        }
        else
        {
            for (int i = 0; i < pessoas.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {pessoas[i]}");
            }

            Console.Write("\nDigite o número da pessoa que deseja excluir: ");
            string entrada = Console.ReadLine() ?? "";

            if (int.TryParse(entrada, out int indice) &&
                indice >= 1 &&
                indice <= pessoas.Count)
            {
                string pessoaRemovida = pessoas[indice - 1];
                pessoas.RemoveAt(indice - 1);

                Console.WriteLine($"{pessoaRemovida} foi removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
        }

        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();
    }
    else if (opcao == "0")
    {
        Console.WriteLine("\nEncerrando o sistema...");
    }
    else
    {
        Console.WriteLine("\nOpção inválida!");
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }
}