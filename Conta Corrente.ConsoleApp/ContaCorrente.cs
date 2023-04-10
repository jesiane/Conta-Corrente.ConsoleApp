using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Corrente.ConsoleApp
{
    public class Conta
        {
            private int numero;
            private decimal saldo;
            private bool ehEspecial;
            private decimal limite;
            private ArrayList movimentacoes;
            public decimal Saldo
            {
                get
                {
                    return this.saldo;
                }
            }

            public Conta(int numero, decimal saldo, bool ehEspecial, decimal limite)
            {
                this.numero = numero;
                this.saldo = saldo;
                this.ehEspecial = ehEspecial;
                this.limite = limite;
                this.movimentacoes = new ArrayList();
                this.movimentacoes.Add(new Movimentacao(this.saldo, "Crédito"));
            }

            public string RealizarDeposito(decimal deposito)
            {
                if (deposito < 0)
                {
                    return "Depósito inválido";
                }

                this.saldo += deposito;
                this.movimentacoes.Add(new Movimentacao(deposito, "Crédito"));
                return "Depósito sucedido!";
            }

            public string RealizarSaque(decimal saque)
            {
                if (saque > saldo + limite)
                {
                    return "Saque inválido";
                }

                this.saldo -= saque;
                this.movimentacoes.Add(new Movimentacao(saque, "Débito"));
                return "Saque sucedido!";
            }

            public bool ReceberTransferencia(decimal transferencia)
            {
                if (transferencia < 0)
                {
                    return false;
                }

                this.saldo += transferencia;
                this.movimentacoes.Add(new Movimentacao(transferencia, "Crédito"));
                return true;
            }

            public string RealizarTransferencia(Conta conta, decimal transferencia)
            {
                if (transferencia > saldo + limite)
                {
                    return "Saldo insuficiente";
                }

                if (!conta.ReceberTransferencia(transferencia) || transferencia > saldo + limite)
                {
                    return "Transferência inválida";
                }

                this.saldo -= transferencia;
                this.movimentacoes.Add(new Movimentacao(transferencia, "Débito"));
                return "Transferência sucedida!";
            }

            public string ExibirExtrato()
            {
                string cabecalho = $"Extrato Conta Corrente {(this.ehEspecial ? "Especial" : "Comum")} N°{this.numero}";
                string divisor = new string('-', cabecalho.Length) + "";
                string saldoFinal = $"Saldo: R${this.saldo}";
                string extrato = $"\n{cabecalho}\n{divisor}\n{ExibirMovimentacoes()}\n{divisor}\n{saldoFinal}";
                return extrato;
            }

            public string ExibirMovimentacoes()
            {
                string movimentacaoTotal = "Movimentações:";
                foreach (Movimentacao movimentacao in this.movimentacoes)
                {
                    movimentacaoTotal += $"\n{movimentacao.Tipo}: R${movimentacao.Valor}";
                }
                return movimentacaoTotal;
            }
        }
    }