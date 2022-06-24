﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_Exercicio03
{
    public class ContaBancaria
    {
        public int NumeroConta { get;private set; }
        public string NomedoCliente { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero,string nomecliente)
        {
            NumeroConta = numero;
            NomedoCliente = nomecliente;
        }
        public ContaBancaria(int numero, string nomecliente,double depositoinicial) :this(numero,nomecliente)
        {
            Deposito(depositoinicial);
        }
        public string AlterarNome(string nomecliente ) 
        {
            nomecliente=Console.ReadLine();
            NomedoCliente = nomecliente ;
            return nomecliente;
            
        }
        public void Deposito(double valor)
        {
            Saldo+=valor;
        }
        public void Saque(double valor)
        {
            if (Saldo < 0.0) { Console.WriteLine("Não é possivel realizar essa transação"); }
            else { Saldo -= valor; }  
        }
        public override string ToString()
        {
            return $"Conta {NumeroConta} do cliente {NomedoCliente} tem saldo de R${Saldo:00.00}";    
        }





    }
}
