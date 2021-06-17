package pe.edu.pucp.ooia.gest_atencion.model;


/**
 *
 * @author DAYANA
 */
public class CodigoAtencion {
    private int id_codigo_atencion;
    private String codigo;
    private String descripcion;
    private boolean activo;

    public CodigoAtencion(){}

    public CodigoAtencion(int id_codigo_atencion, String codigo, String descripcion) {
        this.id_codigo_atencion = id_codigo_atencion;
        this.codigo = codigo;
        this.descripcion = descripcion;
        this.activo = true;
    }

    public int getId_codigo_atencion() {
        return id_codigo_atencion;
    }

    public void setId_codigo_atencion(int id_codigo_atencion) {
        this.id_codigo_atencion = id_codigo_atencion;
    }

    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }
    
    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    @Override
    public String toString() {
        return "CodigoAtencion{" + "id_codigo_atencion=" + id_codigo_atencion + ", codigo=" + codigo + ", descripcion=" + descripcion + '}';
    }
    
    
}
