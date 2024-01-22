using ScreenSound.Modelos;

namespace ScreenSound;

internal interface IAvaliavel
{
    void AdicionarNota(Avaliacao nota);
    double Media { get;  }
}