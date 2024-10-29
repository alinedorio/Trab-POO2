public class EspadaDecorator : GuerreiroDecorator
{
    private int _incrementoAtaque;

    public EspadaDecorator(Guerreiro guerreiro, int incrementoAtaque) : base(guerreiro)
    {
        _incrementoAtaque = incrementoAtaque;
        _guerreiro.Ataque += _incrementoAtaque;
    }
}