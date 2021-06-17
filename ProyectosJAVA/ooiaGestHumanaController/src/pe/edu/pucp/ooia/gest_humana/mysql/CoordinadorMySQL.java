package pe.edu.pucp.ooia.gest_humana.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.ooia.gest_humana.dao.CoordinadorDAO;
import pe.edu.pucp.ooia.gest_humana.model.Coordinador;

public class CoordinadorMySQL implements CoordinadorDAO{

    Connection con;
    Statement st;
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<Coordinador> listar() {
        
        ArrayList<Coordinador> coordinadores = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_COORDINADOR()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Coordinador coordinador = new Coordinador();
                /*Persona*/
                coordinador.setId_persona(rs.getInt("id_persona"));
                coordinador.setNombre(rs.getString("nombre"));
                coordinador.setDni(rs.getString("dni"));
                coordinador.setFecha_nacimiento(rs.getDate("fecha_nacimiento"));
                coordinador.setDireccion(rs.getString("direccion"));
                coordinador.setCorreo(rs.getString("correo"));
                /*Miembro PUCP*/
                coordinador.setId_miembro_pucp(rs.getInt("id_miembro_pucp"));
                coordinador.setUsuario(rs.getString("usuario"));
                coordinador.setPassword(rs.getString("password"));
                coordinador.setFecha_inclusion(rs.getDate("fecha_inclusion"));
                coordinador.setImagenDePerfil(rs.getBytes("imagen_perfil"));
                /*Coordinador*/
                coordinador.setId_coordinador(rs.getInt("id_coordinador"));
                coordinador.setRol(rs.getString("rol"));
                coordinador.setActivo(true);
                coordinadores.add(coordinador);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            
        }
        return coordinadores;
    }

    @Override
    public int insertar(Coordinador coordinador) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_COORDINADOR(?,?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_coordinador", java.sql.Types.INTEGER);
            /*Persona*/
            cs.setString("_nombre", coordinador.getNombre());
            cs.setString("_dni", coordinador.getDni());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(coordinador.getFecha_nacimiento().getTime()));
            cs.setString("_direccion", coordinador.getDireccion());
            cs.setString("_correo", coordinador.getCorreo());
            /*Miembro PUCP*/
            cs.setString("_usuario", coordinador.getUsuario());
            cs.setString("_password", coordinador.getPassword());
            cs.setDate("_fecha_inclusion", new java.sql.Date(coordinador.getFecha_inclusion().getTime()));
            cs.setBytes("_imagen_perfil", coordinador.getImagenDePerfil());
            /*Coordinador*/
            cs.setString("_rol", coordinador.getRol());
            //Ejecutamos el procedimiento
            cs.executeUpdate();
            //Rescatamos los id's que se generaron automaticamente
            coordinador.setId_miembro_pucp(cs.getInt("_id_coordinador"));
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return resultado;
    }

    @Override
    public int modificar(Coordinador coordinador) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_COORDINADOR(?,?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_coordinador", coordinador.getId_coordinador());
            /*Persona*/
            cs.setString("_nombre", coordinador.getNombre());
            cs.setString("_dni", coordinador.getDni());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(coordinador.getFecha_nacimiento().getTime()));
            cs.setString("_direccion", coordinador.getDireccion());
            cs.setString("_correo", coordinador.getCorreo());
            /*Miembro PUCP*/
            cs.setString("_usuario", coordinador.getUsuario());
            cs.setString("_password", coordinador.getPassword());
            cs.setDate("_fecha_inclusion", new java.sql.Date(coordinador.getFecha_inclusion().getTime()));
            cs.setBytes("_imagen_perfil", coordinador.getImagenDePerfil());
            /*Coordinador*/
            cs.setString("_rol", coordinador.getRol());
            //Ejecutamos el procedimiento
            cs.executeUpdate();
            
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return resultado;
    }

    @Override
    public int eliminar(int id_coordinador) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("call ELIMINAR_COORDINADOR(?)");
            cs.setInt("_id_coordinador", id_coordinador);
            //Hacemos la eliminacion logica
            cs.executeUpdate();
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return resultado;
    }

    @Override
    public Coordinador listar_x_id(int id) {
                        Coordinador coordinador = new Coordinador();

        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_COORDINADOR_X_ID (?)}");
            cs.setInt("id", id);
            rs = cs.executeQuery();
            rs.next();
                /*Persona*/
                coordinador.setId_persona(rs.getInt("id_persona"));
                coordinador.setNombre(rs.getString("nombre"));
                coordinador.setDni(rs.getString("dni"));
                coordinador.setFecha_nacimiento(rs.getDate("fecha_nacimiento"));
                coordinador.setDireccion(rs.getString("direccion"));
                coordinador.setCorreo(rs.getString("correo"));
                /*Miembro PUCP*/
                coordinador.setId_miembro_pucp(rs.getInt("id_miembro_pucp"));
                coordinador.setUsuario(rs.getString("usuario"));
                coordinador.setPassword(rs.getString("password"));
                coordinador.setFecha_inclusion(rs.getDate("fecha_inclusion"));
                coordinador.setImagenDePerfil(rs.getBytes("imagen_perfil"));
                /*Coordinador*/
                coordinador.setId_coordinador(rs.getInt("id_coordinador"));
                coordinador.setRol(rs.getString("rol"));
                coordinador.setActivo(true);
                

            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            
        }
        return coordinador;
    }
    
    
    
    
}