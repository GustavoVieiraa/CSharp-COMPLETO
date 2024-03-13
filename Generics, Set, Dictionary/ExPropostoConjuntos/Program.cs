using ExPropostoConjuntos.Entities;
using System;

/*
                ### Exercicio Proposto ###
    Em um portal de cursos online, cada usuário possui um
    código único, representado por um número inteiro.
    
    Cada instrutor do portal pode ter vários cursos, sendo
    que um mesmo aluno pode se matricular em quantos cursos
    quiser. Assim, o número total de um instrutor não é
    simplesmente a soma dos alunos de todos os cursos que
    ele possui, pois pode haver alunos repetidos em mais
    de um curso.

    O instrutor Alex possui três cursos A, B e C, e deseja
    saber seu número total de alunos.

    Seu programa deve ler os alunos dos cursos A, B e C do
    instrutor Alex, depois mostrar a quantidade total e 
    alunos dele.
 */

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HashSet<Student> students = new HashSet<Student>();

                Console.Write("How many students for course A? ");
                int courseA = int.Parse(Console.ReadLine());
                for (int i = 0; i < courseA; i++)
                {
                    int numberCard = int.Parse(Console.ReadLine());
                    students.Add(new Student() { NumberCard = numberCard });
                }

                Console.Write("How many students for Course B? ");
                int courseB = int.Parse(Console.ReadLine());
                for (int i = 0; i < courseB; i++)
                {
                    int numberCard = int.Parse(Console.ReadLine());
                    students.Add(new Student() { NumberCard = numberCard });
                }

                Console.Write("How many students for Course C? ");
                int courseC = int.Parse(Console.ReadLine());
                for (int i = 0; i < courseC; i++)
                {
                    int numberCard = int.Parse(Console.ReadLine());
                    students.Add(new Student() { NumberCard = numberCard });
                }

                Console.WriteLine($"Total Students: {students.Count()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
    }
}