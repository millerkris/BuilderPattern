using System.IO;
using BuilderPattern;

public class Program
{
    public static void Main()
    {
        ConcreteDogBuilder builder = new ConcreteDogBuilder();
        Director director = new Director(builder);
        director.ConstructDog("Afina","Bull Terrier",1, "ball");
        director.AddToyToDog("barbell");

        director.GetReadyDog();

    }
}
