package pe.edu.pucp.ooia.gest_humana.model;
import pe.edu.pucp.interfaces.IConsultable;

public class Ponente extends MiembroExterno implements IConsultable{
    private int id_ponente;
    private String organizacion;
    private boolean activo;

    public Ponente() {
    }

    public int getId_ponente() {
        return id_ponente;
    }

    public void setId_ponente(int id_ponente) {
        this.id_ponente = id_ponente;
    }

    public String getOrganizacion() {
        return organizacion;
    }

    public void setOrganizacion(String organizacion) {
        this.organizacion = organizacion;
    }

    public boolean getActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    @Override
    public String toString() {
        return this.getId_persona() + "-"+ this.getNombre()+ "-" + 
                this.getCorreo() + "-" +this.getDireccion() + "-"+ this.getDni() +
                "-" + this.getOcupacion() + "-" + this.getTelefono();
    }

    @Override
    public String consultarDatos() {
        return null;
    }

}


        
