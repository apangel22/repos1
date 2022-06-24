using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using minameSp;

namespace minameSp
{
  class Persona 
    {
        
        private int ii1;
        internal int ii2;
        public int getInt() {
            return ii1; 
        }
        public void setInt(int ii1)
        {
            this.ii1 = ii1;
        }
    }

    }

class Persona2 : Persona
{

}

namespace Prueba1
{
    internal class Program
    {
        enum Dias {
            Lunes = 1,
            Martes = 2,
            Miercoles = 3,
            Jueves = 4,
            Viernes = 5,
        }
        struct miestructura {
            public String nombre;
            public int edad;
        }
        // Metodos en Clase Abstracta
        // new oculta los metodos
        // interface funciona igual que una clase abstracta pero solo se pueden declarar metodos, no permite tener cuerpo
        abstract class Humano
        {
            public abstract void Comparar();
        }
       
        class Humano2 : Humano{
       
            /*int Retornovalor()
             {
                 return 123;
             }*/
            public override void Comparar()
            {
                Console.WriteLine("Ingrese un valor: ");
                int in1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese un segundo valor: ");
                int in2 = Convert.ToInt32(Console.ReadLine());
                if (in1 == in2)
                {
                    Console.WriteLine("Son Iguales");
                }
                else
                {
                    Console.WriteLine("No son Iguales");
                }
                Console.ReadKey();

            }
        }
    
        // Metodos Clases Heredadas
        // overrride sobre-escribe un metodo 
        // virtual permite a overrride sobre-escribir metodos heredados
        // new oculta el metodo
         class ClaseA { 
            public virtual void Imprimir()
            {
                Console.WriteLine("Soy Clase A");
            }
        }
        class ClaseB : ClaseA{
            public override void Imprimir()
            {
                Console.WriteLine("Soy Clase B");
            }
        }
        class ClaseC : ClaseB{
            public override void Imprimir() { 
                Console.WriteLine("Soy Clase C");
            }
        }
   

