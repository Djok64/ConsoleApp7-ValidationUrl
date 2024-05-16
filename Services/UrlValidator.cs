using System.Text.RegularExpressions;

namespace ConsoleApp7ValidationUrl.Services
{

  public class UrlValidator
  {
    //expression regulière pour controller l'url
    private static readonly Regex UrlRegex = new Regex(
          @"^(http|https)://([\w-]+(\.[\w-]+)+)(/[\w- ;,./?%&=]*)?$",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
    //méthode pour verifier si un Url est valide      
    public static bool URLValide(string urlUser)
    {
      if (Uri.IsWellFormedUriString(urlUser, UriKind.Absolute) && UrlRegex.IsMatch(urlUser))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}