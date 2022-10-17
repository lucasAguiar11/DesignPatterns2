namespace DesignPatterns2.Cap02;

public class Piano
{
    public void Toca(IEnumerable<INota> musica)
    {
        foreach (var nota in musica)
            Console.Beep(nota.Frequencia, 300);
    }
}