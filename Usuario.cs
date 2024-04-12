using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoReal
{
    class Usuario
    {
        public string Titular;
        public double Saldo;

        public Usuario(string titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"O valor de R$ {valor}, foi cretitado em sua conta");
        }
        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado com sucesso. Novo saldo: {Saldo}");
            }
        }
        public void Imprimir()
        {
            Console.WriteLine($"Saldo atual da conta de {Titular}: {Saldo}");
        }

    }
}
    
