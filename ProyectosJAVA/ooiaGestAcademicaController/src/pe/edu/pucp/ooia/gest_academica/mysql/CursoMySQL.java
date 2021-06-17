
package pe.edu.pucp.ooia.gest_academica.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.ooia.gest_academica.dao.CursoDAO;
import pe.edu.pucp.ooia.gest_academica.model.Curso;

/**
 *
 * @author DAYANA
 */
public class CursoMySQL implements CursoDAO {
    Connection con; //java.sql.Connection
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<Curso> listar() {
       ArrayList<Curso> cursos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_CURSO()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Curso curso = new Curso();
                curso.setId_curso(rs.getInt("id_curso"));
                curso.setCodigoCurso(rs.getString("codigo_curso"));
                curso.setNombreCurso(rs.getString("nombre_curso"));
                curso.setCreditos(rs.getDouble("creditos"));
                curso.setActivo(true);
                cursos.add(curso);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return cursos;
    }

    @Override
    public int insertar(Curso curso) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call INSERTAR_CURSO(?,?,?,?)}");
           cs.registerOutParameter("_id_curso",java.sql.Types.INTEGER);
           cs.setString("_codigo_curso",curso.getCodigoCurso());
           cs.setString("_nombre_curso",curso.getNombreCurso());
           cs.setDouble("_creditos",curso.getCreditos());
           cs.executeUpdate();
           curso.setId_curso(cs.getInt("_id_curso"));
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
    public int modificar(Curso curso) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call MODIFICAR_CURSO(?,?,?,?)}");
           cs.setInt("_id_curso",curso.getId_curso());
           cs.setString("_codigo_curso",curso.getCodigoCurso());
           cs.setString("_nombre_curso",curso.getNombreCurso());
           cs.setDouble("_creditos",curso.getCreditos());
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
    public int eliminar(int idCurso) {
        int resultado=0;
        try{
            //registrar el driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //creamos la conexion
            con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
            
            cs = con.prepareCall("{call ELIMINAR_CURSO(?)}");
            cs.setInt("_id_curso",idCurso);
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
