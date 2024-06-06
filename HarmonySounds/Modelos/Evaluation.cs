namespace HarmonySounds.Modelos;

internal readonly struct Evaluation(int note)
{
    public int Note { get; } = note;

    public static Evaluation Parse(string text)
    {
        if(!int.TryParse(text, out var note))
        {
            return new(0);
        }
        return new Evaluation(note);
    }
}






