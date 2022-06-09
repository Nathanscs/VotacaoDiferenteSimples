using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int voto, total=0, jair=0, carlos=0, neves=0;
            decimal nulo=0, branco=0, nuloTotal, brancoTotal;
            do{
                Console.WriteLine("1- Candidato Jair Rodrigues\n2- Candidato Carlos Luz\n3- Candidato Neves Rocha\n4- Nulo\n5- Branco\n6- Terminar\n\nEntre com o seu voto:");
                voto=int.Parse(Console.ReadLine());

                if(voto==1)
                {
                    jair++;
                    total++;
                }
                if(voto==2)
                {
                    carlos++;
                    total++;
                }
                if(voto==3)
                {
                    neves++;
                    total++;
                }
                if(voto==4)
                {
                    nulo++;
                    total++;
                }
                if(voto==5)
                {
                    branco++;
                    total++;
                }
            }while(voto != 6);

            nuloTotal = (nulo/total)*100;
            brancoTotal = (branco/total)*100;

            if(jair > carlos)
	        {
                if(jair > neves)
                {
                    if(jair > branco)
                    {
                        Console.WriteLine("Jair Rodrigues: {0}\nCarlos Luz: {1}\nNeves Rocha: {2}\nNulo: {3}%\nBranco: {4}%\n\nJair Venceu", jair, carlos, neves, nuloTotal, brancoTotal);
                    }
                    else
                    {
                        Console.WriteLine("Jair Rodrigues: {0}\nCarlos Luz: {1}\nNeves Rocha: {2}\nNulo: {3}%\nBranco: {4}%\n\nBranco Venceu", jair, carlos, neves, nuloTotal, brancoTotal);
                    }
                }
                if(jair < neves)
                {
                    Console.WriteLine("Jair Rodrigues: {0}\nCarlos Luz: {1}\nNeves Rocha: {2}\nNulo: {3}%\nBranco: {4}%\n\nNeves Venceu", jair, carlos, neves, nuloTotal, brancoTotal);
                }
                if(jair==neves)
                {
                    if(jair==branco)
                    {
                        Console.WriteLine("Jair Rodrigues: {0}\nCarlos Luz: {1}\nNeves Rocha: {2}\nNulo: {3}%\nBranco: {4}%\n\nEmpatou entre Jair, Neves e Branco", jair, carlos, neves, nuloTotal, brancoTotal);
                    }
                    else
                    {
                    Console.WriteLine("Jair Rodrigues: {0}\nCarlos Luz: {1}\nNeves Rocha: {2}\nNulo: {3}%\nBranco: {4}%\n\nEmpatou entre Jair e Neves", jair, carlos, neves, nuloTotal, brancoTotal);
                    }
                }
	        }
            if(nulo > jair)
            {
                if(nulo > carlos)
                {
                    if(nulo > neves)
                    {
                            Console.WriteLine("Jair Rodrigues: {0}\nCarlos Luz: {1}\nNeves Rocha: {2}\nNulo: {3}%\nBranco: {4}%\n\nO numero maior de votos foram nulos", jair, carlos, neves, nuloTotal, brancoTotal);
                    }
                    else
                    {
                        Console.WriteLine("Jair Rodrigues: {0}\nCarlos Luz: {1}\nNeves Rocha: {2}\nNulo: {3}%\nBranco: {4}%\n\nNeves Venceu", jair, carlos, neves, nuloTotal, brancoTotal);
                    }
                }
            }
            if(branco > jair)
            {
                if(branco > carlos)
                {
                    if(branco > neves)
                    {
                            Console.WriteLine("Jair Rodrigues: {0}\nCarlos Luz: {1}\nNeves Rocha: {2}\nNulo: {3}%\nBranco: {4}%\n\nO numero maior de votos foram brancos", jair, carlos, neves, nuloTotal, brancoTotal);
                    }
                    else
                    {
                        Console.WriteLine("Jair Rodrigues: {0}\nCarlos Luz: {1}\nNeves Rocha: {2}\nNulo: {3}%\nBranco: {4}%\n\nNeves Venceu", jair, carlos, neves, nuloTotal, brancoTotal);
                    }
                }
            }
        }
    }
}
