static void p1001(){
    /*
    int a, b, x;
    Console.Write("\nDigite um numero: \n");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("\nDigite outro numero: \n");
    b = Convert.ToInt32(Console.ReadLine());
    x = a + b;
    Console.Write("\nA soma dos números é igual a: "+ x + "\n");
    */
    int a, b, x;
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    x = a + b;  
    Console.Write("X = {0}\n", x);
}
static void p1002(){
    double r, a;
    r = Convert.ToDouble(Console.ReadLine());
    a = Math.Pow(r,2) * 3.14159;
    Console.Write("A = {0}\n",(a.ToString("N4")));
}

static void p1003(){
    int a, b, SOMA;
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    SOMA = a + b;
    Console.Write("\nSOMA = {0}\n",SOMA);
}

static void p1004(){
    int a, b, PROD;
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    PROD = a * b;
    Console.Write("\nPROD = {0} \n",PROD);
}
static void p1005(){
    double n1, n2, media;
    n1 = Convert.ToDouble(Console.ReadLine());
    n2 = Convert.ToDouble(Console.ReadLine());
    media = (n1 * 3.5 + n2 * 7.5) / (3.5 + 7.5);
    Console.Write("\nMEDIA = {0}",(media.ToString("N5")));
}

static void p1006(){
    double n1, n2, n3, media;
    n1 = Convert.ToDouble(Console.ReadLine());
    n2 = Convert.ToDouble(Console.ReadLine());
    n3 = Convert.ToDouble(Console.ReadLine());
    media = (n1 * 2.0 + n2 * 3.0 + n3 * 5.0) / (2.0 + 3.0 + 5.0);
    Console.Write("\nMEDIA = {0}",(media.ToString("N1")));
}

static void p1007(){
    int n1, n2, n3, n4, diferenca;
    n1 = Convert.ToInt32(Console.ReadLine());
    n2 = Convert.ToInt32(Console.ReadLine());
    n3 = Convert.ToInt32(Console.ReadLine());
    n4 = Convert.ToInt32(Console.ReadLine());
    diferenca = (n1 * n2 - n3 * n4);
    Console.Write("\nDIFERENÇA = {0}",(diferenca.ToString("N0")));
}

static void p1008(){
    int numerof, horast;
    double salario, horap;
    numerof = Convert.ToInt32(Console.ReadLine());
    horast = Convert.ToInt32(Console.ReadLine());
    horap = Convert.ToDouble(Console.ReadLine());
    salario = horast * horap;
    Console.Write("\nNUMBER = {0}",(numerof.ToString("N0")));
    Console.Write("\nSALARY = U$ {0}",(salario.ToString("N2")));
}
static void p1009(){
    string nome;
    double salario, vendas, total;
    nome = Convert.ToString(Console.ReadLine());
    salario = Convert.ToDouble(Console.ReadLine());
    vendas = Convert.ToDouble(Console.ReadLine());
    total = (vendas * 15)/100 + salario;
    Console.Write("\nTOTAL = R$ {0}",(total.ToString("N2")));
}

static void p1010(){
    int codigo1, quantidade1, codigo2, quantidade2;
    double valor1, valor2, total;
    string linha1, linha2;

    linha1 = Console.ReadLine();
    linha2 = Console.ReadLine();

    string[] vetor  = linha1.Split(' ');
    codigo1         = Convert.ToInt32(vetor[0]);
    quantidade1     = Convert.ToInt32(vetor[1]);
    valor1          = Convert.ToDouble(vetor[2]);

    vetor           = linha2.Split(' ');
    codigo2         = Convert.ToInt32(vetor[0]);
    quantidade2     = Convert.ToInt32(vetor[1]);
    valor2          = Convert.ToDouble(vetor[2]);

    total =(quantidade1 * valor1) + (quantidade2 * valor2);
    
    Console.Write("VALOR A PAGAR: R$ {0}\n",(total.ToString("N2")));

}

static void p1011(){
    int raio;
    const double PI = 3.14159;
    double total;
    raio = Convert.ToInt32(Console.ReadLine());
    total = (4.0/3) * PI * Math.Pow(raio,3.0);
    Console.Write("\n VOLUME = {0}",(total.ToString("N3")));

}

