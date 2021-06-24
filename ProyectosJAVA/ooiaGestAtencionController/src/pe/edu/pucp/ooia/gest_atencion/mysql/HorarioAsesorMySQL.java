
package pe.edu.pucp.ooia.gest_atencion.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.ooia.gest_atencion.dao.HorarioAsesorDAO;
import pe.edu.pucp.ooia.gest_atencion.model.Horario;
import pe.edu.pucp.ooia.gest_atencion.model.HorarioAsesor;

/**
 *
 * @author DAYANA
 */
public class HorarioAsesorMySQL implements HorarioAsesorDAO{
    Connection con; //java.sql.Connection
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<HorarioAsesor> listar(int idAsesor) {
         ArrayList<HorarioAsesor> horarios = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_HORARIO_ASESOR(?)}");
            cs.setInt("_id_asesor",idAsesor);
            rs = cs.executeQuery();
            while(rs.next()){
                HorarioAsesor horario = new HorarioAsesor();
                horario.setId_horario_asesor(rs.getInt("id_horario_asesor"));
                horario.setFid_asesor(rs.getInt("fid_asesor"));
                horario.setEstado(rs.getString("estado"));
                horario.setHorario(new Horario());
                horario.getHorario().setId_horario(rs.getInt("id_horario"));
                horario.getHorario().setDia(rs.getInt("dia"));
                horario.getHorario().setHoraInicio(rs.getTime("hora_inicio"));
                horario.getHorario().setHoraFin(rs.getTime("hora_fin"));
                horarios.add(horario);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return horarios;
    }

    @Override
    public int insertar(HorarioAsesor horario) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call INSERTAR_HORARIO_ASESOR(?,?,?,?)}");
           cs.registerOutParameter("_id_horario_asesor",java.sql.Types.INTEGER);
           cs.setInt("_fid_horario",horario.getHorario().getId_horario());
           cs.setInt("_fid_asesor",horario.getFid_asesor());
           cs.setString("_estado", horario.getEstado());
           cs.executeUpdate();
           horario.setId_horario_asesor(cs.getInt("_id_horario_asesor"));
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

    @Override
    public int modificar(HorarioAsesor horario) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call MODIFICAR_HORARIO_ASESOR(?,?,?,?)}");
           cs.setInt("_id_horario_asesor",horario.getId_horario_asesor());
           cs.setInt("_fid_horario",horario.getHorario().getId_horario());
           cs.setInt("_fid_asesor",horario.getFid_asesor());
           cs.setString("_estado", horario.getEstado());
           cs.executeUpdate();
           horario.setId_horario_asesor(cs.getInt("_id_horario_asesor"));
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

    @Override
    public int eliminar(int idHorarioAsesor) {
         int resultado=0;
        try{
            //registrar el driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //creamos la conexion
            con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
            
            cs = con.prepareCall("{call ELIMINAR_HORARIO_ASESOR(?)}");
            cs.setInt("_id_horario_asesor",idHorarioAsesor);
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
    
}
