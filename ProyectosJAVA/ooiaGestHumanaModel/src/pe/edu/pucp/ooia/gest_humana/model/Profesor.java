package pe.edu.pucp.ooia.gest_humana.model;

import java.util.Date;

public class Profesor extends MiembroPUCP {
    private int id_profesor;
    private Especialidad especialidad;
    private String facultad;
    private String categoria;
    private boolean activo;
    
    public Profesor() {
        
    }

    public int getId_profesor() {
        return id_profesor;
    }

    public void setId_profesor(int id_alumno) {
        this.id_profesor = id_alumno;
    }

    public Especialidad getEspecialidad() {
        return especialidad;
    }

    public void setEspecialidad(Especialidad especialidad) {
        this.especialidad = especialidad;
    }

    public String getFacultad() {
        return facultad;
    }

    public void setFacultad(String facultad) {
        this.facultad = facultad;
    }

    public String getCategoria() {
        return categoria;
    }

    public void setCategoria(String categoria) {
        this.categoria = categoria;
    }

    public boolean getActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    

    @Override
    public String toString() {
        return "Profesor{" + "id_profesor=" + id_profesor + ", especialidad=" + especialidad + ", facultad=" + facultad + ", categoria=" + categoria + ", estado=" + activo + '}';
    }

    @Override
    public String consultarDatos() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
}

