using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco banco;
            Console.WriteLine("Entre o número da conta: ");
            string conta = Console.ReadLine();
            Console.WriteLine("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial? (S/N)");

            if (Console.ReadLine().ToUpper() == "S")
            {
                Console.WriteLine("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine());
                banco = new Banco(conta, titular, saldo);
            }
            else
            {
                banco = new Banco(conta, titular);
            }

            Console.Write("Dados da Conta: ");
            Console.WriteLine(banco);

            Console.WriteLine("Entre um valor para depósito: " );
            banco.Deposito(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(banco);

            Console.WriteLine("Entre o valor para saque: ");
            banco.Saque(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(banco);


            
                

               
            
        }
    }
}
