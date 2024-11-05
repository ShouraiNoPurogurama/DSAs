using System.Collections;

namespace UdemyDSAs.Utils;

public static class Utils
{
    public static void Display<TSource>(TSource source)
    {
        if (source is IEnumerable collection)
        {
            foreach (var item in collection) //Boxing and unboxing occurs here
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine(source);
        }
    }
}