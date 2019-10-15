using System;
using System.Collections;
using System.Text;

namespace Budowniczy
{
    public class CodeBuilder
    {
        private readonly string rootName;

        Hashtable field = new Hashtable();
        public CodeBuilder(string rootName)
        {
            this.rootName = rootName;

           
        }

        public CodeBuilder AddField(string  Name , string type)
        {
            field.Add(Name, type);
            return this;

        }
          public override string ToString()
            {
            
            // dodaj  wartosc do wyswietlenia 
                Console.WriteLine($"public class {rootName}");

                foreach (DictionaryEntry word in field)
                {
                     Console.WriteLine(word);

                }

                
                
            }
        
        
    }
     
    // Nie zmieniaj poniższej klasy!
    class MainClass
    {
        public static void Main(string[] args)
        {
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            Console.WriteLine(cb);
        }
    }
}
/*
 * 
 * Twoim zadaniem jest napisanie generatora kodu.

Stwórz klasę CodeBuilder, która będzie miała:
Zmienną przechowującą nazwę tworzonej klasy

Publiczną metodę AddField przyjmującą dwa argumenty typu string - typ i nazwę.
Zmienną przechowującą dodane pola w jakiejś kolekcji (może być słownik - Hashtable).
Przeciążoną metodę ToString(), która wypisze na konsolę gotową klasę.

Załóż, że wszystkie dodawane pola są publiczne. Metoda AddField ma mieć płynny interfejs (Fluent interface). Jako wcięcie zastosuj dwie spacje.

Output konsoli:
public class Person
{
  public int Age;
  public string Name;
}
 * 
 */
