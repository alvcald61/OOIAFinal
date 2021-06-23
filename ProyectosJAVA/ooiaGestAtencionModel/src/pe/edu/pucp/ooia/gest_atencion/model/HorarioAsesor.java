
package pe.edu.pucp.ooia.gest_atencion.model;

import java.util.Date;

/**
 *
 * @author DAYANA
 */
public class HorarioAsesor {
    private int id_horario_asesor;
    private Horario horario;
    private int fid_asesor;
    private String estado;

    public HorarioAsesor() {
    }

    public HorarioAsesor(int id_horario_asesor, Horario horario, int fid_asesor, String estado) {
        this.id_horario_asesor = id_horario_asesor;
        this.horario = horario;
        this.fid_asesor = fid_asesor;
        this.estado = estado;
    }

   

    public int getId_horario_asesor() {
        return id_horario_asesor;
    }

    public void setId_horario_asesor(int id_horario_asesor) {
        this.id_horario_asesor = id_horario_asesor;
    }

    public Horario getHorario() {
        return horario;
    }

    public void setHorario(Horario horario) {
        this.horario = horario;
    }

   
    public int getFid_asesor() {
        return fid_asesor;
    }

    public void setFid_asesor(int fid_asesor) {
        this.fid_asesor = fid_asesor;
    }

    public String getEstado() {
        return estado;
    }

    public void setEstado(String estado) {
        this.estado = estado;
    }
    
    
}
