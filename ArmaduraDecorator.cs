public class ArmaduraDecorator : GuerreiroDecorator
{
    private int _incrementoDefesa;

    public ArmaduraDecorator(Guerreiro guerreiro, int incrementoDefesa) : base(guerreiro)
    {
        _incrementoDefesa = incrementoDefesa;
        _guerreiro.Defesa += _incrementoDefesa;
    }
}