package pe.edu.pucp.ooia.gest_atencion.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.ooia.gest_atencion.model.CodigoAtencion;
import pe.edu.pucp.ooia.gest_atencion.dao.CodigoAtencionDAO;

/**
 *
 * @author DAYANA
 */
public class CodigoAtencionMySQL implements CodigoAtencionDAO {
    Connection con; //java.sql.Connection
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<CodigoAtencion> listar() {
        ArrayList<CodigoAtencion> codigos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_CODIGO_ATENCION()}");
            rs = cs.executeQuery();
            while(rs.next()){
                CodigoAtencion codigo = new CodigoAtencion();
                codigo.setId_codigo_atencion(rs.getInt("id_codigo_atencion"));
                codigo.setCodigo(rs.getString("codigo"));
                codigo.setDescripcion(rs.getString("descripcion"));
                codigo.setActivo(true);
                codigos.add(codigo);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return codigos;
    }

    @Override
    public int insertar(CodigoAtencion codigo) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call INSERTAR_CODIGO_ATENCION(?,?,?)}");
           cs.registerOutParameter("_id_codigo_atencion",java.sql.Types.INTEGER);
           cs.setString("_codigo",codigo.getCodigo());
           cs.setString("_descripcion",codigo.getDescripcion());
           cs.executeUpdate();
           codigo.setId_codigo_atencion(cs.getInt("_id_codigo_atencion"));
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
    public int modificar(CodigoAtencion codigo) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call MODIFICAR_CODIGO_ATENCION(?,?,?)}");
           cs.setInt("_id_codigo_atencion",codigo.getId_codigo_atencion());
           cs.setString("_codigo",codigo.getCodigo());
           cs.setString("_descripcion",codigo.getDescripcion());
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

    @Override
    public int eliminar(int id_codigo_atencion) {
        int resultado=0;
        try{
            //registrar el driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //creamos la conexion
            con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
            
            cs = con.prepareCall("{call ELIMINAR_CODIGO_ATENCION(?)}");
            cs.setInt("_id_codigo_atencion", id_codigo_atencion);
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
