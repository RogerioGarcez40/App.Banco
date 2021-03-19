
using System;
using System.Collections.Generic;



namespace App.Banco

{
    class Program



        {
        static List<Conta> listContas = new List<Conta> ();
        static void Main(string[] args)
        
        
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            
            while (opcaoUsuario.ToUpper() != "X")

            {
                switch (opcaoUsuario)

                {
                   case "1":
                   ListarContas();
                   break;

                   case "2":
                   InserirConta();
                   break;

                   case "3":
                   Transferir();
                   break;

                   case "4":
                   Sacar();
                   break;

                   case "5":
                   Depositar();
                   break;

                   case "C":
                   Console.Clear();
                   break;

                   default:
                   throw new ArgumentOutOfRangeException();
                }

                  opcaoUsuario = ObterOpcaoUsuario();   
            }
            
            Console.WriteLine ("Obrigado por Utilizar nossos servicos. ");
            Console.WriteLine();
        
        
        }

        private static void InserirConta()
        {
            Console.Write("Digite 1 para Conta Fisica ou 2 para Juridica : ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do cliente: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o Saldo Inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o credito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta (tipoConta: (TipoConta)entradaTipoConta,
                                         saldo: entradaSaldo,
                                         credito: entradaCredito,
                                         nome: entradaNome);
            
            listContas.Add(novaConta);

        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar Contas");

            if(listContas.Count == 0)
            {
                Console.WriteLine("Nenhuma Conta Cadastrada. ");
                return;
            }
            for (int i = 0; i < listContas.Count ; i++)
            {
                Conta conta  = listContas[i];
                Console.WriteLine("#{0} - " ,i);
                Console.WriteLine(conta);
            }
        }

        private static void Sacar()

        {
            Console.WriteLine(" Digite o numero da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorDeposito);
        }

       private static void Depositar()
       {
           Console.WriteLine("Digite o numero da conta: ");
           indiceConta = int.Parse(Console.ReadLine());

           Console.WriteLine("Digite o valor a ser depositado: ");
           double valorDeposito = double.Parse(Console.ReadLine());

           listContas[indiceConta].Depositar(valorDeposito);
       }

       private static void Transferir()
       {
              Console.WriteLine("Digite o numero da conta de origem: ");
              int indiceConta = int.Parse(Console.ReadLine());

              Console.WriteLine("Digite o numero da conta Destimo: ");
              int indiceContaDestino = int.Parse(Console.ReadLine());

              Console.WriteLine("Digite o valor a ser transferido: ");
              double valorTransferencia = double.Parse(Console.ReadLine());

              listContas[indiceContaOrigem].Transferir(valorTransferencia,listContas [indiceContaDestino]);
       }
        
       
       private static string ObterOpcaoUsuario()

        {
           Console.WriteLine();
           Console.WriteLine("App Banco a seu dispor!!!");
           Console.WriteLine("Informe a opcao desejada: ");

           Console.WriteLine("1- Listar Contas ");
           Console.WriteLine("2- Inserir nova Conta ");
           Console.WriteLine("3- Transferir ");
           Console.WriteLine("4- Sacar ");
           Console.WriteLine("5- Depositar ");
           Console.WriteLine("c- Limpar Tela ");
           Console.WriteLine("x- Sair");
           Console.WriteLine();

           string ObterOpcaoUsuario = Console.ReadLine().ToUpper();

        }
    }
    
}