using System.Runtime.InteropServices;

void soma(float a, float b){
    float resultado = a + b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}

soma(20,9);

void subtracao(float a, float b){
    float resultado = a - b;
    Console.WriteLine($"{a} - {b} = {resultado}");
}
subtracao(20,9);

void multiplicacao(float a, float b){
    float resultado = a * b;
    Console.WriteLine($"{a} * {b} = {resultado}");
}
multiplicacao(20,9);

void divisao(float a, float b){

    if(b==0){
        Console.WriteLine("erro de divisão por zero");
        return;
    }

    float resultado = a / b;
    Console.WriteLine($"{a} / {b} = {resultado}");
}
divisao(50,5);

float a;
float b;

void digitarAeB(string operacao){

    Console.WriteLine(operacao);


    Console.WriteLine("digite o valor de a:");
    a = float.Parse(Console.ReadLine());
    Console.WriteLine("digite o valor de b:");
    b = float.Parse(Console.WriteLine());
    }




    Console.WriteLine("--- calculadora ---");
    Console.WriteLine("1 - soma");
    Console.WriteLine("2 - subtração");
    Console.WriteLine("3 - multiplicação");
    Console.WriteLine("4 - divisão");
    Console.WriteLine("5 - sair");
    Console.WriteLine("--------------------");
    Console.WriteLine("digite a opção desejada:");

    int opcao = int.Parse(Console.WriteLine());

 if(opcao == 1){
    digitarAeB("soma");
    soma(a,b);
}

else if(opcao == 2){
    digitarAeB("subtração");
    subtracao(a,b);
}

else if(opcao == 3){
    digitarAeB("multiplicacao");
    multiplicacao(a,b);
}

else if(opcao == 4){
    digitarAeB("divisao");
    divisao(a,b);
}
else if(opcao == 5){
    digitarAeB("sair");
   Console.WriteLine("saindo...");
}
else {
    Console.WriteLine("opção invalida");
}