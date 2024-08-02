namespace UtmBuilder.Core.ValueObjects
{
  public class Url : ValueObject
  {
    /// <summary>
    /// Cria uma nova URL
    /// </summary>
    /// <param name="address">Endereço da URL (Link)</param>
    public Url(string address)
    {
      Address = address;
    }

    public string Address { get; }
  }
}
