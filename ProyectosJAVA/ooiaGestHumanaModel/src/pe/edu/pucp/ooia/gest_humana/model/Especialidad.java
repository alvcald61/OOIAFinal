package pe.edu.pucp.ooia.gest_humana.model;

/**
 *
 * @author Gerardo
 */
public class Especialidad {
    private int id_especialidad;
    private String nombre;
    private boolean activo;

    public Especialidad() {
    }

    public Especialidad(int id_especialidad, String nombre) {
        this.id_especialidad = id_especialidad;
        this.nombre = nombre;
        this.activo = true;
    }
    
    public int getId_especialidad() {
        return id_especialidad;
    }

    public void setId_especialidad(int id_especialidad) {
        this.id_especialidad = id_especialidad;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }  
    
    @Override
    public String toString() {
        return "Especialidad{" + "id_especialidad=" + id_especialidad + ", nombre=" + nombre + '}';
    }
    
}
