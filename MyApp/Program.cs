namespace MyApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /* int inteiro = 100;
            float real = 25.4f;

            //real = inteiro;
            //inteiro = (int) real;
            // string valorReal = real.ToString(); // não funciona
            //inteiro = int.Parse(valorReal);
            //inteiro = Convert.ToInt32(real);
            inteiro = int.Parse("255");
            //Console.WriteLine(valorReal); // não funciona
            Console.WriteLine(inteiro);
            Console.WriteLine(Convert.ToDouble(25.5)); */

            /* if(25 == 32)
            {
              Console.WriteLine("É igual");
            }else 
            {
              Console.WriteLine("É diferente!");
            }
              Console.WriteLine("Finalizou o programa....");
          } */

            string valor = "basilio";
            switch (valor)
            {
                case "joao": Console.WriteLine("Não é o cara!"); break;
                case "marcelo": Console.WriteLine("Não é o cara!"); break;
                case "andre": Console.WriteLine("É este!"); break;
                default: Console.WriteLine("Não encontrado!"); break;
            }
        }
    }
}