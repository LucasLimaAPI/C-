namespace HarmonySounds.Modelos
{

    internal interface IAvaliavel// indica que o codigo dentro das chaves não é executavel
    {
        void AdicionarNota(Evaluation nota);
        double Media {get;}
    }


}