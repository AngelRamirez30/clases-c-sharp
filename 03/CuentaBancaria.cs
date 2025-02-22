class CuentaBancaria
{
    private double Saldo;

    public void Depositar(double monto)
    {
        Saldo += monto;
    }

    public void Retirar(double monto)
    {
        Saldo -= monto;
    }

    public void ConsultarSaldo()
    {
        Console.WriteLine($"Su saldo es: ${Saldo}");
    }
}