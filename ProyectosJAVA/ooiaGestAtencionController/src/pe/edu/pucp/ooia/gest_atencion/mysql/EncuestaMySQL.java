package pe.edu.pucp.ooia.gest_atencion.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.ooia.gest_atencion.dao.EncuestaDAO;
import pe.edu.pucp.ooia.gest_atencion.model.Encuesta;
import pe.edu.pucp.ooia.gest_humana.model.Alumno;
import pe.edu.pucp.ooia.gest_humana.model.Profesor;
import pe.edu.pucp.ooia.gest_humana.model.Psicologo;
import pe.edu.pucp.ooia.gest_humana.mysql.AlumnoMySQL;
import pe.edu.pucp.ooia.gest_humana.mysql.ProfesorMySQL;
import pe.edu.pucp.ooia.gest_humana.mysql.PsicologoMySQL;

/**
 *
 * @author DAYANA
 */
public class EncuestaMySQL implements EncuestaDAO{
    Connection con; //java.sql.Connection
    Statement st; //java.sql.Statement
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<Encuesta> listar() {
        ArrayList<Encuesta> encuestas = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_ENCUESTA()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Encuesta encuesta = new Encuesta();
                encuesta.setId_encuesta(rs.getInt("id_encuesta"));
                encuesta.setPuntaje(rs.getDouble("puntaje"));
                encuesta.setDescripcion(rs.getString("descripcion"));
                encuesta.setAlumno(new Alumno());
                encuesta.setAlumno(obtenerAlumno(rs.getInt("fid_alumno")));
                encuesta.setTipo_asesor(rs.getInt("tipo_asesor"));
                if(encuesta.getTipo_asesor() == 0){
                    encuesta.setAsesor(new Profesor());
                    encuesta.setAsesor(obtenerProfesor(rs.getInt("fid_asesor")));
                }
                else if(encuesta.getTipo_asesor() == 1){
                    encuesta.setAsesor(new Psicologo());
                    encuesta.setAsesor(obtenerPsicologo(rs.getInt("fid_asesor")));
                }
                encuesta.setActivo(true);
                encuestas.add(encuesta);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return encuestas;
    }

    @Override
    public ArrayList<Encuesta> listarXAlumno(int id_alumno) {
        ArrayList<Encuesta> encuestas = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_ENCUESTA_X_ALUMNO(?)}");
            cs.setInt("_id_alumno",id_alumno);
            rs = cs.executeQuery();
            while(rs.next()){
                Encuesta encuesta = new Encuesta();
                encuesta.setId_encuesta(rs.getInt("id_encuesta"));
                encuesta.setPuntaje(rs.getDouble("puntaje"));
                encuesta.setDescripcion(rs.getString("descripcion"));
                encuesta.setAlumno(new Alumno());
                encuesta.setAlumno(obtenerAlumno(rs.getInt("fid_alumno")));
                encuesta.setTipo_asesor(rs.getInt("tipo_asesor"));
                if(encuesta.getTipo_asesor() == 0){
                    encuesta.setAsesor(new Profesor());
                    encuesta.setAsesor(obtenerProfesor(rs.getInt("fid_asesor")));
                }
                else if(encuesta.getTipo_asesor() == 1){
                    encuesta.setAsesor(new Psicologo());
                    encuesta.setAsesor(obtenerPsicologo(rs.getInt("fid_asesor")));
                }
                encuesta.setActivo(true);
                encuestas.add(encuesta);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return encuestas;
    }
    
    @Override
    public ArrayList<Encuesta> listarXAsesor(int id_asesor) {
        ArrayList<Encuesta> encuestas = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_ENCUESTA_X_ASESOR(?)}");
            cs.setInt("_id_asesor",id_asesor);
            rs = cs.executeQuery();
            while(rs.next()){
                Encuesta encuesta = new Encuesta();
                encuesta.setId_encuesta(rs.getInt("id_encuesta"));
                encuesta.setPuntaje(rs.getDouble("puntaje"));
                encuesta.setDescripcion(rs.getString("descripcion"));
                encuesta.setAlumno(new Alumno());
                encuesta.setAlumno(obtenerAlumno(rs.getInt("fid_alumno")));
                encuesta.setTipo_asesor(rs.getInt("tipo_asesor"));
                if(encuesta.getTipo_asesor() == 0){
                    encuesta.setAsesor(new Profesor());
                    encuesta.setAsesor(obtenerProfesor(rs.getInt("fid_asesor")));
                }
                else if(encuesta.getTipo_asesor() == 1){
                    encuesta.setAsesor(new Psicologo());
                    encuesta.setAsesor(obtenerPsicologo(rs.getInt("fid_asesor")));
                }
                encuesta.setActivo(true);
                encuestas.add(encuesta);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return encuestas;
    }
    
    
    @Override
    public int insertar(Encuesta encuesta) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_ENCUESTA(?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_encuesta", java.sql.Types.INTEGER);
            cs.setDouble("_puntaje", encuesta.getPuntaje());
            cs.setString("_descripcion", encuesta.getDescripcion());
            cs.setInt("_fid_alumno", encuesta.getAlumno().getId_alumno());
            cs.setInt("_tipo_asesor", encuesta.getTipo_asesor());
            cs.setInt("_fid_asesor", encuesta.getAsesor().getId_miembro_pucp());
            cs.executeUpdate();
            encuesta.setId_encuesta(cs.getInt("_id_encuesta"));
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
    public int modificar(Encuesta encuesta) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_ENCUESTA(?,?,?,?,?,?)}");
            cs.setInt("_id_encuesta", encuesta.getId_encuesta());
            cs.setDouble("_puntaje", encuesta.getPuntaje());
            cs.setString("_descripcion", encuesta.getDescripcion());
            cs.setInt("_fid_alumno", encuesta.getAlumno().getId_alumno());
            cs.setInt("_tipo_asesor", encuesta.getTipo_asesor());
            cs.setInt("_fid_asesor", encuesta.getAsesor().getId_miembro_pucp());
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
    public int eliminar(int id_encuesta) {
        int resultado=0;
        try{
            //registrar el driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //creamos la conexion
            con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
            
            cs = con.prepareCall("{call ELIMINAR_ENCUESTA(?)}");
            cs.setInt("_id_encuesta", id_encuesta);
            cs.executeUpdate();
            resultado=1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            //esto siempre se va a ejecutar
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
    
    private Alumno obtenerAlumno(int id_alumno) {
        ArrayList<Alumno> arrayList=new AlumnoMySQL().listar();
        for(Alumno aux:arrayList)
            if(aux.getId_alumno()==id_alumno)
                return aux;
        return null;
    } 
    
    private Profesor obtenerProfesor(int id_profesor) {
        ArrayList<Profesor> arrayList=new ProfesorMySQL().listar();
        for(Profesor aux:arrayList)
            if(aux.getId_profesor()==id_profesor)
                return aux;
        return null;
    } 
    
    private Psicologo obtenerPsicologo(int id_psicologo) {
        ArrayList<Psicologo> arrayList=new PsicologoMySQL().listar();
        for(Psicologo aux:arrayList)
            if(aux.getId_psicologo()==id_psicologo)
                return aux;
        return null;
    } 
}
