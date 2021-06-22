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
        @Override
    public  Object[]listar_usuario_correo(String correo){
        int resultado=0;
        Object[]lista=new Object[2];
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call listar_usuario_correo(?)}");
            cs.setString("_usuario", correo);
            rs=cs.executeQuery();
            if(rs.next()){
                lista[0]=rs.getString("correo");
                lista[1]=rs.getInt("id_miembro_pucp");   
            }else{
                lista[0]=null;
                lista[1]=0;
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return lista;
    }
    
    @Override
    public int cambiar_password(int id_miembro_pucp,String password){
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call cambiar_password(?,?)}");
            cs.setInt("_id", id_miembro_pucp);
            cs.setString("_password", password);
            cs.executeUpdate();
            resultado=1;
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
