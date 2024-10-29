public static void Main()
{
    Guerreiro guerreiro1 = new Guerreiro("Arthur", 20, 5);
    Guerreiro guerreiro2 = new Guerreiro("Lancelot", 18, 6);

    guerreiro1 = new EspadaDecorator(guerreiro1, 5);
    guerreiro2 = new ArmaduraDecorator(guerreiro2, 5);
    guerreiro1 = new AnelDecorator(guerreiro1);

    List<Guerreiro> guerreiros = new List<Guerreiro> { guerreiro1, guerreiro2 };
    Jogo jogo = new Jogo(guerreiros);
    jogo.IniciarBatalha();
}