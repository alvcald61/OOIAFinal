
package pe.edu.pucp.ooia.gest_academica.model;


/**
 *
 * @author DAYANA
 */
public class Evaluacion {
    private int id_evaluacion;
    private CursoLlevado cursoLlevado;
    private String tipo;
    private String nombre;
    private int nota;

    public Evaluacion(int id_evaluacion, CursoLlevado cursoLlevado, String tipo, String nombre, int nota) {
        this.id_evaluacion = id_evaluacion;
        this.cursoLlevado = cursoLlevado;
        this.tipo = tipo;
        this.nombre = nombre;
        this.nota = nota;
    }


    public Evaluacion() {
    }



    public int getId_evaluacion() {
        return id_evaluacion;
    }

    public void setId_evaluacion(int id_evaluacion) {
        this.id_evaluacion = id_evaluacion;
    }

    public CursoLlevado getCursoLlevado() {
        return cursoLlevado;
    }

    public void setCursoLlevado(CursoLlevado cursoLlevado) {
        this.cursoLlevado = cursoLlevado;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }
    
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getNota() {
        return nota;
    }

    public void setNota(int nota) {
        this.nota = nota;
    }

    @Override
    public String toString() {
        return "Evaluacion{" + "id_evaluacion=" + id_evaluacion + ", cursoLlevado=" + cursoLlevado  + ", nombre=" + nombre + ", nota=" + nota + '}';
    }
    
}
