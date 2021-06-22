
package pe.edu.pucp.ooia.gest_atencion.model;

import java.sql.Time;
import java.util.Date;

/**
 *
 * @author DAYANA
 */
public class Horario {
    private int id_horario;
    private int dia;
    private Date horaInicio;
    private Date horaFin;
    private boolean activo;

    
    public Horario() {
    } 

    public Horario(int id_horario, int dia, Date horaInicio, Date horaFin) {
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

    public Date getHoraInicio() {
        return horaInicio;
    }

    public void setHoraInicio(Date horaInicio) {
        this.horaInicio = horaInicio;
    }

    public Date getHoraFin() {
        return horaFin;
    }

    public void setHoraFin(Date horaFin) {
        this.horaFin = horaFin;
    }

  
    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
}
