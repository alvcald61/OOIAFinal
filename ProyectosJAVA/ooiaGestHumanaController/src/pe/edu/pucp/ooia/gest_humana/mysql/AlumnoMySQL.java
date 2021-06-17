package pe.edu.pucp.ooia.gest_humana.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.ooia.gest_humana.dao.AlumnoDAO;
import pe.edu.pucp.ooia.gest_humana.model.Alumno;
import pe.edu.pucp.ooia.gest_humana.model.Especialidad;

/**
 *
 * @author Gerardo
 */
public class AlumnoMySQL implements AlumnoDAO{

    Connection con;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public ArrayList<Alumno> listar() {
        ArrayList<Alumno> alumnos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_ALUMNO()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Alumno alumno = new Alumno();
                /*Persona*/
                alumno.setId_persona(rs.getInt("id_persona"));
                alumno.setNombre(rs.getString("nombre"));
                alumno.setDni(rs.getString("dni"));
                alumno.setFecha_nacimiento(rs.getDate("fecha_nacimiento"));
                alumno.setDireccion(rs.getString("direccion"));
                alumno.setCorreo(rs.getString("correo"));
                /*Miembro PUCP*/
                alumno.setId_miembro_pucp(rs.getInt("id_miembro_pucp"));
                alumno.setUsuario(rs.getString("usuario"));
                alumno.setPassword(rs.getString("password"));
                alumno.setFecha_inclusion(rs.getDate("fecha_inclusion"));
                alumno.setImagenDePerfil(rs.getBytes("imagen_perfil"));
                /*Alumno*/
                alumno.setId_alumno(rs.getInt("id_alumno") );
                alumno.setCodigo(rs.getString("codigo"));
                alumno.setEspecialidad(new Especialidad(rs.getInt("fid_especialidad"), rs.getString("nombre_especialidad")));
                alumno.setCraest(rs.getDouble("craest"));
                alumno.setCreditos_aprobados(rs.getDouble("creditos_aprobados"));
                alumnos.add(alumno);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return alumnos;
    }

    @Override
    public int insertar(Alumno alumno) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_ALUMNO(?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_alumno", java.sql.Types.INTEGER);
            /*Persona*/
            cs.setString("_nombre", alumno.getNombre());
            cs.setString("_dni", alumno.getDni());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(alumno.getFecha_nacimiento().getTime()));
            cs.setString("_direccion", alumno.getDireccion());
            cs.setString("_correo", alumno.getCorreo());
            /*Miembro PUCP*/
            cs.setString("_usuario", alumno.getUsuario());
            cs.setString("_password", alumno.getPassword());
            cs.setDate("_fecha_inclusion", new java.sql.Date(alumno.getFecha_inclusion().getTime()));
            cs.setBytes("_imagen_perfil", alumno.getImagenDePerfil());
            /*Alumno*/
            cs.setString("_codigo", alumno.getCodigo());
            cs.setInt("_fid_especialidad", alumno.getEspecialidad().getId_especialidad());
            cs.setDouble("_craest", alumno.getCraest());
            cs.setDouble("_creditos_aprobados", alumno.getCreditos_aprobados());
            cs.executeUpdate();
            alumno.setId_alumno(cs.getInt("_id_alumno"));
            resultado = alumno.getId_alumno();
            cs.close();
        }catch(Exception ex){
            Logger.getLogger(AlumnoMySQL.class.getName()).log(Level.SEVERE, null, ex);
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Alumno alumno) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_ALUMNO(?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_alumno", alumno.getId_alumno());
            /*Persona*/
            cs.setString("_nombre", alumno.getNombre());
            cs.setString("_dni", alumno.getDni());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(alumno.getFecha_nacimiento().getTime()));
            cs.setString("_correo", alumno.getCorreo());
            cs.setString("_direccion", alumno.getDireccion());
            /*Miembro PUCP*/
            cs.setString("_usuario", alumno.getUsuario());
            cs.setString("_password", alumno.getPassword());
            cs.setDate("_fecha_inclusion", new java.sql.Date(alumno.getFecha_inclusion().getTime()));
            cs.setBytes("_imagen_perfil", alumno.getImagenDePerfil());
            /*Alumno*/
            cs.setString("_codigo", alumno.getCodigo());
            cs.setInt("_fid_especialidad", alumno.getEspecialidad().getId_especialidad());
            cs.setDouble("_craest", alumno.getCraest());
            cs.setDouble("_creditos_aprobados", alumno.getCreditos_aprobados());
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
    public int eliminar(int id_alumno) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call ELIMINAR_ALUMNO(?)}");
            cs.setInt("_id_alumno", id_alumno);
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
    public Alumno listar_x_id(int id) {
        Alumno alumno = new Alumno();
                /*Persona*/
        try{
                Class.forName("com.mysql.cj.jdbc.Driver");
                con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
                cs = con.prepareCall("{call LISTAR_ALUMNO_X_ID(?)}");
                cs.setInt("_id", id);
                rs = cs.executeQuery();
                rs.next();
                alumno.setId_persona(rs.getInt("id_persona"));
                alumno.setNombre(rs.getString("nombre"));
                alumno.setDni(rs.getString("dni"));
                alumno.setFecha_nacimiento(rs.getDate("fecha_nacimiento"));
                alumno.setDireccion(rs.getString("direccion"));
                alumno.setCorreo(rs.getString("correo"));
                /*Miembro PUCP*/
                alumno.setId_miembro_pucp(rs.getInt("id_miembro_pucp"));
                alumno.setUsuario(rs.getString("usuario"));
                alumno.setPassword(rs.getString("password"));
                alumno.setFecha_inclusion(rs.getDate("fecha_inclusion"));
                alumno.setImagenDePerfil(rs.getBytes("imagen_perfil"));
                /*Alumno*/
                alumno.setId_alumno(rs.getInt("id_alumno") );
                alumno.setCodigo(rs.getString("codigo"));
                alumno.setEspecialidad(new Especialidad(rs.getInt("fid_especialidad"), rs.getString("nombre_especialidad")));
                alumno.setCraest(rs.getDouble("craest"));
                alumno.setCreditos_aprobados(rs.getDouble("creditos_aprobados"));
                
                }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
               return alumno;
    }

    
    }
  


