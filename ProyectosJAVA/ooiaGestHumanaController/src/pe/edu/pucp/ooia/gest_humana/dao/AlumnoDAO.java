package pe.edu.pucp.ooia.gest_humana.dao;

import java.util.ArrayList;
import pe.edu.pucp.ooia.gest_humana.model.Alumno;

/**
 *
 * @author Gerardo
 */
public interface AlumnoDAO {
    public ArrayList<Alumno> listar();
    public Alumno listar_x_id(int id);
    public int insertar(Alumno alumno);
    public int modificar(Alumno alumno);
    public int eliminar(int id_alumno);
   
}
