package pe.edu.pucp.ooia.gest_humana.model;


public class Alumno extends MiembroPUCP {
    private int id_alumno;
    private String codigo;
    private Especialidad especialidad;
    private double craest;
    private double creditos_aprobados;
    private boolean activo;
     
    public Alumno() {
        especialidad = new Especialidad();
    }

    public Especialidad getEspecialidad() {
        return especialidad;
    }

    public void setEspecialidad(Especialidad especialidad) {
        this.especialidad = especialidad;
    }
        
    public int getId_alumno() {
        return id_alumno;
    }

    public void setId_alumno(int id_alumno) {
        this.id_alumno = id_alumno;
    }

    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }
    
    public double getCraest() {
        return craest;
    }

    public void setCraest(double craest) {
        this.craest = craest;
    }

    public boolean getActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }


    public double getCreditos_aprobados() {
        return creditos_aprobados;
    }

    public void setCreditos_aprobados(double creditos_aprobados) {
        this.creditos_aprobados = creditos_aprobados;
    }

    
    public double calcularPonderadoCiclo(){
        double ponderado = 0;
        
        return ponderado;
    }
    
    public int calcularFaltasCitas(){
        int faltas = 0;
        
        return faltas;
    }
    
    public double calcularCreditosAprobados(){
        double creditos=0;
        
        this.creditos_aprobados = creditos;
        return creditos;
    }

    @Override
    public String toString() {
        return "Alumno{"+ this.getNombre() +  " id_alumno=" + id_alumno + ", codigo_pucp=" + codigo + ", especialidad=" + especialidad + ", craest=" + '}';
    }

    @Override
    public String consultarDatos() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
}
