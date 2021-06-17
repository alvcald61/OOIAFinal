/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.ooia.gest_humana.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.ooia.gest_humana.dao.InicioSesionDAO;

/**
 *
 * @author LENOVO
 */
public class inicioSesionMySQL implements  InicioSesionDAO{

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public int inicioSesion(String usuario, String password) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call autenticarUsuario(?,?)}");
            cs.setString("_usuario", usuario);
            cs.setString("_password", password);
            rs=cs.executeQuery();
            if(rs.next())
                resultado=rs.getInt("fid_persona");   
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int tipoUsuario(int id_persona) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call tipoUsuario(?)}");
            cs.setInt("_id_persona", id_persona);
            rs=cs.executeQuery();
            if(rs.next())
                resultado=rs.getInt("tipo_de_usuario");   
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
}
