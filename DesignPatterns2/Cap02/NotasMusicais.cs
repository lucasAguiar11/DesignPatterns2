namespace DesignPatterns2.Cap02;

public class NotasMusicais
{
    private static readonly IDictionary<string, INota> Notas =
        new Dictionary<string, INota>()
        {
            { "do", new Do() },
            { "re", new Re() },
            { "mi", new Mi() },
            { "fa", new Fa() },
            { "sol", new Sol() },
            { "la", new La() },
            { "si", new Si() }
        };

    public INota Pega(string nome)
    {
        return Notas[nome];
    }
}