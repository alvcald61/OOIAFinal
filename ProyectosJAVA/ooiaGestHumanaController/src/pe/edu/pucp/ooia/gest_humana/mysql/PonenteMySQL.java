package pe.edu.pucp.ooia.gest_humana.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.ooia.gest_humana.model.Ponente;
import pe.edu.pucp.ooia.gest_humana.dao.PonenteDao;

/**
 *
 * @author Gerardo
 */
public class PonenteMySQL implements PonenteDao{

    Connection con;
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<Ponente> listar() {        
        ArrayList<Ponente> ponentes = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_PONENTE()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Ponente ponente = new Ponente();
                /*Persona*/
                ponente.setId_persona(rs.getInt("id_persona"));
                ponente.setNombre(rs.getString("nombre"));
                ponente.setDni(rs.getString("dni"));
                ponente.setFecha_nacimiento(rs.getDate("fecha_nacimiento"));
                ponente.setDireccion(rs.getString("direccion"));
                ponente.setCorreo(rs.getString("correo"));
                /*Miembro Externo*/
                ponente.setId_miembro_externo(rs.getInt("id_miembro_externo"));
                ponente.setTelefono(rs.getString("telefono"));
                ponente.setOcupacion(rs.getString("ocupacion"));
                /*Ponente*/
                ponente.setId_ponente(rs.getInt("id_ponente"));
                ponente.setOrganizacion(rs.getString("organizacion"));
                ponente.setActivo(true);
                ponentes.add(ponente);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return ponentes;
    }

    @Override
    public int insertar(Ponente ponente) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_PONENTE(?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_ponente", java.sql.Types.INTEGER);
            /*Persona*/
            cs.setString("_nombre", ponente.getNombre());
            cs.setString("_dni", ponente.getDni());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(ponente.getFecha_nacimiento().getTime()));
            cs.setString("_correo", ponente.getCorreo());
            cs.setString("_direccion", ponente.getDireccion());
            /*Miembro Externo*/
            cs.setString("_telefono", ponente.getTelefono());
            cs.setString("_ocupacion", ponente.getOcupacion());
            /*Ponente*/
            cs.setString("_organizacion",ponente.getOrganizacion());
            cs.executeUpdate();
            ponente.setId_persona(cs.getInt("_id_invitado"));
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Ponente ponente) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_PONENTE(?,?,?,?,?,?,?,?,?)}");
            
            cs.setInt("_id_ponente", ponente.getId_ponente());
            /*Persona*/
            cs.setString("_nombre", ponente.getNombre());
            cs.setString("_dni", ponente.getDni());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(ponente.getFecha_nacimiento().getTime()));
            cs.setString("_correo", ponente.getCorreo());
            cs.setString("_direccion", ponente.getDireccion());
            /*Miembro Externo*/
            cs.setString("_telefono", ponente.getTelefono());
            cs.setString("_ocupacion", ponente.getOcupacion());
            /*Ponente*/
            cs.setString("_organizacion",ponente.getOrganizacion());
            cs.executeUpdate();
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int id_ponente) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call ELIMINAR_PONENTE(?)}");
            cs.setInt("_id_ponente", id_ponente);
            cs.executeUpdate();
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
}