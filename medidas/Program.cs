class Program
{
    static void Main(string[] args)
    {
        int option = 0;
            Retangulo x;
            x = new Retangulo();

        // Pedir medidas ao usuário
        Console.WriteLine("Informe o comprimento do local (em metros):");
        double comprimento = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Informe a largura do local (em metros):");
        double largura = Convert.ToDouble(Console.ReadLine());

        // Criar objeto retângulo
        Retangulo local = new Retangulo(comprimento, largura);

        // Calcular área e perímetro
        double area = local.CalcularArea();
        double perimetro = local.CalcularPerimetro();

        Console.WriteLine($"Área do local: {area} metros quadrados");
        Console.WriteLine($"Perímetro do local: {perimetro} metros");

        // Calcular quantidade de pisos e rodapés
        double quantidadePisos = area; // Considerando que cada piso cobre 1 metro quadrado
        double quantidadeRodapes = perimetro; // Considerando que o rodapé cobre todo o perímetro

        Console.WriteLine($"Quantidade de pisos necessários: {quantidadePisos}");
        Console.WriteLine($"Quantidade de rodapés necessários: {quantidadeRodapes}");
    }
}