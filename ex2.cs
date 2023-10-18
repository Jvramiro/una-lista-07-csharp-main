using System;
using System.Collections.Generic;

public class Exercise_02
{
    public void run()
    {   
        // Lista
        // Uma lista, muitas vezes referida como uma lista linear ou sequencial, é uma coleção de elementos organizados de forma linear, 
        // onde cada elemento possui uma posição específica na lista. 
        // É possível acessar elementos em qualquer posição da lista e realizar operações de inserção e remoção em qualquer lugar da lista.
        
        Console.WriteLine("Lista");

        List<int> numeros = new List<int>();
        numeros.Add(1);
        numeros.Add(2);
        numeros.Add(3);
        
        Console.WriteLine("Elementos na lista:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        // Pilha
        // Uma pilha é uma estrutura de dados que segue o princípio "último a entrar, primeiro a sair" (LIFO - Last In, First Out). 
        // Isso significa que o último elemento adicionado à pilha é o primeiro a ser removido.

        Console.WriteLine("Pilha");
        Stack<string> nomes = new Stack<string>();
        nomes.Push("Alice");
        nomes.Push("Bob");
        nomes.Push("Carol");
        
        Console.WriteLine("Elementos na pilha:");
        while (nomes.Count > 0)
        {
            string nome = nomes.Pop();
            Console.WriteLine(nome);
        }
    }
}
