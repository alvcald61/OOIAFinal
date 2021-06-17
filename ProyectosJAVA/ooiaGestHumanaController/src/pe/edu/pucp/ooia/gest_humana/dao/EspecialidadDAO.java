package pe.edu.pucp.ooia.gest_humana.dao;

import java.util.ArrayList;
import pe.edu.pucp.ooia.gest_humana.model.Especialidad;

/**
 *
 * @author Gerardo
 */
public interface EspecialidadDAO {
    public ArrayList<Especialidad> listar();
    public int insertar(Especialidad especialidad);
    public int modificar(Especialidad especialidad);
    public int eliminar(int id_especialidad);
}
