namespace TP7_PreguntadORT;

public class Respuestas
{
    public int IdRespuesta { get; set; }
    public int IdPregunta { get; set; }

    public int Opcion{ get; set; }
    public string Contenido { get; set; }

    public bool Correcta {get; set; }
    public string Foto { get; set; }

    public Respuestas(){
    }
}