static void p1012(){
    double a, b, c;
    const double pi = 3.14159;
    string linha1;
    double tri, cir, tra, qua, ret;
    
    linha1 = Console.ReadLine();
    
    string[] vetor = linha1.Split(' ');
    a = Convert.ToDouble(vetor[0]);
    b = Convert.ToDouble(vetor[1]);
    c = Convert.ToDouble(vetor[2]);

    tri = a * c/2;
    cir = Math.Pow(c,2.0) * pi;
    tra = (b+a)*c/2;
    qua = b*b;
    ret = a*b;
    Console.Write("\n TRIANGULO: {0}\n CIRCULO: {1}\n TRAPEZIO: {2}\n QUADRADO: {3}\n RETANGULO: {4}\n",
    (tri.ToString("N3")),
    (cir.ToString("N3")),
    (tra.ToString("N3")),
    (qua.ToString("N3")),
    (ret.ToString("N3")));
}

static void p1013(){
    int a, b, c, maior2, maior;
    string linha1;
    linha1 = Console.ReadLine();
    string [] vetor = linha1.Split(' ');

    a = Convert.ToInt32(vetor[0]);
    b = Convert.ToInt32(vetor[1]);
    c = Convert.ToInt32(vetor[2]);
    maior2 = (a + b + Math.Abs(a - b))/2;
    maior = (maior2 + c + Math.Abs(maior2 - c))/2;
    Console.Write("{0} eh o maior",maior);
    
}

static void p1014(){
    int dis;
    double gas, med;
    dis = Convert.ToInt32(Console.ReadLine());
    gas = Convert.ToDouble(Console.ReadLine());
    med = dis/gas;
    Console.Write("{0} km/l",(med.ToString("N3")));
}
static void p1015(){
    /*double x, y, x1, x2, y1, y2, result;
    string linha1, linha2;

    linha1 = Console.ReadLine();
    linha2 = Console.ReadLine();

    string[] vetor  = linha1.Split(' ');
    x1       = Convert.ToDouble(vetor[0]);
    y1       = Convert.ToDouble(vetor[1]);

    string[] vetor1    = linha2.Split(' ');
    y2          = Convert.ToDouble(vetor1[0]);
    x2          = Convert.ToDouble(vetor1[1]);

    result = Math.Sqrt(Math.Pow(x=(x2 - x1),2) + Math.Pow(y=(y2 - y1),2));
    Console.Write("{0}\n",(result.ToString("N4")));
    */
    double distancia, x, y;

        String linha1 = Console.ReadLine();
        String linha2 = Console.ReadLine();

        string[] i = linha1.Split(' ');
        string[] j = linha2.Split(' ');

        double x1=double.Parse(i[0]);
        double y1=double.Parse(i[1]);
        double x2=double.Parse(j[0]);
        double y2=double.Parse(j[1]);
        
        
        distancia = Math.Sqrt(Math.Pow(x=(x2-x1),2) + Math.Pow(y=(y2-y1),2));

        Console.Write("{0:0.0000}",distancia);

}

