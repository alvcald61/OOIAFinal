package pe.edu.pucp.gestion_eventos.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_eventos.dao.EventoAlumnoDAO;
import pe.edu.pucp.gestion_eventos.model.EventoAlumno;

public class EventoAlumnoMySQL implements EventoAlumnoDAO{

    Connection con;
    Statement st;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public ArrayList<EventoAlumno> listar() {
        ArrayList<EventoAlumno> encuestas  = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("call LISTAR_EVENTO_ALUMNO()");
            
            rs = cs.executeQuery();
            
            while(rs.next()){
                EventoAlumno eventoAlumno = new EventoAlumno();
                eventoAlumno.setId_encuesta(rs.getInt("id_encuesta"));
                eventoAlumno.setId_alumno(rs.getInt("fid_alumno"));
                eventoAlumno.setId_evento(rs.getInt("fid_evento"));
                eventoAlumno.setValoracionPonentes(rs.getInt("valoracion_ponentes"));
                eventoAlumno.setValoracionEvento(rs.getInt("valoracion_evento"));
                eventoAlumno.setValoracionUtilidad(rs.getInt("valoracion_utilidad"));
                eventoAlumno.setAsistio(rs.getBoolean("asistencia"));
                eventoAlumno.setComentario(rs.getString("comentario"));
                encuestas.add(eventoAlumno);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            
        }
        return encuestas;
    }

    @Override
    public int insertar(EventoAlumno eventoAlumno) {
        int resultado = 0;
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("call INSERTAR_EVENTO_ALUMNO(?,?,?,?,?,?,?,?)");
            //SETEAMOS los parametros
            
            //Insertamos en encuesta_evento
            cs.setInt("_id_encuesta", eventoAlumno.getId_encuesta());
            cs.setInt("_fid_alumno", eventoAlumno.getId_alumno());
            cs.setInt("_fid_evento", eventoAlumno.getId_evento());
            cs.setInt("_valoracion_ponentes", eventoAlumno.getValoracionPonentes());
            cs.setInt("_valoracion_evento", eventoAlumno.getValoracionEvento());
            cs.setInt("_valoracion_utilidad", eventoAlumno.getValoracionUtilidad());
            cs.setBoolean("_asistencia", eventoAlumno.isAsistio());
            cs.setString("_comentario", eventoAlumno.getComentario());
    
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
    public int modificar(EventoAlumno eventoAlumno) {
        int resultado = 0;
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("call MODIFICAR_EVENTO_ALUMNO(?,?,?,?,?,?,?,?)");
            //SETEAMOS los parametros
            
            //Insertamos en encuesta_evento
            cs.setInt("_id_encuesta", eventoAlumno.getId_encuesta());
            cs.setInt("_fid_alumno", eventoAlumno.getId_alumno());
            cs.setInt("_fid_evento", eventoAlumno.getId_evento());
            cs.setInt("_valoracion_ponentes", eventoAlumno.getValoracionPonentes());
            cs.setInt("_valoracion_evento", eventoAlumno.getValoracionEvento());
            cs.setInt("_valoracion_utilidad", eventoAlumno.getValoracionUtilidad());
            cs.setBoolean("_asistencia", eventoAlumno.isAsistio());
            cs.setString("_comentario", eventoAlumno.getComentario());
    
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
    public int eliminar(int id_evento_alumno) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("call ELIMINAR_EVENTO_ALUMNO(?)");
            //SETEAMOS los parametros
            cs.setInt("_id_evento_alumno", id_evento_alumno);

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
    
    
}