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
    
    
}
