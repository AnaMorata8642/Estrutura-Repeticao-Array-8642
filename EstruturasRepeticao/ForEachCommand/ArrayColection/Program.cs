using System;

namespace ArrayColection
{
    class Program
    {
        static void Main(string[] args)
        {
            //SINTAXE DO ARRAY: TiposdeDados [] = new TiposdeDados [tamanho];

            string[] alunosAMS = new string[5]
            {"Ana Julia",
            "Evelyn Talita",
            "Gabriel Ramos",
            "Antonio",
            "Pedro Pivetta"};

            Console.WriteLine(alunosAMS[2]);

            //alunosAMS[2] = "Gabriel Ramos"

            Console.WriteLine($"Novo valor no index: {alunosAMS[2]}");

            foreach (string alunos in alunosAMS)
            {
                Console.WriteLine(alunos);
            }
        }
    }
}