static void p1016(){
    int x, total;

    x =  Convert.ToInt32(Console.ReadLine());
    total = x*2;
    Console.Write("{0} minutos\n",total);


}
static void p1017(){
    int tempo, vm;
    double km, resultado;
    
    tempo = Convert.ToInt32(Console.ReadLine());
    vm    = Convert.ToInt32(Console.ReadLine());
    km    = 12;

    resultado = tempo * vm / km;
    Console.Write("{0}",resultado.ToString("N3"));
}
static void p1018(){
    int n, nota100, nota50, nota20, nota10, nota5, nota2, nota1, resto;
    n = Convert.ToInt32(Console.ReadLine());

    nota100 = n/100;
    resto = n % 100;

    nota50 = resto/50;
    resto = resto % 50;

    nota20 = resto/20;
    resto = resto % 20;

    nota10 = resto/10;
    resto = resto % 10;

    nota5 = resto/5;
    resto = resto % 5;

    nota2 = resto/2;
    resto = resto % 2;

    nota1 = resto/1;
    resto = resto % 1;  

    Console.WriteLine(n);
    Console.WriteLine("{0} nota(s) de R$ 100",nota100);
    Console.WriteLine("{0} nota(s) de R$ 50",nota50);
    Console.WriteLine("{0} nota(s) de R$ 20",nota20);
    Console.WriteLine("{0} nota(s) de R$ 10",nota10);
    Console.WriteLine("{0} nota(s) de R$ 5",nota5);
    Console.WriteLine("{0} nota(s) de R$ 2",nota2);
    Console.WriteLine("{0} nota(s) de R$ 1",nota1);
}
static void p1019(){
    int n, h, m, s, resto;
    n = Convert.ToInt32(Console.ReadLine());

    h = n / 3600;
    resto = n % 3600;

    m = resto / 60;
    resto = resto % 60;

    s = resto;
    
    Console.WriteLine("{0}:{1}:{2}",h,m,s);
}
static void p1020(){
    int n, anos, meses, dias, resto;
    n = Convert.ToInt32(Console.ReadLine());

    anos = n / 365;
    resto = n % 365;

    meses = resto / 30;
    resto = resto % 30;

    dias = resto;

    Console.WriteLine("{0} ano(s)",anos);
    Console.WriteLine("{0} mes(es)",meses);
    Console.WriteLine("{0} dia(s)", dias);
}
static void p1021(){
    double n, moeda1, moeda50, moeda25, moeda10, moeda5, moeda01, resto, nota100, nota50, nota20, nota10, nota5, nota2;
    //int nota100, nota50, nota20, nota10, nota5, nota2;
     n = Convert.ToDouble(Console.ReadLine());

    nota100 = n/100;
    resto = n % 100;

    nota50 = resto/50;
    resto = resto % 50;

    nota20 = resto/20;
    resto = resto % 20;

    nota10 = resto/10;
    resto = resto % 10;

    nota5 = resto/5;
    resto = resto % 5;

    nota2 = resto/2;
    resto = resto % 2;

    moeda1 = resto/1;
    resto = resto % 1;

    moeda50 = resto /0.5;
    resto = resto % 0.50;

    moeda25 = resto / 0.25;
    resto = resto % 0.25;

    moeda10 = resto / 0.10;
    resto =  resto % 0.10;

    moeda5 = resto / 0.05;
    resto = moeda5 % 0.05;

    moeda01 = resto / 0.01;
    resto = resto % 0.01;

    Console.WriteLine("NOTAS:");
    Console.WriteLine("{0} nota(s) de R$ 100",nota100.ToString("N0"));
    Console.WriteLine("{0} nota(s) de R$ 50",nota50.ToString("N0"));
    Console.WriteLine("{0} nota(s) de R$ 20",nota20.ToString("N0"));
    Console.WriteLine("{0} nota(s) de R$ 10",nota10.ToString("N0"));
    Console.WriteLine("{0} nota(s) de R$ 5",nota5.ToString("N0"));
    Console.WriteLine("{0} nota(s) de R$ 2",nota2.ToString("N0"));
    Console.WriteLine("MOEDAS:");
    Console.WriteLine("{0} moeda(s) de R$ 1",moeda1.ToString("N0"));
    Console.WriteLine("{0} moeda(s) de R$ 0.50",moeda50.ToString("N0"));
    Console.WriteLine("{0} moeda(s) de R$ 0.25",moeda25.ToString("N0"));
    Console.WriteLine("{0} moeda(s) de R$ 0.10",moeda10.ToString("N0"));
    Console.WriteLine("{0} moeda(s) de R$ 0.05",moeda5.ToString("N0"));
    Console.WriteLine("{0} moeda(s) de R$ 0.01",moeda01.ToString("N0"));

}
    int prog;
    Console.Clear();

    do{
        Console.Write("\nGerenciador de programas:\n");
        Console.Write("\n\t| 0 para sair|\n Digite o programa desejado: ");
        prog = Convert.ToInt32(Console.ReadLine());

        switch( prog ){
            case 1001: p1001();     break;
            case 1002: p1002();     break;
            case 1003: p1003();     break;
            case 1004: p1004();     break;
            case 1005: p1005();     break;
            case 1006: p1006();     break;
            case 1007: p1007();     break;
            case 1008: p1008();     break;
            case 1009: p1009();     break;
            case 1010: p1010();     break;
            case 1011: p1011();     break;
            case 1012: p1012();     break;
            case 1013: p1013();     break;
            case 1014: p1014();     break;
            case 1015: p1015();     break;
            case 1016: p1016();     break;
            case 1017: p1017();     break;
            case 1018: p1018();     break;
            case 1019: p1019();     break;
            case 1020: p1020();     break;
            case 1021: p1021();     break;

            case 0:    Console.Write("\nObrigado por utilizar nosso Software\n"); break;
            default:    Console.Write("\nOpção Inválida\n");      break;

        }
 }  while(prog != 0);