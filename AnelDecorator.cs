public class AnelDecorator : GuerreiroDecorator
{
    private int _percentualReflexivo = 10;
    private int _esferasDePoder = 0;

    public AnelDecorator(Guerreiro guerreiro) : base(guerreiro) { }

    public void ColetarEsfera()
    {
        if (_esferasDePoder < 10)
        {
            _esferasDePoder++;
            _percentualReflexivo += 10;
        }
    }

    public override void ReceberDano(int dano)
    {
        base.ReceberDano(dano);
        int danoRefletido = dano * _percentualReflexivo / 100;
        Console.WriteLine($"{_guerreiro.Nome} reflete {danoRefletido} de dano ao atacante!");
    }
}