using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    public class Banco
    {
        private string _conta;
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        private static double _taxa = 5.00;

        public Banco (string conta, string titular, double saldo) : this (conta, titular)
        {
            Saldo = saldo;
        }

        public Banco(string conta, string titular)
        {
            Conta  = conta;
            Titular = titular;
        }
    
        public string Conta
        {
            get { return _conta; }
            set { _conta = value; }

        }


        public double Deposito(double valor)
        {
            return Saldo += valor;
        }

        public double Saque(double valor)
        {
            return Saldo -= valor + _taxa;
        }

        public override string ToString()
        {
            return "Conta " + Conta
                + ", Titular: " + Titular
                + ", Saldo: $ " + Saldo.ToString("F2",CultureInfo.InvariantCulture);
            
        }




    }
}
