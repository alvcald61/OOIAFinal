package pe.edu.pucp.ooia.gest_humana.dao;

import java.util.ArrayList;
import pe.edu.pucp.ooia.gest_humana.model.Profesor;

/**
 *
 * @author Gerardo
 */
public interface ProfesorDAO {
    public ArrayList<Profesor> listar();
    public Profesor listar_x_id(int id);
    public int insertar(Profesor profesor);
    public int modificar(Profesor profesor);
    public int eliminar(int id_profesor);
    
}
