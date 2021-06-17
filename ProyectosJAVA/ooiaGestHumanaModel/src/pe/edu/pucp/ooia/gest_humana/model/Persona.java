package pe.edu.pucp.ooia.gest_humana.model;
import java.util.Date;
import pe.edu.pucp.interfaces.IConsultable;

public abstract class Persona implements IConsultable {
    private int id_persona;
    private String dni;
    private String nombre;
    private Date fecha_nacimiento;
    private String direccion;
    private String correo;
    
    public Persona() {
    }

    public Persona(int id_persona, String dni, String nombre, Date fecha_nacimiento, String direccion, String correo) {
        this.id_persona = id_persona;
        this.dni = dni;
        this.nombre = nombre;
        this.fecha_nacimiento = fecha_nacimiento;
        this.direccion = direccion;
        this.correo = correo;
    }

    public int getId_persona() {
        return id_persona;
    }

    public void setId_persona(int id_persona) {
        this.id_persona = id_persona;
    }
    
    public String getDni() {
        return dni;
    }

    public void setDni(String dni) {
        this.dni = dni;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public Date getFecha_nacimiento() {
        return fecha_nacimiento;
    }

    public void setFecha_nacimiento(Date fecha_nacimiento) {
        this.fecha_nacimiento = fecha_nacimiento;
    }

    
    
    public String getCorreo() {
        return correo;
    }

    public void setCorreo(String correo) {
        this.correo = correo;
    }

    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }

    @Override
    public abstract String consultarDatos();
    
    
}
