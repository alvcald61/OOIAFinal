
package pe.edu.pucp.ooia.gest_humana.model;

public abstract class MiembroExterno extends Persona{
    private int id_miembro_externo;
    private String telefono;
    private String ocupacion;

    public MiembroExterno() {
    }
  
    public int getId_miembro_externo() {
        return id_miembro_externo;
    }

    public void setId_miembro_externo(int id_miembro_externo) {
        this.id_miembro_externo = id_miembro_externo;
    }
    
    public String getTelefono() {
        return telefono;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    public String getOcupacion() {
        return ocupacion;
    }

    public void setOcupacion(String ocupacion) {
        this.ocupacion = ocupacion;
    }
    
}