namespace Aula1;

class Program
{
    public static void Main()
    {
        string nomeUsuario = "";
        int  idade = 0;
        Console.WriteLine("=========== Cadastro de Usuários ===========");

        Console.WriteLine("Digite o nome do usuário:");
        nomeUsuario = Console.ReadLine();

        Console.WriteLine("Digite a idade do usuário:");
        idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("=========== Informações do usuário: ===========");
        Console.WriteLine("Nome: " + nomeUsuario);
        Console.WriteLine($"Idade: {idade}");
    }
}
