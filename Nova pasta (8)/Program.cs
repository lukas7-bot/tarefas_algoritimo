bool Resposta()
{
    inicioPergunta:
    string resposta = Console.ReadLine();

    if(resposta == "s")
    {
        return true;
    }
    else if(resposta == "n")
   {
    return false;
   }
   else
   {
    Console.WriteLine("não entendi, responda apenas s/n");
    goto inicioPergunta;
   }

}
Console.WriteLine("quer jogar um jogo? s/n");
if(Resposta() == false) 
{
    goto finalJogo;
}
   inicioJogo:

   int menor = 0;
   int maior = 100;
   int numTentativas = 10;
   bool jogoRodando = true;

   Random rand = new Random ();
   int sorteado = rand.Next(menor, maior + 1);
   Console.WriteLine($"pensei em um número entre {menor} e {maior}. Tente adivinhar");

   while(jogoRodando)
   {
    Console.WriteLine($"tentativa {numTentativas}: ");
    int numDigitando = int.Parse(Console.ReadLine());
    if(numDigitando < sorteado)
    {
        Console.WriteLine("Muinto baixo. ");
        numTentativas--;
    }
    else if(numDigitando > sorteado)
    {
        Console.WriteLine("Muinto alto. ");
        numTentativas--;
    }
    else
    {
        Console.WriteLine("parabéns! voce acertou!");
        jogoRodando = false;
    }

    if(numTentativas == 0)
    {
        Console.WriteLine("acabaram suas tentativas.");
        jogoRodando = false;
    }
   }

Console.WriteLine("quer jogar um jogo? s/n");
if(Resposta() == true)
{
    goto inicioJogo;
}
finalJogo:
Console.WriteLine("então até a proxima!");
