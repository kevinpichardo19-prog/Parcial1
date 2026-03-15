namespace autos_Pro
{
    using System;
}
          class Auto
    {
       
        public string marca;
        public string modelo;
        public int ruedas;
        public int Año;

       
        public Auto(string a, string b, int c, int d)
        {
            this.marca = a;
            this.modelo = b;
            this.ruedas = c;
            this.Año = d;
        }

        // Metodo arrancar
        public void arrancar()
        {
            Console.WriteLine(this.marca + ": Arranco");
        }

        // Metodo frenar
        public void frenar()
        {
            Console.WriteLine(this.marca + ": Freno");
        }
    }

    class Program
    {
        static void Main()
        {
            
            Auto autoPrincipal = new Auto("Toyota", "Corolla", 4, 2025);

            Console.WriteLine("Antes de modificar:");
            Console.WriteLine(autoPrincipal.marca + " " + autoPrincipal.modelo);

            // Modificar propiedad
            autoPrincipal.marca = "Honda";

            Console.WriteLine("Despues de modificar:");
            Console.WriteLine(autoPrincipal.marca + " " + autoPrincipal.modelo);

            Console.WriteLine();

            
            Auto auto1 = new Auto("Toyota", "Corolla", 4, 2025);
            Auto auto2 = new Auto("Honda", "Civic", 4, 2024);
            Auto auto3 = new Auto("Ford", "Focus", 4, 2023);

            // Arreglo de objetos
            Auto[] autos = { auto1, auto2, auto3 };

            // Ejecutar metodos
            auto1.arrancar();
            auto2.arrancar();
            auto1.frenar();

            Console.WriteLine();

            Console.WriteLine("Lista de autos:");

            for (int i = 0; i < autos.Length; i++)
            {
                Console.WriteLine(auto3.marca + " " + auto3.modelo + " " + auto3.Año);
            }
        }
    }
