using System.Collections;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Classes
{
    public class lista3Classes
    {
        public double ESTOQUE()
        {
            Console.WriteLine("Digite a quantidade mínima de estoque");
            int Min = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade Máxima de estoque");
            int Max = int.Parse(Console.ReadLine());

            return (Min + Max) / 2;

        }

        public string CONVERSAO()
        {

            Console.WriteLine("Digite um valor em dólares");
            decimal Dolar = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a cotação do dolar atual");
            decimal Cot = decimal.Parse(Console.ReadLine());

            return ("A cotação atual do Dolar é: " + Cot + "\n O valor ditiado foi: " + Dolar + " $ \n A conversão desse valor para real é de " + (Dolar * Cot) + " R$");
        }

        public string COMISSAO()
        {

            Console.WriteLine("---------TABELA DE PREÇOS---------\n" +
            "CARBURADOR--COD 1--PRECO R$ 5000" +
            "\nMOTOR --COD 2 --PRECO R$ 10000" +
            "\nRETROVIOR --COD 3 --PRECO R$ 300");

            Console.WriteLine("Nome do vendedor: ");
            string Nome = Console.ReadLine();


            int valor = 1;
            var totitems = 0;
            ArrayList ar = new ArrayList();

            for (int i = 0; i < valor; i++)
            {
                var codP = 0;
                Console.WriteLine("Digite o código da peça que você vendeu ou digite -1 para parar de cadastrar peças");

                codP = int.Parse(Console.ReadLine());

                if (codP == -1) break;
                if (codP < 1 || codP > 3)
                {
                    var analise = 0;
                    do
                    {


                        int[] verificar = new int[] { 1, 2, 3 };

                        Console.WriteLine("Valor incorreto, corrija: ");
                        codP = int.Parse(Console.ReadLine());

                        foreach (int a in verificar)
                        {
                            if (a == codP)
                            {
                                analise = codP;

                                break;
                            }
                            else
                            {
                                analise = 30;
                            }
                        }


                    } while (codP != analise);
                }
                totitems++;
                if (codP == 1) ar.Add(5000);
                if (codP == 2) ar.Add(10000);
                if (codP == 3) ar.Add(300);
                valor++;

            }
            var valortot = 0;
            foreach (int item in ar)
            {
                valortot += item;
            }

            return "Nome: " + Nome + "\n Valor total das peças vendidas: " + valortot +
               "\n Total de peças vendidas: " + totitems + "\n Valor total da comissão que o vendedor irá receber é de 5%: " + (valortot * 5) / 100;


        }
        public int Distibutiva()
        {

            int[] arr = new int[4];

            var valorTot = 0;
            do
            {
                Console.WriteLine("Digite um numero ");
                arr[valorTot] = int.Parse(Console.ReadLine());
                valorTot++;
            } while (valorTot < 4);


            var result1 = 0;
            var result2 = 0;
            var result3 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result1 = arr[0] * arr[1] * arr[0] * arr[2] * arr[0] * arr[3] + (arr[0] + arr[1] + arr[0] + arr[2] + arr[0] + arr[3]);
                result2 = arr[1] * arr[2] * arr[1] * arr[3] + (arr[1] + arr[2] + arr[1] + arr[3]);
                result3 = arr[2] * arr[3] + (arr[2] + arr[3]);

            }
            return result1 + result2 + result3;
        }
        public string Velocidade()
        {

            Console.WriteLine("Digite o tempo gasto na viagem: ");
            int Tempo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a velocidade média na viagem: ");
            int MédiaVelo = int.Parse(Console.ReadLine());


            int DISTANCIA = Tempo * MédiaVelo;

            Console.WriteLine("Digite quantos km por litro o seu carro faz");
            int KMPORLITRO = int.Parse(Console.ReadLine());

            int LITROS_USADOS = DISTANCIA / KMPORLITRO;

            return ("A velocidade média foi de:  " + MédiaVelo + "\n O tempo gasto foi de: " + Tempo + " Horas \n  A DISTÂNCIA PERCORRIDA FOI DE: " + DISTANCIA + "\n A quantidade de litros gastos foi de: " + LITROS_USADOS + "L");

        }
        public void FahRenheit_Celsius()
        {

            var Opcao = "";
            do
            {
                Console.WriteLine("Digite C para ler uma temperatura em Celsius e converter para Fahrenheit  \n" +
            "Digite F para ler uma temperatura em Fahrenheit e converter para Celsius \n Digite S para finalizar");

                Opcao = Console.ReadLine().ToUpper();


                if (Opcao == "C")
                {
                    Console.WriteLine("Digite a temperatura em Celsius: ");
                    decimal C = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("A temperatura em fahrenheit é:  " + (9 * C + 160) / 5 + " F");
                }
                if (Opcao == "F")
                {
                    Console.WriteLine("Digite a temperatura em Fahrenheit: ");
                    decimal F = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("A temperatura em Celsius é: " + (F - 32) * 5 / 9 + " C ");
                }
            } while (Opcao != "S");



        }
        public string Lata_D_Óleo()
        {

            Console.WriteLine("Digite o raio: ");
            double Raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            double Altura = double.Parse(Console.ReadLine());



            return "O volume é: " + (3.14159 * Raio * Raio * Altura);
        }

        public string idade()
        {
            Console.WriteLine("Escreva quantos anos você tem: ");
            int anos = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva quantos meses você tem: ");
            int meses = int.Parse(Console.ReadLine());
            if (meses > 12 || meses < 1) return "Erro, os meses não podem ser maior do que 12 e nem menor do que 1";
            Console.WriteLine("Escreva quantos dias você tem: ");
            int dias = int.Parse(Console.ReadLine());
            if (dias > 30 || dias < 1) return "Erro, os dias não podem ser maior do que 30 ou menor do que 1";
            int result = (anos * 365) + (meses * 30) + dias;

            return "Sua idade em dias é: " + result;
        }
        public string numeros()
        {
            Console.WriteLine("Digite o valor do número 1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do número 2: ");
            int n2 = int.Parse(Console.ReadLine());

            var resultado = "";
            if (n1 == n2) resultado += "Os numeros são iguais \n";
            if (n1 != n2) resultado += "Os números não são iguais \n";
            if (n1 > n2) resultado += n1 + " é o maior numero \n";
            if (n2 > n1) resultado += n2 + " é o maior numero \n";
            if (n1 < n2) resultado += n1 + " é o menor número \n";
            if (n1 >= n2) resultado += n1 + " É maior ou igual a " + n2 + "\n";
            if (n2 >= n1) resultado += n2 + " é maior ou igual a " + n1 + "\n";
            if (n1 <= n2) resultado += n1 + " é menor ou igual a " + n2 + "\n";
            if (n2 <= n1) resultado += n2 + " é menor ou igual a " + n1 + "\n";

            return resultado;
        }


        public string Troca_De_Valor()
        {
            Console.WriteLine("Digite o valor de A");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B");
            int B = int.Parse(Console.ReadLine());

            int newValue = A;
            newValue = B;
            B = A;


            return "Valor de A: " + newValue + " Valor de B: " + B;
        }
        public string modulo()
        {
            Console.WriteLine("Digite um número");
            int Numero = int.Parse(Console.ReadLine());




            if (Numero < 0) return "O módulo de " + Numero + " é " + Numero * (-1);

            return "O módulo de " + Numero + " é " + Numero;
        }

        public string ordemD()
        {
            int[] arr = new int[3];

            int contador = 0;
            do
            {
                Console.WriteLine("Digite um número");

                arr[contador] = int.Parse(Console.ReadLine());
                contador++;
            } while (contador != 3);

            Array.Sort(arr);
            Array.Reverse(arr);

            string resultado = "";
            foreach (int numero in arr)
            {
                resultado += numero + "\n";
            }

            return "Números em ordem decrescente: \n" + resultado;
        }

        public string diferencaMaiorMenor()
        {
            Console.WriteLine("Digite o primeiro número");
            int Numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número");
            int Numero2 = int.Parse(Console.ReadLine());

            int resultado = 0;
            if (Numero1 > Numero2)
            {
                resultado = Numero1 - Numero2;
            }
            if (Numero1 < Numero2)
            {
                resultado = Numero2 - Numero1;
            }

            if (Numero1 == Numero2)
            {
                resultado = 0;
            }

            return "A diferença de " + Numero1 + " Para o número " + Numero2 + " é " + resultado;
        }

        public string NotasEscolares()
        {
            double[] arr = new double[4];

            int contador = 0;
            do
            {
                Console.WriteLine("Digite uma nota");

                arr[contador] = double.Parse(Console.ReadLine());
                contador++;
            } while (contador != 4);


            double media = (arr[0] + arr[1] + arr[2] + arr[3]) / 4;

            Console.WriteLine("Sua média é: " + media);

            if (media < 7)
            {
                Console.WriteLine("Você está de recuperação");
                Console.WriteLine("Digite a nota de recuperação: ");
                double NotaRec = double.Parse(Console.ReadLine());

                double NovMedia = (NotaRec + media) / 2;

                if (NovMedia < 7)
                {
                    return "Você atingiu a média de " + NovMedia + " E está reprovado";
                }
                if (NovMedia >= 7)
                {
                    return "Você atingiu a média de " + NovMedia + " E está aprovado";
                }

            }



            return "Você atingiu a média de " + media + " E está aprovado";


        }


        public string maiorMennor()
        {
            Console.WriteLine("Digite um número");
            int Numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número");
            int Numero2 = int.Parse(Console.ReadLine());


            int Maior = 0;
            int Menor = 0;
            if (Numero1 > Numero2)
            {
                Maior = Numero1;
                Menor = Numero2;
            }
            if (Numero2 > Numero1)
            {
                Maior = Numero2;
                Menor = Numero1;
            }
            if (Numero1 == Numero2)
            {
                return "Os números são iguais";
            }

            return "O maior número é: " + Maior + " E o menor número é: " + Menor;
        }

        public string verificar9_0()
        {
            Console.WriteLine("Digite um número");
            int Numero = int.Parse(Console.ReadLine());

            if (Numero < 0 || Numero > 9) return "Valor inválido";

            return "Valor válido";

        }
        public string verificar1_3()
        {
            Console.WriteLine("Digite um número");
            int Numero = int.Parse(Console.ReadLine());

            switch (Numero)
            {
                case 1:
                    return "um";
                case 2:
                    return "dois";
                case 3:
                    return "tres";

                default:
                    return "Numero inválido";
            }

        }
        public string triangulo()
        {
            Console.WriteLine("Digite o valor do lado A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado C: ");
            int c = int.Parse(Console.ReadLine());

            string resultado = "";
            if (a < b + c && b < a + c && c < a + b)
            {
                if (a == b && b == c)
                {
                    resultado = ("Triângulo equilátero");
                }
                else if (a == b || a == c || b == c)
                {
                    resultado = ("Triângulo isósceles");
                }
                else
                {
                    resultado = ("Triângulo escaleno");
                }
            }
            else
            {
                resultado = ("Os valores informados não formam um triângulo.");

            }
            return resultado;

        }

        public string maiorQueZero()
        {
            int[] arr = new int[3];
            int parar = 0;
            int valor = 0;
            do
            {
                Console.WriteLine("Digite o valor " + parar);
                valor = int.Parse(Console.ReadLine());
                if (valor < 0)
                {

                    do
                    {

                        Console.WriteLine("Digite novamente: ");
                        valor = int.Parse(Console.ReadLine());
                    } while (valor <= 0);
                }

                arr[parar] = valor;
                parar++;
            } while (parar != 3);



            Array.Sort(arr);

            return "O menor valor é: " + arr[0] + "\n" +
                "O maior valor é: " + arr[2] + "\n" +
            "Multiplicação do menor valor (" + arr[0] + ") " + "Com o  maior valor: (" + arr[2] + ")" + "\n" +
                "Resultado: " + arr[0] * arr[2] + "\n" +
                "Dividindo do maior valor (" + arr[2] + ") " + "Com o  menor valor: (" + arr[0] + ")" + "\n" +
                "Resultado: " + arr[2] / arr[0];

        }

        public void negativoOrPositivo()
        {

            int parar = 0;
            string resultado = "";
            do
            {

                Console.WriteLine("Digite um número: ");
                    parar = int.Parse(Console.ReadLine());


                if (parar >= 0) resultado = "positivo";
                if (parar < 0) resultado = "negativo";
                if (parar != -1) Console.WriteLine("O número que voce digitou é: " + resultado);
            } while (parar != -1);
        }

        public string armazenamento ()
        {


            ArrayList A = new ArrayList();
            ArrayList B = new ArrayList();


            int stop = 0;

            do
            {

                Console.WriteLine("Digite um número");
                stop = int.Parse(Console.ReadLine());

      

       
                if (stop >= 0) {

                    A.Add(stop);
                };



                if (stop < 0) {
                    B.Add(stop);
                };



                 

            } while (stop != -1);

            string Positivos = "";
            string Negativos = "";
            foreach (int i in A)
            {
                Positivos += i.ToString() + "\n";
            }
            foreach (int i in B)
            {
                Negativos += i.ToString() + "\n";

            }

            return "Números positivos: " + Positivos + "\n" + 
            "Números Negativos: " + Negativos + "\n";
        }
    }


}



