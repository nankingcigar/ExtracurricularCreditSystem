namespace Nankingcigar.CEC.Application.Session.DTO
{
  public sealed class Login
  {
    public string Name { get; set; }
    public string Password { get; set; }
    public int? AuthenicationSourceId { get; set; }
  }
}