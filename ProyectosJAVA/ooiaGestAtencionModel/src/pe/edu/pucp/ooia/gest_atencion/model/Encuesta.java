package pe.edu.pucp.ooia.gest_atencion.model;
import pe.edu.pucp.ooia.gest_humana.model.Alumno;
import pe.edu.pucp.ooia.gest_humana.model.MiembroPUCP;
/**
 *
 * @author DAYANA
 */
public class Encuesta {
    private int id_encuesta;
    private Alumno alumno;
    private int fid_cita;
    private int tipo_asesor;
    private MiembroPUCP asesor;
    private double puntaje;
    private String descripcion;
    private boolean activo;

  

    public Encuesta() {
    }

    public Encuesta(int id_encuesta, Alumno alumno, int fid_cita, int tipo_asesor, MiembroPUCP asesor, double puntaje, String descripcion, boolean activo) {
        this.id_encuesta = id_encuesta;
        this.alumno = alumno;
        this.fid_cita = fid_cita;
        this.tipo_asesor = tipo_asesor;
        this.asesor = asesor;
        this.puntaje = puntaje;
        this.descripcion = descripcion;
        this.activo = activo;
    }

    
    public int getFid_cita() {
        return fid_cita;
    }

    public void setFid_cita(int fid_cita) {
        this.fid_cita = fid_cita;
    }
    
    
    public int getId_encuesta() {
        return id_encuesta;
    }

    public void setId_encuesta(int id_encuesta) {
        this.id_encuesta = id_encuesta;
    }

    public Alumno getAlumno() {
        return alumno;
    }

    public void setAlumno(Alumno alumno) {
        this.alumno = alumno;
    }

    public double getPuntaje() {
        return puntaje;
    }

    public void setPuntaje(double puntaje) {
        this.puntaje = puntaje;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public int getTipo_asesor() {
        return tipo_asesor;
    }

    public void setTipo_asesor(int tipo_asesor) {
        this.tipo_asesor = tipo_asesor;
    }
    
    public MiembroPUCP getAsesor() {
        return asesor;
    }

    public void setAsesor(MiembroPUCP asesor) {
        this.asesor = asesor;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }    
}
