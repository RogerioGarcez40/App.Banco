
using System;

namespace App.Banco
{
 public class Conta

  {
       private TipoConta TipoConta {get;set;}
       private double Saldo {get;set;}
       private double Credito {get;set;}
       private string Nome {get;set;}

       public Conta (TipoConta tipoConta,double saldo ,double credito , string nome)
       {
          this.TipoConta = tipoConta;
          this.Saldo = saldo;
          this.Credito = credito;
          this .Nome = nome;
       }
       public bool Sacar (double valorSaque)
       {
           //validacao de saldo insuficiente
           if (this.Saldo - valorSaque < (this.Credito * -1)){
               Console.WriteLine("Seu Saldo e insuficiente !!");
               return false;
               
            }
              this.Saldo -= valorSaque;
              Console.WriteLine("O Saldo da sua conta e de {0} e {1} ", this.Nome, this.Saldo);
              return true;
              
        }
        public void Depositar (double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine("O Saldo da sua Conta e de {0] e {1} ", this.Nome, this.Saldo);

        }
        public void Transferir(double valorTransferencia,Conta contaDestino){
            if (this.Sacar(valorTransferencia)){
                contaDestino.Depositar(valorTransferencia);
            }
        }
        public override string ToString ()
        {
            string retorno = "";
            retorno += "Tipo de Conta " + this.TipoConta + "|";
            retorno += "Nome" + this.Nome + "|";
            retorno += "Saldo" + this.Saldo + "|";
            retorno += "Credito" + this.Credito;
            return retorno;

        }
   }
}