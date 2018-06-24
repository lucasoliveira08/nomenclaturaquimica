using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quimica
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            string elemento1 = "";
            string elemento2 = "";
            int numelemento2 = 0;
            string caracteree21 = "";
            string caracteree22 = "";
            string caracteree23 = "";
            string elemento3 = "";
            int numelemento3 = 0;
            string caracteree31 = "";
            string caracteree32 = "";
            string caracteree33 = "";
            int opcaoelemento2 = 0;
            int opcaoelemento3 = 0;
            int numelemento2lucas = 0;
            int numelemento3lucas = 0;

            char existeprop = ' ';
            string elemento4 = "";
            int opcaoelemento4 = 0;
            int numelemento4 = 0;
            char existebut = ' ';
            char existebut2 = ' ';
            char existebut12 = ' ';
            char existebut3 = ' ';
            int numelemento4lucas = 0;
            int numelemento44lucas = 0;
            int numelemento444lucas = 0;
            int numelemento445lucas = 0;
            string caracteree41 = "";
            string caracteree42 = "";
            string caracteree43 = "";


            while (opcao != 12)
            {
                Console.Title = ("Projeto V1");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(@"             _____           _      _         __      ____ ");
                Console.WriteLine(@"            |  __ \         (_)    | |        \ \    / /_ |");
                Console.WriteLine(@"            | |__) | __ ___  _  ___| |_ ___    \ \  / / | |");
                Console.WriteLine(@"            |  ___/ '__/ _ \| |/ _ \ __/ _ \    \ \/ /  | |");
                Console.WriteLine(@"            | |   | | | (_) | |  __/ || (_) |    \  /   | |");
                Console.WriteLine(@"            |_|   |_|  \___/| |\___|\__\___/      \/    |_|");
                Console.WriteLine(@"                           _/ |                            ");
                Console.WriteLine(@"                          |__/                             ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n                                                       Desenvolvido por Lucas G");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.WriteLine("[12] - Sair do programa");
                Console.WriteLine("-------------------------");
                Console.Write("\nInsira o número de carbonos do elemento: ");
                try
                {
                    opcao = Int32.Parse(Console.ReadLine());

                    switch (opcao)
                    {

                        case 1:
                            met(elemento1);
                            break;
                        case 2:
                            et(opcaoelemento2, elemento2, numelemento2, caracteree21, caracteree22, caracteree23);
                            break;
                        case 3:
                            prop(opcaoelemento3, elemento3, numelemento3, existeprop, numelemento2lucas, numelemento3lucas, caracteree31, caracteree32, caracteree33);
                            break;
                        case 4:
                            but(opcaoelemento4, elemento4, numelemento4, existebut, existebut12, existebut2, existebut3, numelemento4lucas, numelemento44lucas, numelemento445lucas, numelemento444lucas, caracteree41, caracteree42, caracteree43);
                            break;
                        case 12:
                            sairPrograma();
                            break;
                        default:
                            nadaTeclado();
                            break;


                    }
                }
                catch
                {
                    Console.Write("\nInsira apenas digitos válidos! Aperte qualquer tecla para retornar...");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        private static void sairPrograma()
        {
            Console.WriteLine();
            Console.WriteLine("Você saiu do programa, digite qualquer tecla para continuar...");


        }

        private static void met(string elemento1)
        {

            try { 

            elemento1 = "Met";

                Console.WriteLine("\nSeu elemento se chama: " + elemento1 + "ano");
                Console.Write("\nAperte qualquer tecla para retornar...");
            }

            
            
            catch
            {
                Console.Write("\nInsira apenas digitos válidos! Aperte qualquer tecla para retornar...");
            }

        }

        private static void et(int opcaoelemento2, string elemento2, int numelemento2, string caracteree21, string caracteree22, string caracteree23)
        {
            try
            {
                Console.Write("Insira em números, se existe ligação primária, secundária ou terciária: ");
                opcaoelemento2 = Int32.Parse(Console.ReadLine());


                elemento2 = "Et";

                if (opcaoelemento2 == 1)
                {
                    caracteree21 = "ano";
                    Console.WriteLine("\nSeu elemento se chama: " + elemento2 + "-" + "1" + "-" + caracteree21);
                }

                else if (opcaoelemento2 == 2)
                {
                    caracteree22 = "eno";
                    Console.WriteLine("\nSeu elemento se chama: " + elemento2 + "-" + "1" + "-" + caracteree22);

                }

                else if (opcaoelemento2 == 3)
                {
                    caracteree23 = "ino";
                    Console.WriteLine("\nSeu elemento se chama: " + elemento2 + "-" + "1" + "-" + caracteree23);
                }

                Console.Write("\nAperte qualquer tecla para retornar...");
            }
            catch
            {
                Console.Write("\nInsira apenas digitos válidos! Aperte qualquer tecla para retornar...");
            }

            }
            


        private static void prop(int opcaoelemento3, string elemento3, int numelemento3, char existeprop, int numelemento2lucas, int numelemento3lucas, string caracteree31, string caracteree32, string caracteree33)
        {
            try
            {
                Console.Write("Insira em números, se existe ligação primária, secundária ou terciária: ");
                opcaoelemento3 = Int32.Parse(Console.ReadLine());

                elemento3 = "Prop";

                if (opcaoelemento3 == 1)
                {
                    caracteree31 = "ano";
                    Console.WriteLine("\nSeu elemento se chama: " + elemento3 + caracteree31);
                }

                else if (opcaoelemento3 == 2)
                {
                    Console.Write("Insira a posição da primeira ligação: ");
                    numelemento3 = Int32.Parse(Console.ReadLine());
                    Console.Write("Existe mais alguma ligação? Responda S (SIM) ou N (NÃO): ");
                    existeprop = char.Parse(Console.ReadLine());

                    if(existeprop == 'S' || existeprop == 's') { 
                    Console.Write("Insira a posição da segunda ligação: ");
                    numelemento2lucas = Int32.Parse(Console.ReadLine());
                    caracteree32 = "eno";
                    Console.WriteLine("\nSeu elemento se chama: " + elemento3 + "-" + numelemento3 + "," + numelemento2lucas + "-" + caracteree32);

                    }
                    else { 
                    caracteree32 = "eno";
                    Console.WriteLine("\nSeu elemento se chama: " + elemento3 + "-" + numelemento3 + "-" + caracteree32);
                    }
                }

                else if (opcaoelemento3 == 3)
                {
                    Console.Write("Insira a posição da primeira ligação: ");
                    numelemento3 = Int32.Parse(Console.ReadLine());
                    Console.Write("Existe mais alguma ligação? Responda S (SIM) ou N (NÃO): ");
                    existeprop = char.Parse(Console.ReadLine());

                    if (existeprop == 'S' || existeprop == 's')
                    {
                        Console.Write("Insira a posição da segunda ligação: ");
                        numelemento2lucas = Int32.Parse(Console.ReadLine());
                        caracteree33 = "ino";
                        Console.WriteLine("\nSeu elemento se chama: " + elemento3 + "-" + numelemento3 + "," + numelemento2lucas + "-" + caracteree33);


                    }
                    else if (existeprop == 'N' || existeprop == 'n')
                    {
                        caracteree33 = "ino";
                        Console.WriteLine("\nSeu elemento se chama: " + elemento3 + "-" + numelemento3 + "-" + caracteree33);
                    }

                }

                Console.Write("\nAperte qualquer tecla para retornar...");
            }
            catch
            {
                Console.Write("\nInsira apenas digitos válidos! Aperte qualquer tecla para retornar...");
            }

        }

        private static void but(int opcaoelemento4, string elemento4, int numelemento4, char existebut, char existebut12, char existebut2, char existebut3, int numelemento4lucas, int numelemento44lucas, int numelemento445lucas, int numelemento444lucas, string caracteree41, string caracteree42, string caracteree43)
        {
            try
            {
                Console.Write("Insira em números, se existe ligação primária, secundária ou terciária: ");
                opcaoelemento4 = Int32.Parse(Console.ReadLine());

                elemento4 = "But";

                if (opcaoelemento4 == 1)
                {
                    caracteree41 = "ano";
                    Console.WriteLine("\nSeu elemento se chama: " + elemento4 + caracteree41);
                }

                else if (opcaoelemento4 == 2)
                {
                    Console.Write("Insira a posição da primeira ligação: ");
                    numelemento4 = Int32.Parse(Console.ReadLine());
                    Console.Write("Existe mais alguma ligação? Responda S (SIM) ou N (NÃO): ");
                    existebut = char.Parse(Console.ReadLine());

                    if (existebut == 'S' || existebut == 's')
                    {
                        Console.Write("Insira a posição da segunda ligação: ");
                        numelemento44lucas = Int32.Parse(Console.ReadLine());
                        caracteree42 = "eno";
                        Console.Write("Existe mais alguma ligação? Responda S (SIM) ou N (NÃO): ");
                        existebut12 = char.Parse(Console.ReadLine());
                        if (existebut12 == 'S' || existebut12 == 's')
                        {
                            Console.Write("Insira a posição da terceira ligação: ");
                            numelemento445lucas = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("\nSeu elemento se chama: " + elemento4 + "-" + numelemento4 + "," + numelemento44lucas + "," + numelemento445lucas + "-" + caracteree42);

                        }
                        else { 
                            Console.WriteLine("\nSeu elemento se chama: " + elemento4 + "-" + numelemento4 + "," + numelemento44lucas + "-" + caracteree42);
                        }
                    }
                    else if (existebut == 'N' || existebut == 'n')
                    {
                        caracteree42 = "eno";
                        Console.WriteLine("\nSeu elemento se chama: " + elemento4 + "-" + numelemento4 + "-" + caracteree42);
                    }
                }

                else if (opcaoelemento4 == 3)
                {
                    Console.Write("Insira a posição da primeira ligação: ");
                    numelemento4 = Int32.Parse(Console.ReadLine());
                    Console.Write("Existe mais alguma ligação? Responda S (SIM) ou N (NÃO): ");
                    existebut = char.Parse(Console.ReadLine());

                    if (existebut == 'S' || existebut == 's')
                    {
                        Console.Write("Insira a posição da segunda ligação: ");
                        numelemento4lucas = Int32.Parse(Console.ReadLine());
                        caracteree43 = "ino";
                        Console.Write("Existe mais alguma ligação? Responda S (SIM) ou N (NÃO): ");
                        existebut2 = char.Parse(Console.ReadLine());

                        if (existebut2 == 'S' || existebut2 == 's')
                        {
                            Console.Write("Insira a posição da terceira ligação: ");
                            numelemento444lucas = Int32.Parse(Console.ReadLine());
                            caracteree43 = "ino";
                                Console.WriteLine("\nSeu elemento se chama: " + elemento4 + "-" + numelemento4 + "," + numelemento4lucas + "," + numelemento444lucas + "-" + caracteree43);
                            }
                        else if (existebut2 == 'N' || existebut2 == 'n')
                        {
                                Console.WriteLine("\nSeu elemento se chama: " + elemento4 + "-" + numelemento4 + "-" + numelemento4lucas + "-" + caracteree43);
                            }


                        }else if (existebut == 'N' || existebut == 'n')
                        
                        {
                            caracteree43 = "ino";
                            Console.WriteLine("\nSeu elemento se chama: " + elemento4 + "-" + numelemento4 + "-" + caracteree43);
                        }
                    }
                    else
                    {
                        caracteree43 = "ino";
                        Console.WriteLine("\nSeu elemento se chama: " + elemento4 + "-" + numelemento4 + "-" + caracteree43);
                    }

           

                Console.Write("\nAperte qualquer tecla para retornar...");
            }
            catch
            {
                Console.Write("\nInsira apenas digitos válidos! Aperte qualquer tecla para retornar...");
            }

        }



        private static void nadaTeclado()
        {
            Console.WriteLine();
            Console.Write("Número não reconhecido, digite apenas no intervalo de (1-10), aperte qualquer tecla para retornar ao menu...");

        }
    }
}
