namespace ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matris = new int[5, 3];
            Random rnd = new Random();
  
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matris[i, j] = rnd.Next(1, 10);
                }
            }

            Console.WriteLine("Matris: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("[");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matris[i, j]);
                    if (j < 2) Console.Write(", ");
                }
                Console.WriteLine("]");
            }

            int[] sutunToplam = new int[3];
            int[] satirToplam = new int[5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    satirToplam[i] += matris[i, j];
                    sutunToplam[j] += matris[i, j];
                }
            }

            Console.WriteLine("\nSatır toplamları:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Satır " + (i + 1) + ": " + satirToplam[i]);
            }

            Console.WriteLine("\nSütun toplamları:");
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Sütun " + (j + 1) + ": " + sutunToplam[j]);
            }

        }
    }
    
}
