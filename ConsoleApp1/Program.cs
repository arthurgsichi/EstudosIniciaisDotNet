using System;
using System.Collections.Generic;
using cursoCsharp.Fundamentos;
using cursoCsharp.EstruturasDeControle;
using cursoCsharp.ClassesEMetodos;
using static cursoCsharp.ClassesEMetodos.Coordenada;
using cursoCsharp.Colecoes;
using cursoCsharp.OO;
using cursoCsharp.MetodosEFuncoes;
using cursoCsharp.Excecoes;
using cursoCsharp.API;
using cursoCsharp.TopicosAvancados;
using cursoCsharp.Treinando;
using System.IO;
<<<<<<< HEAD
using cursoCsharp.Treinando.JogoDaForca_03;
using cursoCsharp.Treinando.NumeroSecreto_04;
using cursoCsharp.Treinando.ListaDeCompras_05;
using cursoCsharp.Treinando.BancoDeDados_06;
using cursoCsharp.Treinando.NumeroSecreto_04.NumeroSecreto_04;
using cursoCsharp.Treinando.ListaDeCompras_05.ListaDeCompras_05;
using cursoCsharp.Treinando.VoltandoPraAtiva_07;
=======
using static cursoCsharp.TopicosAvancados.PropriedadesNumImPar;
>>>>>>> 187c3ae3adb93dca2c7cb23baa33debc6efaedc3

namespace cursoCsharp
{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                //Fundamentos ( bla bla bla )
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Interpolação - Fundamentos", interpolação.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões Numéricas - Fundamentos", ConversoesNumericas.Executar},
                {"Operadores Aritiméticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Testando Meu Próprio Conhecimento Por Diversão :D  - Fundamentos", TesteDeConhecimentoProprio.Executar},
                {"Operadores De Atribuição - Fundamentos", OperadoresDeAtribuição.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternários - Fundamentos", OperadoresTernarios.Executar},

                //---------------------------Estruturas De Controle--------------------------
                {"Estrura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrura If / Else / ElseIf - Estruturas de Controle", EstruturaIfElseElseIf.Executar},
                {"Estrura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrura For Each - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},

                //{"---------------------------Classes e Métodos--------------------------
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Métodos Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos Com Retornos - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Desafio - Classes e Métodos", Desafios.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parâmetros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Get Set - Classes e Métodos", GettersESetters.Executar},
                {"Propriedades - Classes e Métodos", Propriedades.Executar},
                {"ReadOnly - Classes e Métodos", Readonly.Executar},
                {"Enum Exemplo - Classes e Métodos", EnumExemplo.Executar},
                {"Structure Struct - Classes e Métodos", StructExemplo.Executar},
                {"Struct VS Class - Classes e Métodos", StructVSClass.Executar},
                {"Valor VS Referência - Classes e Métodos", ValorVSReferencia.Executar},
                {"Parâmetros Por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},

                // ---------------------------------Coleções---------------------------------
                {"Arrays - Coleções", Arrays.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},

                // ---------------------------------Orientação A Objetos---------------------------------
                {"Herança - OO", Herança.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abastract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},

                // ----------------------------------- Métodos E Funções ---------------------------
                {"Exemplo Lambda - OO", ExemploLambda.Executar},
                {"Lambda Delegate - OO", LambdaDelegate.Executar},
                {"Usando Delegate - OO", UsandoDelegate.Executar},
                {"Delegate Anônimo - OO", DelegateAnonimo.Executar},
                {"Delegate Como Parâmetros - OO", DelegateComoParametros.Executar},
                {"Métodos de Extensões - OO", MetodosDeExtensao.Executar},

                // -------------------------------------- Execeções -------------------------------
                {"Primeira Exção - Execeções", PrimeiraExcao.Executar},
                {"Exeções Personalizadas - Execeções", ExcaoPersonalizada.Executar},

                //---------------------------------------- API ---------------------------------------
                {"Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar},
                {"Lendo Arquivo - Usando API", LendoArquivo.Executar},
                {"Exemplo FileInfo - Usando API", ExemploFileInfo.Executar},
                {"Exemplo Derectory - Usando API", ExemploDirectory.Executar},
                {"Exemplo Path - Usando API", ExemploPath.Executar},
                {"Exemplo DateTime - Usando API", ExemploDateTime.Executar},
                {"Exemplo TimeSpan - Usando API", ExemploTimeSpan.Executar},

                //--------------------------------- Tópicos Avançados ------------------------------
                {"LINQ #01 - Tópicos Avançados", LINQ_1.Executar},
                {"LINQ #02 - Tópicos Avançados", LINQ_2.Executar},
                {"Nullable - Tópicos Avançados", Nullables.Executar},
                {"Dynamic - Tópicos Avançados", Dynamic.Executar},
                {"Chat GPT #1 - Tópicos Avançados", NumImparPar.Executar},
                {"Chat GPT #2 - Tópicos Avançados", SomaNumeroAlvo.Executar},
                {"Chat GPT #3 - Tópicos Avançados", StringSplit.Executar},
                {"Chat GPT #4 - Tópicos Avançados", PedidosRestaurante.Executar},
                {"Chat GPT #5 - Tópicos Avançados", ConversaoDeCoisas.Executar},
                {"Chat GPT #6 - Tópicos Avançados", GerenciamentoTarefas.Executar},
                {"Chat GPT #7 - Tópicos Avançados", NumerosParesComLinq.Executar},
                {"Chat GPT #8 - Tópicos Avançados", AnaliseDeTextoLINQ.Executar},
                {"Chat GPT #9 - Tópicos Avançados", EncontrandoNumerosPerdidosLINQ.Executar},
                {"Chat GPT #10 - Tópicos Avançados", ValidacaoDeAnagramasLINQ.Executar},
                {"Chat GPT #11 - Tópicos Avançados", ValidacaoDePalindromosLINQ.Executar},


                //--------------------------------- Acabei o curso e to só treinando pra não esquecer -------------------------------
                {"ChatGPT #01 ( Médias Aritiméticas )", ChatGPT_01.Executar},
                {"ChatGPT #02 ( Palíndromos )", ChatGPT_02.Executar},
                {"ChatGPT #03 (  Jogo da Forca )", ChatGPT_03.Executar },
                {"ChatGPT #04 (  NúmeroSecreto )", ChatGPT_04.Executar },
                {"ChatGPT #05 (  Lista de Compras )", ChatGPT_05.Executar },
                {"ChatGPT #06 (  Banco de Dados Simples )", ChatGPT_06.Executar },
                //{"ChatGPT #07 (  iniciante/intermediário/expert )", ChatGPT_07.Executar },


            }); ; central.SelecionarEExecutar();

        }
    }
}