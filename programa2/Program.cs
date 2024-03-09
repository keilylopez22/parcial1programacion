namespace programa2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola bienvenidos!");
            Console.WriteLine("por favor ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("por favor ingrese su apellido");
            string apellido = Console.ReadLine();
            Console.Write("Ingrese el correo electrónico por ejemplo, gmail.com: ");
            string correo = Console.ReadLine();
            string GenerarCorreo = (nombre, apellido, correo);

            Console.WriteLine("El correo electrónico es: {0}", GenerarCorreo);

            Console.ReadLine(); 
        }
    }
}




        

        
   