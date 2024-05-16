using System.Runtime.CompilerServices;
using ConsoleApp7ValidationUrl.Services;

namespace ConsoleApp7ValidationUrl.Controllers
{

  public class ConsoleController
  {
    public string urlUser = "";
    public bool isValid;

    public static void Start()
    {
      Console.WriteLine("Bonjour bienvenue dans le Validator d'Url");
      Console.WriteLine("Veuillez entree votre Url valide svp");
      string? urlUser = Console.ReadLine();

      bool isValid = UrlValidator.URLValide(urlUser!);

      while (!isValid)
      {
        Console.WriteLine("Url Invalide veuillez entrer un nouvelle Url ou entrez Q pour quitter le programme");
        urlUser = Console.ReadLine();
        if (urlUser == "Q")
        {
          Environment.Exit(-0);
        }
        else
        {
          isValid = UrlValidator.URLValide(urlUser!);
        }
      }
      Console.WriteLine(urlUser + " est un Url valide");

    }

  }
}
