using Microsoft.EntityFrameworkCore;
using Model.Entities;

using var context = new EFKlantenContext();
var hierarchie = context.Personeelsleden.Include("Personeel").Where(x => x.Manager == null).ToList();

foreach (var CEO in hierarchie)
{
    Console.WriteLine(CEO.Voornaam);

	foreach (var managers in CEO.Personeel)
	{
        Console.WriteLine("\t" + managers.Voornaam);
        Console.WriteLine();

        foreach (var submanagers in managers.Personeel)
        {
            Console.WriteLine("\t\t" + submanagers.Voornaam);
            Console.WriteLine();
        }
    }
}