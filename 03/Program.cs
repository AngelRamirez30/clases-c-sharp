
class Program
{
    static void Main(string[] args)
    {
        CuentaBancaria cuenta = new CuentaBancaria();
        int opcion;
        do{
            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Retirar");
            Console.WriteLine("3. Consultar saldo");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());
            double monto;
            switch(opcion)
            {
                case 1:
                Console.Write("Monto a depositar: ");
                    monto = double.Parse(Console.ReadLine());
                    cuenta.Depositar(monto);
                    break;
                case 2:
                    Console.Write("Monto a retirar: ");
                    monto = double.Parse(Console.ReadLine());
                    cuenta.Retirar(monto);
                    break;
                case 3:
                    cuenta.ConsultarSaldo();
                    break;
                case 4:
                    Console.WriteLine("Cerrando programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }while(opcion != 4);
    }
}