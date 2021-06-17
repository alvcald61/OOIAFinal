package pe.edu.pucp.ooia.gest_humana.model;

public class Psicologo extends MiembroPUCP{
    private int id_psicologo;
    private String rama;
    private boolean activo;

    public Psicologo() {
    }

    public int getId_psicologo() {
        return id_psicologo;
    }

    public void setId_psicologo(int id_psicologo) {
        this.id_psicologo = id_psicologo;
    }

    public String getRama() {
        return rama;
    }

    public void setRama(String rama) {
        this.rama = rama;
    }
    
    public boolean getActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    

    @Override
    public String toString() {
        return "Psicologo{" + "id_psicologo=" + id_psicologo +this.getNombre() + '}';
    }

    @Override
    public String consultarDatos() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}
