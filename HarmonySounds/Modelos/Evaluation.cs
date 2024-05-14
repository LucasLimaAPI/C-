namespace HarmonySounds.Modelos;

internal class Evaluation
{
    public Evaluation(int note)
    {
        Note = note;
    }

    public int Note {get;}

    public static Evaluation Parse(String  text)
    {
        int nota = int.Parse(text);
        return new Evaluation(nota);
    }


}







