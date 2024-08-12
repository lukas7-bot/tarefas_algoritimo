
using System.Reflection;

Console.WriteLine("digite o valor da nota1:");
int nota1 = int.Parse(Console.ReadLine());





if(nota1 > 100 || nota1 < 0)
 
{
Console.WriteLine("valor invalido");
}


Console.WriteLine("digiteo valor da nota2:");
int nota2 = int.Parse(Console.ReadLine());

Console.WriteLine("digite o valor da nota3:");
int nota3 = int.Parse(Console.ReadLine());

Console.WriteLine("digite o valor da nota4:");
int nota4 = int.Parse(Console.ReadLine());

float media = (2*nota1 + 2*nota2 + 3*nota3 + 3*nota4) / 10f;
media = (float)Math.Round(media);
Console.WriteLine("media da diciplina: " + media);

if(media >= 60){
Console.WriteLine("aprovado");
return;
}

else if (media < 20){
    Console.WriteLine("reprovado");
    return;
    }

    
    else{
        Console.WriteLine("recuperação");
        float previsao = 120 - media;
        Console.WriteLine($"precisa tirar previsao {previsao} para passar");
        }

        Console.WriteLine("digite a nota da prova final:");
        int provaFinal = int.Parse(Console.ReadLine());

        float mediaFinal = (media + provaFinal) / 2f;
        mediaFinal = (float)Math.Round(media);
        Console.WriteLine("media final: " + mediaFinal);

