using System;


namespace proyecto
{
    class Anualidad
    {
        private const double PORCENTAJE = 0.07;
        private double numCuotas;
        private double monto;
        private string mensaje;
        private double anualidad;
        public Anualidad(double numCuotas,double monto)
        {
            this.numCuotas = numCuotas;
            this.monto = monto;
        }

        public string calculoAnualidad()
        {
            anualidad = Math.Round(calcularAnualidad());
            mensaje = "El valor a pagar por año es de:$"+anualidad;
            return mensaje;
        }

        private double calcularAnualidad()
        {

            double potencia = Math.Pow((1+PORCENTAJE),numCuotas);
            double division = 1 / potencia;
            Console.WriteLine("Potencia: " + potencia);
            anualidad = ((monto*PORCENTAJE)/(1-division));
            Console.WriteLine("anualidad: " + anualidad);
            return anualidad;
        }
    }
}
