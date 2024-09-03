namespace TP7_PreguntadORT;

public static class Juego{
    private static string username {get; set;}
    private static int PuntajeActual {get; set;}
    private static int CantidadPreguntasCorrectas {get; set;}
    private static int ContadorNroPreguntaActual {get; set;}

    private static Preguntas PreguntaActual {get; set;}
    private static List<Preguntas> ListaPreguntas {get; set;}

    private static List<Respuestas> ListaRespuestas {get; set;}
}