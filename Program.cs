Console.Clear();

Console.WriteLine("---RAIO E TROVÃO---");

double diferenca;
double distancia;

CalcularDistancia();

void CalcularDistancia()
{
    Console.WriteLine("Insira a diferença de tempo entre o raio e o trovão...");
    diferenca = Convert.ToDouble(Console.ReadLine());
    
    distancia = (diferenca * 340.29) / 1000;
    Console.WriteLine("Aproximadamente: " + distancia.ToString("N2") + "km");
}