// See https://aka.ms/new-console-template for more information

using DesignPatterns2.Cap02;

var notas = new NotasMusicais();

IList<INota> doReMiFa = new List<INota>()
{
    notas.Pega("do"),
    notas.Pega("re"),
    notas.Pega("mi"),
    notas.Pega("fa"),
    notas.Pega("fa"),
    notas.Pega("fa"),

    notas.Pega("do"),
    notas.Pega("re"),
    notas.Pega("do"),
    notas.Pega("re"),
    notas.Pega("re"),
    notas.Pega("re"),

    notas.Pega("do"),
    notas.Pega("sol"),
    notas.Pega("fa"),
    notas.Pega("mi"),
    notas.Pega("mi"),
    notas.Pega("mi"),

    notas.Pega("do"),
    notas.Pega("re"),
    notas.Pega("mi"),
    notas.Pega("fa"),
    notas.Pega("fa"),
    notas.Pega("fa")
};

var piano = new Piano();
piano.Toca(doReMiFa);