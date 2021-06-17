package pe.edu.pucp.gestion_eventos.model;

import java.util.ArrayList;
import java.sql.Time;
import java.util.Date;
import pe.edu.pucp.ooia.gest_humana.model.Coordinador;
import pe.edu.pucp.ooia.gest_humana.model.Ponente;

/**
 *
 * @author LENOVO
 */
public class Evento{
    private int id_evento;
    private String nombre;
    private String descripcion;
    private Coordinador coordinador;
    private CategoriaEvento categoria;
    private int capacidad;
    private int cupo;
    private Date fecha;
    private Date  horaInicio;
    private Date  horaFin;
    private String lugar;
    private byte[] imagen;
    private ArrayList <Ponente> ponentes;
    private boolean activo;
    
    public Evento() {
        ponentes=new ArrayList<>();
        
    }

    public int getId_evento() {
        return id_evento;
    }

    public void setId_evento(int id_evento) {
        this.id_evento = id_evento;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public Coordinador getCoordinador() {
        return coordinador;
    }

    public void setCoordinador(Coordinador coordinador) {
        this.coordinador = coordinador;
    }

    public CategoriaEvento getCategoria() {
        return categoria;
    }

    public void setCategoria(CategoriaEvento categoria) {
        this.categoria = categoria;
    }

    public int getCapacidad() {
        return capacidad;
    }

    public void setCapacidad(int capacidad) {
        this.capacidad = capacidad;
    }

    public int getCupo() {
        return cupo;
    }

    public void setCupo(int cupo) {
        this.cupo = cupo;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public Date getHoraInicio() {
        return horaInicio;
    }

    public void setHoraInicio(Date horaInicio) {
        this.horaInicio = horaInicio;
    }

    public Date getHoraFin() {
        return horaFin;
    }

    public void setHoraFin(Date horaFin) {
        this.horaFin = horaFin;
    }



    public String getLugar() {
        return lugar;
    }

    public void setLugar(String lugar) {
        this.lugar = lugar;
    }

    public byte[] getImagen() {
        return imagen;
    }

    public void setImagen(byte[] imagen) {
        this.imagen = imagen;
    }

    public ArrayList<Ponente> getPonentes() {
        return ponentes;
    }

    public void setPonentes(ArrayList<Ponente> ponentes) {
        this.ponentes = ponentes;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

}
