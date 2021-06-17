package pe.edu.pucp.ooia.gest_academica.dao;

import java.util.ArrayList;
import pe.edu.pucp.ooia.gest_academica.model.Curso;

/**
 *
 * @author DAYANA
 */
public interface CursoDAO {
    public ArrayList<Curso> listar();
    public int insertar(Curso curso);
    public int modificar(Curso curso);
    public int eliminar(int idCurso);
}
