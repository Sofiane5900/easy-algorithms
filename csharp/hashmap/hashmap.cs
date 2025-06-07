using System.Collections;

namespace csharp.hashmap;

public class hashmap
{
    // on a besoin d'une liste sur quoi stocker nos indices & élements, 
    // on a besoin d'une méthode qui va placer les élements avec une clé en tant qu'indice
    // on 
    private static List<KeyValuePair<string, int>>[] buckets = new List<KeyValuePair<string, int>>[10];


    public static void Hashmap(string element)
    {
       int hashcode =  element.GetHashCode();
       Console.WriteLine(hashcode);
       int index = Math.Abs(hashcode) % buckets.Length;
       if (buckets[index] == null)
       {
           buckets[index] = new List<KeyValuePair<string, int>>();
       }

       bool keyExists = buckets[index].Any(pair => pair.Key == element);
       if (!keyExists)
       {
           buckets[index].Add(new KeyValuePair<string, int>(element, hashcode));
       }
       else
       {
           Console.Write("Key already exists !");
       }
    }
    
    
    
}