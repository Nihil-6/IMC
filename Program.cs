double altura, peso , imc;

Console.Write("Digite sua Altura: Altura (m)..: ");

altura = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite seu Peso: Peso (kg)...: ");

peso = Convert.ToDouble(Console.ReadLine());

imc = peso / Math.Pow(altura, 2);

Console.WriteLine($"\nIMC: {imc:N1} kg/m²");