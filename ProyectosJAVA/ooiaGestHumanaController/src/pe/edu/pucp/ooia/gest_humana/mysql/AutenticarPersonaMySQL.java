/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.ooia.gest_humana.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.ResultSet;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.ooia.gest_atencion.model.Cita;
import pe.edu.pucp.ooia.gest_humana.dao.AlumnoDAO;
import pe.edu.pucp.ooia.gest_humana.dao.AutenticarPersonaDAO;

/**
 *
 * @author PC
 */
public class AutenticarPersonaMySQL implements AutenticarPersonaDAO{
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public int autenticarPersona(int dni) {
        int resultado = 0;//error al momento de listar
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call autenticarPersona(?)}");
            cs.setInt("_dni", dni);
            rs = cs.executeQuery();
            
            if(rs.next()){//para ver si hay repetidos
                resultado = 1;//si hay un usuario
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;//si el resultado es 0 entonces la persona es nueva
    }
    
    
    
    
    @Override
    public int autenticarUsuarioUnico(String usuario){
        int resultado=0;   
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call VALIDAR_USUARIO_UNICO(?)}");
            cs.setString("_usuario", usuario);
            rs=cs.executeQuery();
            if(rs.next())
                resultado=1;
        }
        catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @Override
    public int validarUnicoRegistroAEvento(int id_alumno, int id_evento) {
        int resultado=0;   
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call VALIDAR_REGISTRO_ALUMNO_EVENTO(?,?)}");
            cs.setInt("_id_alumno", id_alumno);
            cs.setInt("_id_evento", id_evento);
            rs=cs.executeQuery();
            if(rs.next())
                resultado=1; //si ya esta inscrito el alumno
        }
        catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @Override
    public int validarUnicaOpinionCita(int id_alumno, int fid_asesor, int fid_cita) {
    int resultado=0;   
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call VALIDAR_REGISTRO_OPINION_CITA(?,?,?)}");
            cs.setInt("_id_alumno", id_alumno);
            cs.setInt("_fid_asesor", fid_asesor);
            cs.setInt("_fid_cita", fid_cita);
            rs=cs.executeQuery();
            if(rs.next())
                resultado=1; //si ya esta inscrito la opinion del alumno
        }
        catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @Override
    public int validarRegistroACita(int id_alumno, int id_horario, Cita cita) {
        int resultado=0;   
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call VALIDAR_REGISTRO_ALUMNO_CITA(?,?,?)}");
            cs.setInt("_id_alumno", id_alumno);
            cs.setInt("_id_horario", id_horario);
            cs.setDate("_fecha", new java.sql.Date(cita.getFecha().getTime()));
            rs=cs.executeQuery();
            if(rs.next())
                resultado=1; //si ya esta inscrito a la cita
        }
        catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
}
