package pe.edu.pucp.ooia.gest_academica.dao;
import java.util.ArrayList;
import pe.edu.pucp.ooia.gest_academica.model.CursoLlevado;

/**
 *
 * @author DAYANA
 */
public interface CursoLlevadoDAO {
    public ArrayList<CursoLlevado> listar(int id_alumno);
    public int insertar(CursoLlevado cursoLlevado);
    public int modificar(CursoLlevado cursoLlevado);
    
}
