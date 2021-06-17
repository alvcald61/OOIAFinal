
package pe.edu.pucp.ooia.gest_academica.model;

/**
 *
 * @author DAYANA
 */
public class Curso {
    private int id_curso;
    private String codigoCurso;
    private String nombreCurso;
    private double creditos;
    private boolean activo;
    
    public Curso() {
    }

    public Curso(String codigoCurso, String nombreCurso) {
        this.codigoCurso = codigoCurso;
        this.nombreCurso = nombreCurso;
        this.activo = true;
    }

    public Curso(int id_curso, String codigoCurso, String nombreCurso) {
        this.id_curso = id_curso;
        this.codigoCurso = codigoCurso;
        this.nombreCurso = nombreCurso;
        this.activo = true;
    }

   
    public int getId_curso() {
        return id_curso;
    }

    public void setId_curso(int id_curso) {
        this.id_curso = id_curso;
    }

    public String getCodigoCurso() {
        return codigoCurso;
    }

    public void setCodigoCurso(String codigoCurso) {
        this.codigoCurso = codigoCurso;
    }

    public String getNombreCurso() {
        return nombreCurso;
    }

    public void setNombreCurso(String nombreCurso) {
        this.nombreCurso = nombreCurso;
    }

    public double getCreditos() {
        return creditos;
    }

    public void setCreditos(double creditos) {
        this.creditos = creditos;
    }
    
    public boolean getActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    @Override
    public String toString() {
        return "Curso{" + "id_curso=" + id_curso + ", codigoCurso=" + codigoCurso + ", nombreCurso=" + nombreCurso + ", estado=" + activo + '}';
    }
    
    
}
