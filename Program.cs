// Exercício do curso do Nélio Alves "Media Alunos Vetor"
// Fazer um programa para ler um conjunto de N nomes de alunos, bem como as notas que eles tiraram no 1º e 2º semestres.
// Cada uma dessas informações deve ser armazenada em um vetor. Depois, imprimir os nomes dos alunos aprovados,
// considerando aprovados aqueles cuja média das notas seja maior ou igual a seis.


int N = int.Parse(Console.ReadLine());
string [] Nomes = new string[N];
double [] Nota1 = new double[N];
double [] Nota2 = new double[N];

// Comando para leitura de daos;
for (int i = 0; i < N; i ++)
{
    string [] X = Console.ReadLine().Split(' ');
    Nomes[i] = X[0];
    Nota1[i] = double.Parse(X[1]);
    Nota2[i] = double.Parse(X[2]);
}
Console.WriteLine("Alunos aprovados: ");

// Comando para calcular a média e mostrar na tela os alunos aprovados;
for (int i =  0; i < N; i ++)
{
    double Media = (Nota1[i] + Nota2[i]) / 2;
    if (Media >= 6.0)
    Console.WriteLine(Nomes[i]);
}