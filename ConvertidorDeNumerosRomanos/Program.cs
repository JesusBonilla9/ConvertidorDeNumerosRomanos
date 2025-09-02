using System.ComponentModel.Design;

namespace ConvertidorDeNumerosRomanos
{
    internal class Program
    {
        static int ValorEnRomano(char r)
        {
            if (r == 'I')
                return 1;
            if (r == 'V')
                return 5;
            if (r == 'X')
                return 10;
            if (r == 'L')
                return 50;
            if (r == 'C')
                return 100;
            if (r == 'D')
                return 500;
            if (r == 'M')
                return 1000;
            return 0;
        }

        static int ConversorRomanoDecimal(string romano)
        {
            int total = 0;
            for (int i = 0; i < romano.Length; i++)
            {
                int valorActual = ValorEnRomano(romano[i]);
                if(i + 1 < romano.Length)
                {
                    int valorSiguiente = ValorEnRomano(romano[i + 1]);
                    if (valorActual < valorSiguiente)
                    {
                        total -= valorActual;
                    }
                    else
                    {
                        total += valorActual;
                    }
                }
                else
                {
                    total += valorActual;
                }
            }
            return total;
        }
        static bool EsRomanoValido(string romano)
        {
            foreach(char r in romano)
            {
                if(ValorEnRomano(r) == 0)
                {
                    return false;
                }
            }
            if (romano.Contains("IIII") || romano.Contains("XXXX") || romano.Contains("CCCC") || romano.Contains("MMMM"))
            {
                return false;
            }
            if(romano.Contains("VV") || romano.Contains("LL") || romano.Contains("DD"))
            {
                return false;
            }
            for(int i = 0; i < romano.Length - 1; i++)
            {
                int actual = ValorEnRomano(romano[i]);
                int siguiente = ValorEnRomano(romano[i + 1]);
                if(actual < siguiente)
                {
                    char a = romano[i];
                    char b = romano[i + 1];
                    if (!((a == 'I' && (b == 'V' || b == 'X')) || (a == 'X' && (b == 'L' || b == 'C')) || (a == 'C' && (b == 'D' || b == 'M'))))
                    {
                        return false;
                    }
                }  
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=== Conversor de numeros romanos a decimales ===");
            string romano;
            while(true)
            {
                Console.Write("Ingrese el numero romano a convertir: ");
            }
            
        }
    }
}
