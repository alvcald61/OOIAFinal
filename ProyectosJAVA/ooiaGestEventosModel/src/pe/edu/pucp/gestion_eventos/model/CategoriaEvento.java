package pe.edu.pucp.gestion_eventos.model;

/**
 *
 * @author Gerardo
 */
public class CategoriaEvento {
    private int id_categoria;
    private String nombre;
    private boolean activo;

    public CategoriaEvento() {
    }
    
    public CategoriaEvento(int id_categoria, String nombre_categoria) {
        this.id_categoria = id_categoria;
        this.nombre = nombre_categoria;
        this.activo = true;
    }

    public int getId_categoria() {
        return id_categoria;
    }

    public void setId_categoria(int id_categoria) {
        this.id_categoria = id_categoria;
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
        return "Categoria{" + "id_categoria=" + id_categoria + ", nombre=" + nombre + '}';
    }
    
    
}
