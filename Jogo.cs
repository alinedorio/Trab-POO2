public class Jogo
{
    private List<Guerreiro> _guerreiros;

    public Jogo(List<Guerreiro> guerreiros)
    {
        _guerreiros = guerreiros;
    }

    public void IniciarBatalha()
    {
        int turno = 1;
        while (_guerreiros.All(g => g.Vida > 0))
        {
            Console.WriteLine($"--- Turno {turno} ---");
            foreach (var guerreiro in _guerreiros)
            {
                Guerreiro oponente = _guerreiros.First(g => g != guerreiro && g.Vida > 0);
                guerreiro.Atacar(oponente);

                if (oponente.Vida <= 0)
                {
                    Console.WriteLine($"{oponente.Nome} foi derrotado!");
                    break;
                }
            }
            turno++;
        }
    }
}