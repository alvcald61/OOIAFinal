
package pe.edu.pucp.ooia.gest_academica.model;

import pe.edu.pucp.ooia.gest_humana.model.Alumno;

/**
 *
 * @author DAYANA
 */
public class CursoLlevado {
    private int id_curso_llevado;
    private Alumno alumno;
    private Curso curso;
    private String ciclo;
    private int vez;
    private double notaFinal;
    private boolean retirado;
    private String formulaCalificacion;
    
    public CursoLlevado() {
    }
    

    public CursoLlevado(int id_curso_llevado, Curso curso, String ciclo, int vez, double notaFinal, boolean retirado, String formulaDeCalificacion) {
        this.id_curso_llevado = id_curso_llevado;
        this.curso = curso;
        this.ciclo = ciclo;
        this.vez = vez;
        this.notaFinal = notaFinal;
        this.retirado = retirado;
        this.formulaCalificacion = formulaDeCalificacion;
    }

    public int getId_curso_llevado() {
        return id_curso_llevado;
    }

    public void setId_curso_llevado(int id_curso_llevado) {
        this.id_curso_llevado = id_curso_llevado;
    }

    public Alumno getAlumno() {
        return alumno;
    }

    public void setAlumno(Alumno alumno) {
        this.alumno = alumno;
    }
    
    public Curso getCurso() {
        return curso;
    }

    public void setCurso(Curso curso) {
        this.curso = curso;
    }

    public String getCiclo() {
        return ciclo;
    }

    public void setCiclo(String ciclo) {
        this.ciclo = ciclo;
    }

    public int getVez() {
        return vez;
    }

    public void setVez(int vez) {
        this.vez = vez;
    }

    public double getNotaFinal() {
        return notaFinal;
    }

    public void setNotaFinal(double notaFinal) {
        this.notaFinal = notaFinal;
    }

    public boolean isRetirado() {
        return retirado;
    }

    public void setRetirado(boolean retirado) {
        this.retirado = retirado;
    }

    public String getFormulaCalificacion() {
        return formulaCalificacion;
    }

    public void setFormulaCalificacion(String formulaCalificacion) {
        this.formulaCalificacion = formulaCalificacion;
    }

    @Override
    public String toString() {
        return "CursoLlevado{" + "id_curso_llevado=" + id_curso_llevado + ", alumno=" + alumno + ", curso=" + curso.getNombreCurso() + ", ciclo=" + ciclo + ", vez=" + vez + ", notaFinal=" + notaFinal + ", retirado=" + retirado + ", formulaDeCalificacion=" + formulaCalificacion + '}';
    }
    



    
}
