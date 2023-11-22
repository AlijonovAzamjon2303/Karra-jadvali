
namespace Karra_jadvali
{
    public static class Karra
    {
        public static void karraJadvali(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                    Console.Write($"{j} * {i} = {i * j} \t");
            Console.WriteLine();
            }
        }
    }
}
