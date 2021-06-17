
package pe.edu.pucp.ooia.gest_atencion.model;

import java.sql.Time;

/**
 *
 * @author DAYANA
 */
public class Horario {
    private int id_horario;
    private int dia;
    private Time horaInicio;
    private Time horaFin;
    private boolean activo;

    
    public Horario() {
    } 

    public Horario(int id_horario, int dia, Time horaInicio, Time horaFin) {
        this.id_horario = id_horario;
        this.dia=dia;
        this.horaInicio = horaInicio;
        this.horaFin = horaFin;
        this.activo = true;
    }

    public int getId_horario() {
        return id_horario;
    }

    public void setId_horario(int id_horario) {
        this.id_horario = id_horario;
    }

    public int getDia() {
        return dia;
    }

    public void setDia(int dia) {
        this.dia = dia;
    }

    public Time getHoraInicio() {
        return horaInicio;
    }

    public void setHoraInicio(Time horaInicio) {
        this.horaInicio = horaInicio;
    }

    public Time getHoraFin() {
        return horaFin;
    }

    public void setHoraFin(Time horaFin) {
        this.horaFin = horaFin;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
}