        public static void Main(string[] args)
        {
            string txt;
            string txt2;
            // Texto

            System.Console.WriteLine("Bienvenido");
            // Texto de Teclado
            Console.WriteLine("Ingrese su Nombre: ");
            txt = Console.ReadLine();
            Console.WriteLine("Ingrese su Edad: ");
            txt2 = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("El nombre ingresado fue: " + txt);
            Console.WriteLine("La edad ingresada fue: " + txt2);
            System.Console.ReadKey();

            Console.WriteLine("");
            // Conversion Explicita
            Console.WriteLine("Convercion Explicita");
            short a = 256;
            byte b = 0;
            b = (byte)a;
            Console.WriteLine("");
            System.Console.WriteLine("El valor de b es " + b);
            System.Console.ReadKey();
            Console.WriteLine("");
            // Conversion Implicita
            Console.WriteLine("Convercion Implicita");
            short s = 256;
            byte y = 123;
            s = y;
            System.Console.WriteLine("El valor de y es " + s);
            System.Console.ReadKey();
            Console.WriteLine("");
            //Objeto (Boxing/Unboxing)
            System.Console.WriteLine("Variable Objeto");
            object c = s;
            System.Console.WriteLine("El valor del objeto c es " + c);
            short d = (short)c;
            d++;
            System.Console.WriteLine("El valor del objeto d incrementado es " + d);
            System.Console.ReadKey();
            Console.WriteLine("");
            // Dato Enum
            Console.WriteLine("El dia de hoy es: " + Dias.Jueves);
            Dias dd = Dias.Jueves;
            dd++;
            Console.WriteLine("Mañana sera: " + dd);
            System.Console.ReadKey();
            Console.WriteLine("");
            // Struct

            miestructura me = new miestructura();
            me.nombre = "angel";
            me.edad = 20;
            Console.WriteLine("Mi nombre es: " + me.nombre);
            Console.WriteLine("Mi edad es: " + me.edad);
            me.edad++;
            Console.WriteLine("El proximo año cumplire: " + me.edad);
            Console.WriteLine("");
            System.Console.ReadKey();
            // Connvert to / Operaciones Binarias
            float f = 3.95f;
            int i = Convert.ToInt32(f);
            sbyte sb = 100;
            double w = Convert.ToDouble(sb);
            double q = 5.0;
            byte p = Convert.ToByte(q);
            short r = 321;
            decimal dc = Convert.ToDecimal(r);
            float ff = 10.76f;
            byte bv = Convert.ToByte(ff);
            int z = (int)f;
            short sh = 22;
            short k = 0x22;
            short l = 0x22 << 1;
            short op = (0x22 << 1) ^ 255;
            Console.WriteLine("Conversion de Datos / Operaciones Binarias");
            Console.WriteLine("");
            Console.WriteLine("El valor de la variable convertida i es " + i);
            Console.WriteLine("El valor de la variable convertida w es " + w);
            Console.WriteLine("El valor de la variable convertida p es " + p);
            Console.WriteLine("El valor de la variable convertida dc es " + dc);
            Console.WriteLine("El valor de la variable convertida bv es " + bv);
            Console.WriteLine("El valor de sh es: " + sh);
            Console.WriteLine("El valor del hexadecimal k es: " + k);
            Console.WriteLine("Si aplicamos un Left Shift a k en 1 hacia la Izquierda, el valor es: " + l);
            Console.WriteLine("Si aplicamos un Xor con 255, el valor es: " + op);
            Console.WriteLine("El valor de z es " + z);
            Console.WriteLine("");
            System.Console.ReadKey();
            // Operadores Logicos
            Console.WriteLine("Operadores Logicos");
            Console.WriteLine("");
            Console.WriteLine("Ingrese un Numero Entero");
            int v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro Numero Entero");
            int v2 = Convert.ToInt32(Console.ReadLine()); ;
            if (v1 < v2)
            {
                Console.WriteLine("El primer numero es menor que el segundo numero");
            }
            else
            {
                Console.WriteLine("El primer numero es mayor que el segundo numero");
            }
            System.Console.ReadKey();
            Console.WriteLine("");
            //If anidado
            Console.WriteLine("Ingrese un digito A");
            int vv1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro digito B");
            int vv2 = Convert.ToInt32(Console.ReadLine());

            if (vv1 < vv2)
            {
                Console.WriteLine("A es menor que B");
            }
            if (vv1 > vv2)
            {
                Console.WriteLine("A es mayor que B");
            }
            if (vv1 == vv2)
            {
                Console.WriteLine("A es igual que b");
            }
            else
            {

            }
            System.Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Ingrese su edad");
            string edad = System.Console.ReadLine();
            if (System.Convert.ToInt32(edad) > 18)
            {
                Console.WriteLine("Usted Es mayor de edad");
            }
            else
            {
                if (System.Convert.ToInt32(edad) == 18)
                {
                    Console.WriteLine("Usted Es mayor de edad");
                }
                else
                {
                    Console.WriteLine("Usted Es menor de edad");
                }
            }
            System.Console.ReadKey();
            Console.WriteLine("");
            // Operador Temario
            Console.WriteLine("Ingrese un numero");
            int num = System.Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine(num > 10 ? "El numero es mayor que 10" : num == 10 ? "El numero es igual a 10" : "El numero es menor que 10");
            System.Console.ReadKey();
            Console.WriteLine("");
            // Switch
            Console.WriteLine("¿Cual es su edad?");
            int edad2 = System.Convert.ToInt32(System.Console.ReadLine());
            switch (edad2) {
                case 17:
                    Console.WriteLine("¿17?, usted es menor de edad");
                    break;
                case 18:
                    Console.WriteLine("¿18?, usted es mayor de edad");
                    break;
                case 19:
                    Console.WriteLine("¿19?, tay viejo");
                    break;
                default:
                    Console.WriteLine("Su edad no esta registrada en el sistema");
                    break;
            }
            System.Console.ReadKey();
            Console.WriteLine("");
            // Ciclo While
            Console.WriteLine("Ciclo While");
            Console.WriteLine("");
            int cont = 0;
            while (cont < 10)
            {
                Console.WriteLine(cont);
                cont++;
            }
            System.Console.ReadKey();
            // Ciclo For
            Console.WriteLine("Ciclo For");
            Console.WriteLine("");
            for (int ifr = 0; ifr < 11; ifr++)
            {
                Console.WriteLine("Posicion: " + ifr);
            }
            System.Console.ReadKey();
            Console.WriteLine("");
            //Ciclo Do While
            Console.WriteLine("Ciclo Do While");
            Console.WriteLine("");
            int id = 0;
            do
            {
                Console.WriteLine("Numero: " + id);
                id++;
            }
            while (id < 10);
            Console.ReadKey();
            //Ciclo ForEach (se utiliza para arreglos o listas)
            Console.WriteLine("Ciclo ForEach");
            Console.WriteLine("");
            int[] impares = { 1, 3, 5, 7, 9 };
            foreach (int a1 in impares)
            {
                Console.WriteLine("Elemento: " + a1);
            }
            Console.ReadKey();
            // Clases
            // si se marca una clase con sealed, esta ya no podra heredar
            // al declarar una clase abstracta no se puede crear un objeto de la misma, solo heredar
            // si el metodo es de tipo void, este no retornara un valor
            // en las clases se pueden declarar metodos
            Persona y1 = new Persona();
            y1.setInt(34);
            Console.WriteLine("valor del entero heredado 1 es : " + y1.getInt());
            Persona2 p2 = new Persona2();
            p2.setInt(12);
            y1.ii2 = 77;
            Console.WriteLine("valor del entero heredado 2 es : " + p2.getInt());
            Console.WriteLine("valor del segundo entero es : " + y1.ii2);
            // Metodos Heredados por Clases
            Console.WriteLine("Metodo Heredado por Clases");
            ClaseA ca = new ClaseA();
            ClaseB cb = new ClaseB();
            ClaseC cc = new ClaseC();
            ca.Imprimir();
            cb.Imprimir();
            cc.Imprimir();
            ca = new ClaseB();
            cb = new ClaseC();
            ca.Imprimir();
            cb.Imprimir();
            Console.ReadKey();
            // Metodo de Clase Abstracta
            Console.WriteLine("");
            Humano2 hm2 = new Humano2();
            hm2.Comparar();
            Console.ReadKey();
        }

        }

}


