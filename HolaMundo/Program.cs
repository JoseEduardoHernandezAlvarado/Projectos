
internal class Program
{
    private static void Main(string[] args)
    {
        double x;double y;
        int Cantidad;
        char opc;
        Operaciones llamar =new Operaciones();
        

        //Hola mundo
       Console.WriteLine("Ingrese cantidad de veces para repetir el mensaje");
        Cantidad = int.Parse(Console.ReadLine());
        for(int c=0;c<Cantidad;c++){
            Console.WriteLine((c+1)+": Hola,Bienvenido a mi primer proyecto en visual code");
        }
        Console.ReadKey();
        //inicio del proyecto calculadora de 2 numeros 
       do{ 
        Console.Clear();
        Console.WriteLine("\n\nEliga una opcion"+
       "\nS :Suma"+
       "\nR :Resta"+
       "\nM :Multiplicacion"+
       "\nD :Division"+
       "\nF :Finalizar Programa");
       opc=Console.ReadKey().KeyChar;
       
        switch (opc){
            case 'S':
            Console.WriteLine("\nIngrese X");
            x=double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Y");
            y=double.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es :");
            llamar.Suma(x,y);
            Console.ReadKey();
            break;
            case 'R':
             Console.WriteLine("\nIngrese X");
            x=double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Y");
            y=double.Parse(Console.ReadLine());
              Console.WriteLine("El resultado es :");
            llamar.Resta(x,y);
            Console.ReadKey();
            break;
            case 'M':
              Console.WriteLine("\nIngrese X");
            x=double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Y");
            y=double.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es :");
            llamar.Multiplicacion(x,y);
            Console.ReadKey();
            break;
            case 'D':
              Console.WriteLine("\nIngrese X");
            x=double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Y");
            y=double.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es :");
            llamar.Division(x,y);
            Console.ReadKey();
            break;
            case 'F':
            Console.WriteLine("Gracias por usar el programa presione cualquier tecla para continuar");
            Console.ReadKey();
            break;
            default:
            Console.WriteLine("Opcion no valida favor de volver a ingresar opcion");
            break;
        }
       }while(opc != 'F');    
    }
}