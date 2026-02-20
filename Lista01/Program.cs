using System;

namespace Lista01
{
    class Program
    {
        static void Main(string[] args)
        {
            ////EXERCICIO 01
            Console.WriteLine("Meu primeiro programa em C#.");

            ////EXERCICIO 02
            //Console.WriteLine("Nome: Antonio");
            //Console.WriteLine("Idade: 28");
            //Console.WriteLine("Curso: ESW");

            //EXERCICIO 03
            //string mensagem = "Mensagem guardada em uma variavel.";
            //Console.WriteLine(mensagem);

            //EXERCICIO 04
            //int anoAtual = 2026;
            //Console.WriteLine($"Estamos no ano {anoAtual

            //EXERCICIO 05
            //Console.WriteLine("Primeira mensagem.");
            //Console.WriteLine("Segunda mensagem.");
            //Console.WriteLine("Terceira mensagem");

            //EXERCICIO 06
            //int idade = 28;
            //double altura = 1.68;
            //double peso = 88.5;
            //decimal salario = 5500.60m;
            //Console.WriteLine($"Idade: {idade}, Altura: {altura}, Peso: {peso}, Salario: {salario}");

            //EXERCICIO 07
            //int n1 = 10;
            //int n2 = 5;
            //Console.WriteLine($"Soma: {n1 + n2}");
            //Console.WriteLine($"Subtração: {n1 - n2}");
            //Console.WriteLine($"Multiplicação: {n1 * n2}");
            //Console.WriteLine($"Divisão: {n1 / n2}");

            //EXERCICIO 08
            //decimal valor = 199.99m;
            //Console.WriteLine($"Valor formatado: {valor.ToString("C2")}");

            //EXERCICIO 09
            //long populacaoBrasil = 214300000;
            //Console.WriteLine($"População: {populacaoBrasil}");

            //EXERCICIO 10
            //byte nivel = 10;
            //Console.WriteLine($"Nivel: {nivel}");

            //EXERCICIO 11
            //float temperatura = 36.5f;
            //Console.WriteLine($"Temperatura: {temperatura}");

            //EXERCICIO 12
            //int numeroBase = 10;
            //Console.WriteLine($"Dobro: {numeroBase * 2}, Triplo: {numeroBase * 3},");

            //EXERCICIO 13 e 14
            //string nome = "Antonio";
            //string sobrenome = "Neto";
            //string nomeCompleto = nome + " " + sobrenome;
            //Console.WriteLine($"Ola, {nome.ToUpper()}!");
            //Console.WriteLine($"Nome Completo: {nomeCompleto}");

            //EXERCIC0 15 e 16
            //string texto = "CSharp";
            //Console.WriteLine($"Tamanho> {texto.Length}");
            //Console.WriteLine($"Maiusculo: {texto.ToUpper()} | Minusculo: {texto.ToLower()}");

            //EXERCICIO 17
            //char inicial = 'A';
            //Console.WriteLine($"Inicial: {inicial}");

            //EXERCICIO 18
            //string frase = "Bora estudar Java";
            //string NovaFrase = frase.Replace("Java", "C#");
            //Console.WriteLine(NovaFrase);

            ////EXERCICIO 19
            //int minhaIdade = 28;
            //bool maiorIdade = minhaIdade >= 18;
            //Console.WriteLine($"E maior de idade? {maiorIdade}");

            //EXERCICIO 20 
            //bool temCartao = true;
            //bool saldoSuficiente = true;
            //bool podeComprar = temCartao && saldoSuficiente;
            //Console.WriteLine($"Pode comprar? {podeComprar}");

            //EXERCICIO 21
            //bool estaLogado = false;
            //Console.WriteLine($"Invertido: {!estaLogado}");

            //EXERCICIO 22
            //int a = 10, b = 20;
            //Console.WriteLine($"{a} == {b}: {a == b}");
            //Console.WriteLine($"{a} != {b}: {a != b}");

            //EXERCICIO 23
            //int numInt = 100;
            //long numLong = numInt;

            //EXERCICIO 24 E 25
            //double d = 9.99;
            //int i = (int)d;
            //Console.WriteLine($"Casting double para int: {i}");

            //EXERCICIO 26
            //decimal sal = 1500.00m;
            //float salFloat = (float)sal;

            //EXERCICIO 27
            //string valorTexto = "100";
            //int convertidoParse = int.Parse(valorTexto);
            //int convertidoConvert = Convert.ToInt32(valorTexto);
            //Console.WriteLine($"Strings convertidas: {convertidoParse} e {convertidoConvert}");

            //EXERCICIO 28
            //string textoNumero = "250";
            //int.TryParse(textoNumero, out int resultado);
            //Console.WriteLine($"Questão 28 - Convertido: {resultado}");

            //EXERCICIO 29
            //string textoErro = "abc";
            //bool deuCerto = int.TryParse(textoErro, out int resultadadoErro);
            //if (deuCerto)
            //{
            //    Console.WriteLine($"Sucesso: {resultadadoErro}");
            //} else
            //{
            //    Console.WriteLine($"Questão 29 - Erro: Não foi possivel converter 'abc' para numero.");
            //}

            //EXERCICIO 30
            //string valorTexto = "500.75";
            //double valorDouble = double.Parse(valorTexto);
            //int valorFinalInt = (int)valorDouble;
            //Console.WriteLine($"Questão 30 = Valor final: {valorFinalInt}");

            //EXERCICIO 31
            //int v1 = 10, v2 = 20, v3 = 30;
            //double media = (v1 + v2 + v3) / 3.0;
            //Console.WriteLine($"Questão 31 - Media: {media}");

            //EXERCICIO 32
            //decimal precoOriginal = 100.00m;
            //decimal desconto = 15.00m;
            //decimal precoFinal = precoOriginal - desconto;
            //Console.WriteLine($"Questão 32 - Preço final com desconto: {precoFinal:C2}");

            //EXERCICIO 33
            //double baseRetangulo = 10.5;
            //double alturaRetangulo = 5.0;
            //double area = baseRetangulo * alturaRetangulo;
            //Console.WriteLine($"Questão 33 - Area do Retangulo: {area}");

            //EXERCICIO 34
            //double distancia = 500;
            //double tempo = 5;
            //double velocidadeMedia = distancia / tempo;
            //Console.WriteLine($"Velocidade media: {velocidadeMedia} km/h");

            // EXERCICIO 35 a 37 e 49 a 50
            //char letra = 'A';
            //Console.WriteLine($"35. É igual a 'A'? {letra == 'A'}");

            //string fraseSub = "C# é incrível";
            //Console.WriteLine($"36. Primeiros 3: {fraseSub.Substring(0, 3)}");

            //string comEspaco = "   Olá   ";
            //Console.WriteLine($"37. Trim: '{comEspaco.Trim()}'");

            //string busca = "Aprendendo C# na DB1";
            //Console.WriteLine($"49. Contém 'DB1'? {busca.Contains("DB1")}");

            //string trocar = "Banana bacana";
            //Console.WriteLine($"50. Troca 'a' por '@': {trocar.Replace('a', '@')}");

            ////EXERCICIO 35
            //char letra = 'A';
            //Console.WriteLine($"35. A letra é 'A'? {letra == 'A'}");

            ////EXERCICIO 36
            //string palavra = "Programação";
            //Console.WriteLine($"36. Primeiras 3 letras: {palavra.Substring(0, 3)}");

            ////EXERCICIO 37
            //string textoComEspaco = "   C# é top   ";
            //Console.WriteLine($"37. Sem espaços: '{textoComEspaco.Trim()}'");

            ////EXERCICIO 38
            //int numInt = -5;
            //bool ehPositivo = numInt > 0;
            //Console.WriteLine($"38. O número {numInt} é positivo? {ehPositivo}");

            ////EXERCICIO 39
            //int numVerificar = 10;
            //bool ehPar = (numVerificar % 2 == 0);
            //Console.WriteLine($"39. O número {numVerificar} é par? {ehPar}");

            ////EXERCICIO  40
            //string s1 = "DB1", s2 = "db1";
            //Console.WriteLine($"40. São iguais? {s1.Equals(s2, StringComparison.OrdinalIgnoreCase)}");

            ////EXERCICIO 41
            //double valorDbl = 10.55;
            //Console.WriteLine($"41. {valorDbl} arredondado: {Math.Round(valorDbl)}");

            ////EXERCICIO 42
            //int num42 = 100;
            //Console.WriteLine($"42. Número como string: {num42.ToString()}");

            ////EXERCICIO 43
            //string textoDbl = "150,50";
            //double dblConvertido = Convert.ToDouble(textoDbl);
            //Console.WriteLine($"43. Convertido: {dblConvertido}");

            ////EXERCICIO 44
            //string in1 = "1000";
            //int.TryParse(in1, out int res1);
            //Console.WriteLine($"44. TryParse '1000': {res1}");

            ////EXERCICIO 45
            //string in2 = "dez";
            //bool sucesso = int.TryParse(in2, out int res2);
            //Console.WriteLine($"45. TryParse 'dez' funcionou? {sucesso}");

            ////EXERCICIO  46
            //decimal salarioBase = 3000m;
            //decimal novoSalario = salarioBase + (salarioBase * 0.10m);
            //Console.WriteLine($"46. Salário com 10% de aumento: {novoSalario:C2}");

            ////EXERCICIO  47
            //float hFloat = 1.75f;
            //double hDouble = (double)hFloat;
            //Console.WriteLine($"47. Float para Double: {hDouble}");

            ////EXERCICIO 48
            //long muitoGrande = 9223372036854775807;
            //int convertidoEstouro = (int)muitoGrande;
            //Console.WriteLine($"48. O long virou isso no int (estouro): {convertidoEstouro}");

            ////EXERCICIO  49
            //string busca = "Desenvolvedor C#";
            //Console.WriteLine($"49. Contém 'C#'? {busca.Contains("C#")}");

            ////EXERCICIO 50
            //string fraseA = "A aranha arranha a jarra";
            //Console.WriteLine($"50. Replace: {fraseA.Replace('a', '@')}");

            ////EXERCICIO 51
            //bool ativo = true;
            //Console.WriteLine($"51. Invertido: {!ativo}");

            ////EXERCICIO 52
            //int n1 = 100, n2 = 200;
            //Console.WriteLine($"52. {n1} > {n2}? {n1 > n2}");

            ////EXERCICIO 53
            //string strVazia = "";
            //Console.WriteLine($"53. Tamanho da string vazia: {strVazia.Length}");

            ////EXERCICIO 54
            //decimal valorDec = 15.8m;
            //int vInt = (int)Math.Round(valorDec);
            //Console.WriteLine($"54. Decimal arredondado para int: {vInt}");

            ////EXERCICIO 55
            //double numRaiz = 81;
            //Console.WriteLine($"55. Raiz de {numRaiz} é: {Math.Sqrt(numRaiz)}");

            ////EXERCICIO 56
            //string numStr1 = "10", numStr2 = "50";
            //int somaFinal = int.Parse(numStr1) + int.Parse(numStr2);
            //Console.WriteLine($"56. Soma das strings convertidas: {somaFinal}");

            ////EXERCICIO 57
            ////byte b = 300;  sublinha de vermelho porque o limite é 255.
            //Console.WriteLine("57. O tipo byte só suporta até 255. Valor 300 gera erro.");

            ////EXERCICIO 58
            //int iPequeno = 500;
            //long lGrande = iPequeno;
            //Console.WriteLine($"58. Int {iPequeno} agora é Long {lGrande}");

            ////EXERCICIO 59
            //double dOriginal = 12.5;
            //float fFinal = (float)dOriginal;
            //Console.WriteLine($"59. Double para Float: {fFinal}");

            ////EXERCICIO 60
            //string nome60 = "Seu Nome";
            //int idade60 = 25;
            //decimal salario60 = 4500.50m;
            //Console.WriteLine($"60. RELATÓRIO: Nome: {nome60} | Idade: {idade60} | Salário: {salario60:C2}");

        }
    }
}