import Datetime;
public class CartaoDebito
{

    public CartaoDebito()
    {
        Bandeira = BandeiraCartao.Visa;
    }
    public string NumeroCartao { get; set; }
    public BandeiraCartao Bandeira { get; set; }
    public Datetime Vencimento { get; set; }
    public string Portador { get; set; }
    public string Cvv { get; set; }
}

public enum BandeiraCartao
{
    Visa,
    Mastercard,
    Amex,
    Elo
}