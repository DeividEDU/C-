using System;
using System.Collections.Generic;
using System.Linq;

namespace exemple
{
    class Program
    {
        static void Main(string[] args)
        {
            Alunos[] aluno1 = new Alunos[7];
            var indiceAlunos = 0;
            string opcaoUser = Obterinfouser();

            while (opcaoUser.ToUpper() != "X")
            {
                switch (opcaoUser)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno");
                        Alunos aluno = new Alunos();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do Aluno");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else 
                        {
                            throw new ArgumentOutOfRangeException("O Valor da nota dever ser decimal");

                        }
                        aluno1[indiceAlunos] = aluno;
                        indiceAlunos++; 

                    
                        break;

                    case "2":
                    foreach(var a in aluno1){
                        if(!string.IsNullOrEmpty(a.Nome))
                        {
                        Console.WriteLine($"ALUNO: {a.Nome} NOTA: {a.Nota}");
                        }
                    }

                        break;

                    case "3":
                        decimal notaTotal = 0;
                        var nrAlunos = 0;
                        for (int i=0; i < aluno1.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(aluno1[i].Nome))
                            {
                                notaTotal = notaTotal + aluno1[i].Nota;
                                nrAlunos++;
                            }

                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        ConceitoEnun conceitoGeral;

                        if (mediaGeral < 2)
                        {
                            conceitoGeral = ConceitoEnun.E;

                        }
                        else if (mediaGeral < 4)
                        {
                            conceitoGeral = ConceitoEnun.D;
                        }
                        else if (mediaGeral < 6)
                        {
                            conceitoGeral = ConceitoEnun.C;
                        }
                        else if (mediaGeral < 8)
                        {
                            conceitoGeral = ConceitoEnun.B;
                        }
                        else 
                        {
                            conceitoGeral = ConceitoEnun.A;
                        }

                        Console.WriteLine($"A Média Geral é: {mediaGeral} -Conceito {conceitoGeral}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUser = Obterinfouser();
            }
        }
        private static string Obterinfouser()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular Média Geral");
            Console.WriteLine("x - Sair");
            Console.WriteLine();

            string opcaoUser = Console.ReadLine();
            Console.WriteLine();
            return opcaoUser;
        }
    }
}