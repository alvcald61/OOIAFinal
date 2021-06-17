package pe.edu.pucp.gestion_eventos.model;

import java.util.ArrayList;
import pe.edu.pucp.ooia.gest_humana.model.Alumno;

public class EventoAlumno{
    private int id_encuesta;
    private int id_alumno;
    private int id_evento;
    private int valoracionPonentes;
    private int valoracionEvento;
    private int valoracionUtilidad;
    private boolean asistio;
    private String comentario;

    public EventoAlumno(){
       
    }

    public EventoAlumno(int id_encuesta, int id_alumno, int id_evento, int valoracionPonentes, int valoracionEvento, int valoracionUtilidad, boolean asistio, String comentario) {
        this.id_encuesta = id_encuesta;
        this.id_alumno = id_alumno;
        this.id_evento = id_evento;
        this.valoracionPonentes = valoracionPonentes;
        this.valoracionEvento = valoracionEvento;
        this.valoracionUtilidad = valoracionUtilidad;
        this.asistio = asistio;
        this.comentario = comentario;
    }

    public int getValoracionPonentes() {
        return valoracionPonentes;
    }

    public void setValoracionPonentes(int valoracionPonentes) {
        this.valoracionPonentes = valoracionPonentes;
    }
    
    public int getId_alumno() {
        return id_alumno;
    }

    public void setId_alumno(int id_alumno) {
        this.id_alumno = id_alumno;
    }

    public int getId_evento() {
        return id_evento;
    }

    public void setId_evento(int id_evento) {
        this.id_evento = id_evento;
    }

   

    

    public int getId_encuesta() {
        return id_encuesta;
    }

    public void setId_encuesta(int id_encuesta) {
        this.id_encuesta = id_encuesta;
    }


    public int getValoracionEvento() {
        return valoracionEvento;
    }

    public void setValoracionEvento(int valoracionEvento) {
        this.valoracionEvento = valoracionEvento;
    }

    public int getValoracionUtilidad() {
        return valoracionUtilidad;
    }

    public void setValoracionUtilidad(int valoracionUtilidad) {
        this.valoracionUtilidad = valoracionUtilidad;
    }

    public boolean isAsistio() {
        return asistio;
    }

    public void setAsistio(boolean asistio) {
        this.asistio = asistio;
    }

    public String getComentario() {
        return comentario;
    }

    public void setComentario(String comentario) {
        this.comentario = comentario;
    }


    
}