using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core
{
  /// <summary>
  /// UTM (Urchin Tracking Module)
  /// </summary>
  /// <param name="url">URL (Link)</param>
  /// <param name="campaign">Detalhes da campanha</param>
  public class Utm
  {
    public Utm(Url url, Campaign campaign)
    {
      Url = url;
      Campaign = campaign;
    }

    public Url Url { get; }
    public Campaign Campaign { get; }
  }
}
