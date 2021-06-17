package pe.edu.pucp.ooia.gest_humana.model;

import java.util.Date;
import pe.edu.pucp.interfaces.IConsultable;

public abstract class MiembroPUCP extends Persona implements IConsultable{
   private int id_miembro_pucp;
   private String usuario;
   private String password;
   private Date fecha_inclusion;
   private byte[] imagenDePerfil;
   
    public MiembroPUCP() {
    }

    public byte[] getImagenDePerfil() {
        return imagenDePerfil;
    }

    public void setImagenDePerfil(byte[] imagenDePerfil) {
        this.imagenDePerfil = imagenDePerfil;
    }

    public int getId_miembro_pucp() {
        return id_miembro_pucp;
    }

    public void setId_miembro_pucp(int id_miembro_pucp) {
        this.id_miembro_pucp = id_miembro_pucp;
    }

    public String getUsuario() {
        return usuario;
    }

    public void setUsuario(String usuario) {
        this.usuario = usuario;
    }

    public Date getFecha_inclusion() {
        return fecha_inclusion;
    }

    public void setFecha_inclusion(Date fecha_inclusion) {
        this.fecha_inclusion = fecha_inclusion;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }


  
}

