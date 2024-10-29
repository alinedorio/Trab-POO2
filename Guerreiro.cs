public class Guerreiro
{
    public string Nome { get; set; }
    public int Ataque { get; set; }
    public int Defesa { get; set; }
    public int Vida { get; set; } = 100;

    public Guerreiro(string nome, int ataque, int defesa)
    {
        Nome = nome;
        Ataque = ataque;
        Defesa = defesa;
    }

    public void ReceberDano(int dano)
    {
        int danoRecebido = Math.Max(dano - Defesa, 0);
        Vida -= danoRecebido;
        Console.WriteLine($"{Nome} recebeu {danoRecebido} de dano. Vida restante: {Vida}");
    }

    public virtual void Atacar(Guerreiro inimigo)
    {
        inimigo.ReceberDano(Ataque);
    }
}