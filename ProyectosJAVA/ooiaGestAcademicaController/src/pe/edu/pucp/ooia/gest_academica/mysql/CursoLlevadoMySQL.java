
package pe.edu.pucp.ooia.gest_academica.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.ooia.gest_academica.dao.CursoLlevadoDAO;
import pe.edu.pucp.ooia.gest_academica.model.Curso;
import pe.edu.pucp.ooia.gest_academica.model.CursoLlevado;
import pe.edu.pucp.ooia.gest_humana.mysql.AlumnoMySQL;
import pe.edu.pucp.ooia.gest_humana.model.Alumno;

/**
 *
 * @author DAYANA
 */
public class CursoLlevadoMySQL implements CursoLlevadoDAO{
    Connection con; //java.sql.Connection
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<CursoLlevado> listar(int id_alumno) {
       ArrayList<CursoLlevado> cursos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_CURSO_LLEVADO(?)}");
            cs.setInt("_id_alumno",id_alumno);
            rs = cs.executeQuery();
            while(rs.next()){
                CursoLlevado curso = new CursoLlevado();
                curso.setId_curso_llevado(rs.getInt("id_curso_llevado"));
                curso.setCurso(new Curso());
                curso.getCurso().setId_curso(rs.getInt("id_curso"));
                curso.getCurso().setCodigoCurso(rs.getString("codigo_curso"));
                curso.getCurso().setNombreCurso(rs.getString("nombre_curso"));
                curso.setCiclo(rs.getString("ciclo"));
                curso.setVez(rs.getInt("vez"));
                curso.setNotaFinal(rs.getDouble("nota_final"));
                curso.setRetirado(rs.getBoolean("retirado"));
                curso.setFormulaCalificacion(rs.getString("formula_de_calificacion"));
                curso.setAlumno(obtenerAlumno(id_alumno));
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
    public int insertar(CursoLlevado cursoLlevado) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call INSERTAR_CURSO_LLEVADO(?,?,?,?,?,?,?,?)}");
           cs.registerOutParameter("_id_curso_llevado",java.sql.Types.INTEGER);
           cs.setInt("_fid_alumno",cursoLlevado.getAlumno().getId_alumno());
           cs.setInt("_fid_curso",cursoLlevado.getCurso().getId_curso());
           cs.setString("_ciclo",cursoLlevado.getCiclo());
           cs.setInt("_vez",cursoLlevado.getVez());
           cs.setDouble("_nota_final",cursoLlevado.getNotaFinal());
           cs.setBoolean("_retirado",cursoLlevado.isRetirado());
           cs.setString("_formula_de_calificacion",cursoLlevado.getFormulaCalificacion());
           cs.executeUpdate();
           cursoLlevado.setId_curso_llevado(cs.getInt("_id_curso_llevado"));
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
    public int modificar(CursoLlevado cursoLlevado) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call MODIFICAR_CURSO_LLEVADO(?,?,?,?,?,?,?,?)}");
           cs.setInt("_id_curso_llevado",cursoLlevado.getId_curso_llevado());
           cs.setInt("_fid_alumno",cursoLlevado.getAlumno().getId_alumno());
           cs.setInt("_fid_curso",cursoLlevado.getCurso().getId_curso());
           cs.setString("_ciclo",cursoLlevado.getCiclo());
           cs.setInt("_vez",cursoLlevado.getVez());
           cs.setDouble("_nota_final",cursoLlevado.getNotaFinal());
           cs.setBoolean("_retirado",cursoLlevado.isRetirado());
           cs.setString("_formula_de_calificacion",cursoLlevado.getFormulaCalificacion());
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
}
