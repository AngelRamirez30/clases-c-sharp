
class Persona
{
    // Propiedades de nuestra clase Persona
    public string Nombre;
    public string Apellido;
    public int Edad;

    // Constructor de nuestra clase Persona
    public Persona(string nombre, string apellido, int edad)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
    }

    // Metodos de nuestra clase Persona
    public void Saludar()
    {
        //Console.WriteLine("Hola, soy " + Nombre + " " + Apellido + " y tengo " + Edad + " años.");
        Console.WriteLine($"Hola, soy {Nombre} {Apellido} y tengo {Edad} años.");
    }

    public void CumplirAnios()
    {
        Edad++;
        Console.WriteLine($"Feliz cumpleaños {Nombre}! Ahora tienes {Edad} años.");
    }
}