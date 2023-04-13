using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoFila
{
    internal class Program
    {
        class Elemento
        {
            public string Placa;
            public string Modelo;
            public string Marca;
            public Elemento Proximo;

            public Elemento()
            {
                Placa = "";
                Modelo = "";
                Marca = "";
                Proximo = null;
            }
        }

        class Estacionamento
        {
            Elemento Inicio;
            Elemento Fim;
            Elemento Aux;
            int Tamanho = 0;

            public Estacionamento()
            {
                Inicio = null;
                Fim = null;
            }

            public void Inserir(string Placa, string Modelo, string Marca)
            {
                if (Tamanho <= 3)
                {
                    Elemento Novo = new Elemento();

                    Novo.Placa = Placa;
                    Novo.Modelo = Modelo;
                    Novo.Marca = Marca;

                    if (Inicio == null)
                    {
                        Inicio = Novo;
                        Fim = Novo;
                    }
                    else
                    {
                        Fim.Proximo = Novo;
                        Fim = Novo;
                    }

                    Tamanho++;
                }
            }

            public void Retirar(string Placa)
            {                
                if (Inicio.Placa == Placa)
                {
                    Inicio = Inicio.Proximo;                    
                }
                else if (Fim.Placa == Placa)
                {
                    Aux = Inicio;

                    while (Aux.Placa != Placa)
                    {
                        Inicio = Inicio.Proximo;
                        Fim.Proximo = Aux;
                        Fim = Aux;
                        Aux = Inicio;
                    }
                    if (Aux.Placa == Placa)
                    {
                        Inicio = Inicio.Proximo;
                        Fim.Proximo = null;
                    }
                }
                else
                {
                    Fim.Proximo = Inicio;
                    Fim = Inicio;
                    Inicio = Inicio.Proximo.Proximo;
                }

                Tamanho--;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
