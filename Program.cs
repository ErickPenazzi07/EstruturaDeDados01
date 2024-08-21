using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {

        //List<string> frutas = new List<string>();

        //frutas.Add("Maçã");
        //frutas.Add("Uva");
        //frutas.Add("Pera");
        //frutas.Add("Kiwi");

        //Console.WriteLine("Imprimindo Minha Lista: ");
        //foreach (string fruit in frutas)
        //{ Console.WriteLine(fruit); }


        Queue<string> filaBanco = new Queue<string>();

        filaBanco.Enqueue("Mauricio");
        filaBanco.Enqueue("Gerimunda");
        filaBanco.Enqueue("Marcia");
        filaBanco.Enqueue("Dilva");
        filaBanco.Enqueue("Trost");
        Console.WriteLine();



        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        /* retirar o primeiro elemento de uma fila */
        filaBanco.Dequeue();

        Console.WriteLine(); // Pula linha em Branco
        Console.WriteLine("===========================");
        Console.WriteLine(); // Pula linha em Branco
        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        /* Verificar se existe um elemento na fila */

        bool achou = filaBanco.Contains("Dilva");

        if (achou)
        {
            Console.WriteLine("A Pessoa está na Fila");
        }
        else
        {
            Console.WriteLine("A Pessoa NÃO está na Fila");
        }

        Console.WriteLine();
        Console.WriteLine("=========================");
        Console.WriteLine();

        // TRABALHANDO COM PILHA (STACK)


        /* Criando uma Pilha */
        Stack<string> livros = new Stack<string>();

        /* Adicionar elementos em uma pilha */

        livros.Push("Pequeno Principe");
        livros.Push("A Fera");
        livros.Push("Principe e o Sapa");

        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }
        Console.WriteLine();
        Console.WriteLine("=========================");
        Console.WriteLine();

        /* Remove o primeiro elemento da Pilha */


        livros.Pop();
        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }
        Console.WriteLine();
        Console.WriteLine("=========================");
        Console.WriteLine();
    }

}




