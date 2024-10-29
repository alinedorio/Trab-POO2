public abstract class GuerreiroDecorator : Guerreiro
{
    protected Guerreiro _guerreiro;

    protected GuerreiroDecorator(Guerreiro guerreiro) : base(guerreiro.Nome, guerreiro.Ataque, guerreiro.Defesa)
    {
        _guerreiro = guerreiro;
    }

    public override void Atacar(Guerreiro inimigo)
    {
        _guerreiro.Atacar(inimigo);
    }
}