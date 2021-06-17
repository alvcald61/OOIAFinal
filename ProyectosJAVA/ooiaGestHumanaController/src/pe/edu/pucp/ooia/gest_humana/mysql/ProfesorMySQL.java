package pe.edu.pucp.ooia.gest_humana.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.ooia.gest_humana.dao.ProfesorDAO;
import pe.edu.pucp.ooia.gest_humana.model.Especialidad;
import pe.edu.pucp.ooia.gest_humana.model.Profesor;

/**
 *
 * @author Gerardo
 */
public class ProfesorMySQL implements ProfesorDAO {
    
    Connection con;
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<Profesor> listar() {
        ArrayList<Profesor> profesores = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_PROFESOR()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Profesor profesor = new Profesor();
                /*Persona*/
                profesor.setId_persona(rs.getInt("id_persona"));
                profesor.setNombre(rs.getString("nombre"));
                profesor.setDni(rs.getString("dni"));
                profesor.setFecha_nacimiento(rs.getDate("fecha_nacimiento"));
                profesor.setDireccion(rs.getString("direccion"));
                profesor.setCorreo(rs.getString("correo"));
                /*Miembro PUCP*/
                profesor.setId_miembro_pucp(rs.getInt("id_miembro_pucp"));
                profesor.setUsuario(rs.getString("usuario"));
                profesor.setPassword(rs.getString("password"));
                profesor.setFecha_inclusion(rs.getDate("fecha_inclusion"));
                profesor.setImagenDePerfil(rs.getBytes("imagen_perfil"));
                /*Profesor*/
                profesor.setId_profesor(rs.getInt("id_profesor"));
                profesor.setEspecialidad(new Especialidad(rs.getInt("id_especialidad"),rs.getString("nombre_especialidad")));
                profesor.setFacultad(rs.getString("facultad"));
                profesor.setCategoria(rs.getString("categoria"));
                profesor.setActivo(true);
                profesores.add(profesor);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return profesores;
    }

    @Override
    public int insertar(Profesor profesor) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_PROFESOR(?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_profesor", java.sql.Types.INTEGER);
            /*Persona*/
            cs.setString("_nombre", profesor.getNombre());
            cs.setString("_dni", profesor.getDni());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(profesor.getFecha_nacimiento().getTime()));
            cs.setString("_direccion", profesor.getDireccion());
            cs.setString("_correo", profesor.getCorreo());
            /*Miembro PUCP*/
            cs.setString("_usuario", profesor.getUsuario());
            cs.setString("_password", profesor.getPassword());
            cs.setDate("_fecha_inclusion", new java.sql.Date(profesor.getFecha_inclusion().getTime()));
            cs.setBytes("_imagen_perfil", profesor.getImagenDePerfil());
            /*Profesor*/
            cs.setInt("_fid_especialidad", profesor.getEspecialidad().getId_especialidad());
            cs.setString("_facultad", profesor.getFacultad());
            cs.setString("_categoria", profesor.getCategoria());
            cs.executeUpdate();
            profesor.setId_persona(cs.getInt("_id_profesor"));
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
    public int modificar(Profesor profesor) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_PROFESOR(?,?,?,?,?,?,?,?,?,?,?,?,?)}");

            cs.setInt("_id_profesor", profesor.getId_profesor());
            /*Persona*/
            cs.setString("_nombre", profesor.getNombre());
            cs.setString("_dni", profesor.getDni());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(profesor.getFecha_nacimiento().getTime()));
            cs.setString("_direccion", profesor.getDireccion());
            cs.setString("_correo", profesor.getCorreo());
            /*Miembro PUCP*/
            cs.setString("_usuario", profesor.getUsuario());
            cs.setString("_password", profesor.getPassword());
            cs.setDate("_fecha_inclusion", new java.sql.Date(profesor.getFecha_inclusion().getTime()));
            cs.setBytes("_imagen_perfil", profesor.getImagenDePerfil());
            /*Profesor*/
            cs.setInt("_fid_especialidad", profesor.getEspecialidad().getId_especialidad());
            cs.setString("_facultad", profesor.getFacultad());
            cs.setString("_categoria", profesor.getCategoria());
            
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
    public int eliminar(int id_profesor) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call ELIMINAR_PROFESOR(?)}");
            cs.setInt("_id_profesor", id_profesor);
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
    public Profesor listar_x_id(int id) {
            Profesor profesor = new Profesor();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_PROFESOR_X_ID(?)}");
            cs.setInt("id", id);
            rs = cs.executeQuery();
            rs.next();
            
                /*Persona*/
                profesor.setId_persona(rs.getInt("id_persona"));
                profesor.setNombre(rs.getString("nombre"));
                profesor.setDni(rs.getString("dni"));
                profesor.setFecha_nacimiento(rs.getDate("fecha_nacimiento"));
                profesor.setDireccion(rs.getString("direccion"));
                profesor.setCorreo(rs.getString("correo"));
                /*Miembro PUCP*/
                profesor.setId_miembro_pucp(rs.getInt("id_miembro_pucp"));
                profesor.setUsuario(rs.getString("usuario"));
                profesor.setPassword(rs.getString("password"));
                profesor.setFecha_inclusion(rs.getDate("fecha_inclusion"));
                profesor.setImagenDePerfil(rs.getBytes("imagen_perfil"));
                /*Profesor*/
                profesor.setId_profesor(rs.getInt("id_profesor"));
                profesor.setEspecialidad(new Especialidad(rs.getInt("id_especialidad"),rs.getString("nombre_especialidad")));
                profesor.setFacultad(rs.getString("facultad"));
                profesor.setCategoria(rs.getString("categoria"));
                profesor.setActivo(true);
                
            
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return profesor;
    }
    
    
}
