namespace UtmBuilder.Core.ValueObjects
{
  public class Campaign : ValueObject
  {
    /// <summary>
    /// Campanha para a URL
    /// </summary>
    /// <param name="source">Referência (e.g. google, newsletters)</param>
    /// <param name="medium">Meio de marketing (e.g. cpc, banner, email)</param>
    /// <param name="name">Produto, código promocional, slogan</param>
    /// <param name="id">Identificador da campanha ADS</param>
    /// <param name="term">Palavras chaves</param>
    /// <param name="content">Conteúdo do ADS</param>
    public Campaign(
      string source,
      string medium,
      string name,
      string? id = null,
      string? term = null,
      string? content = null
      )
    {
      Source = source;
      Medium = medium;
      Name = name;
      Id = id;
      Term = term;
      Content = content;
    }

    public string Source { get; }
    public string Medium { get; }
    public string Name { get; }
    public string? Id { get; }
    public string? Term { get; }
    public string? Content { get; }
  }
}
