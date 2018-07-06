using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoTDD
{
    public class ATM
    {
        private List<Int32> _notas;

        public ATM()
        {
            _notas = new List<Int32>
            {
                2,
                5,
                10,
                20,
                50,
                100
            };
        }

        /// <summary>
        /// Sacar valor no Caixa
        /// </summary>
        /// <param name="valor">Valor do Saque</param>
        /// <returns>String do resultado do saque, Qtd Notas sacadas x valor, Valor inválido ou Caixa sem notas</returns>
        public String Sacar(Int32 valor)
        {
            String retorno = "";
            if (_notas != null && _notas.Any())
            {
                if (valor % 2 == 0)
                {
                    //Declarar valor restante
                    Int32 valorRestante = valor;
                    //lista de notas selecionadas pelo contador
                    List<Nota> notasContadas = new List<Nota>();
                    //maior nota abaixo do valor de saque
                    Int32 valorNotaSelecionada;
                    
                    //valida enquanto há um valor para saque
                    while (valorRestante > 0)
                    {
                        //recupera a ultima nota abaixo ou no valor do valor restante
                        valorNotaSelecionada = _notas.Last(x => x <= valorRestante);
                        //valida se ja existe uma nota seecionada no mesmo valor
                        if (notasContadas.Any(x => x.Valor == valorNotaSelecionada))
                            notasContadas.First(x => x.Valor == valorNotaSelecionada).Quantidade += 1;
                        else //adiciona a nova nota nao selecionada para o saque
                            notasContadas.Add(new Nota { Valor = valorNotaSelecionada, Quantidade = 1 });

                        //decrementa o valor restante com o valor da nota selecionada
                        valorRestante -= valorNotaSelecionada;
                    }
                    //preenche a string de retorno com as notas selecionadas
                    notasContadas.ForEach(x => 
                    {
                        if(x.Valor == notasContadas.Last().Valor)
                            retorno += x.Resultado;
                        else
                            retorno += $"{x.Resultado}, ";
                    });
                    return retorno;
                }
                else
                {
                    //preenche a string de retorno com as notas disponiveis
                    _notas.ForEach(x => { retorno += $", {x}"; });
                    return $"O ATM só trabalha com as nota(s){retorno}";
                }
            }

            return "Não há notas disponíveis para Saque.";
        }

        /// <summary>
        /// Limpar Lista de de Notas Disponiveis no Caixa
        /// </summary>
        public void LimparNotas()
        {
            _notas = new List<Int32>();
        }
    }
}
