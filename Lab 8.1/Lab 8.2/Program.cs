using System;

public class Cuenta
{
    private string idCuenta;

    public Cuenta(string prmtIdCuenta)
    {
        this.idCuenta = prmtIdCuenta;  // Asignar valor al campo privado
        System.Console.WriteLine(
            "Constructor Clase Base para cuenta {0}", prmtIdCuenta);
    }

    public virtual void CalcularIntereses()
    {
        System.Console.WriteLine(
            "Cuenta.CalcularIntereses() efectuado para la cuenta {0}",
            this.idCuenta);
    }

    public string GetIdCuenta()  // Método corregido
    {
        return this.idCuenta;
    }
}

public class CuentaCorriente : Cuenta  // Cambio de nombre correcto de la clase base
{
    public CuentaCorriente(string prmtIdCorriente) : base(prmtIdCorriente)
    {
    }

    public override void CalcularIntereses()
    {
        System.Console.WriteLine(
            "CuentaCorriente.CalcularIntereses() efectuado para la cuenta {0}",
            GetIdCuenta());  // Usar el método correcto
    }
}

public class CuentaAhorro : Cuenta  // Clase corregida
{
    public CuentaAhorro(string prmtIdCuenta) : base(prmtIdCuenta)
    {
    }

    public override void CalcularIntereses()
    {
        System.Console.WriteLine(  // Corregir a 'WriteLine'
            "CuentaAhorro.CalcularIntereses() efectuado para la cuenta {0}",
            GetIdCuenta());  // Usar el método correcto
    }
}

internal class Program  // Nombre correcto para la clase 'Program'
{
    private static void Main(string[] args)
    {
        const string CUENTA = "100";
        Cuenta cuenta = new Cuenta(CUENTA);  // Instancia de la clase base
        CuentaCorriente cuentaCorriente = new CuentaCorriente(CUENTA);  // Instancia de CuentaCorriente
        CuentaAhorro cuentaAhorro = new CuentaAhorro(CUENTA);  // Instancia de CuentaAhorro

        cuenta.CalcularIntereses();
        cuentaCorriente.CalcularIntereses();
        cuentaAhorro.CalcularIntereses();
    }
}
