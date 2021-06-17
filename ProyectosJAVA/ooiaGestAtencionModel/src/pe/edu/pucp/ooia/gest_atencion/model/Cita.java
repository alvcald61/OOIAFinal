
package pe.edu.pucp.ooia.gest_atencion.model;
import java.util.Date;
import pe.edu.pucp.ooia.gest_humana.model.Alumno;
import pe.edu.pucp.ooia.gest_humana.model.MiembroPUCP;
/**
 *
 * @author DAYANA
 */
public class Cita {
    private int id_cita;
    private Alumno alumno;
    private int tipo_asesor;
    private MiembroPUCP asesor;
    private CodigoAtencion codigo_atencion;
    private Horario horario;
    private Date fecha;
    private String motivo;
    private String compromiso;
    private boolean asistio;
    private boolean activo;

    public Cita(){};

    public int getId_cita() {
        return id_cita;
    }

    public void setId_cita(int id_cita) {
        this.id_cita = id_cita;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public Alumno getAlumno() {
        return alumno;
    }

    public void setAlumno(Alumno alumno) {
        this.alumno = alumno;
    }

    public MiembroPUCP getAsesor() {
        return asesor;
    }

    public int getTipo_asesor() {
        return tipo_asesor;
    }

    public void setTipo_asesor(int tipo_asesor) {
        this.tipo_asesor = tipo_asesor;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    public void setAsesor(MiembroPUCP asesor) {
        this.asesor = asesor;
    }

    public Horario getHorario() {
        return horario;
    }

    public void setHorario(Horario horario) {
        this.horario = horario;
    }

    public CodigoAtencion getCodigo_atencion() {
        return codigo_atencion;
    }

    public void setCodigo_atencion(CodigoAtencion codigo_atencion) {
        this.codigo_atencion = codigo_atencion;
    }

    public String getMotivo() {
        return motivo;
    }

    public void setMotivo(String motivo) {
        this.motivo = motivo;
    }

    public String getCompromiso() {
        return compromiso;
    }

    public void setCompromiso(String compromiso) {
        this.compromiso = compromiso;
    }
  

    public boolean isAsistio() {
        return asistio;
    }

    public void setAsistio(boolean asistio) {
        this.asistio = asistio;
    }

    public boolean getEstado() {
        return activo;
    }

    public void setEstado(boolean estado) {
        this.activo = estado;
    }
}
