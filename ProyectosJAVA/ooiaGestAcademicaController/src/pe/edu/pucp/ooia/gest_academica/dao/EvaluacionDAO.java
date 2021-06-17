
package pe.edu.pucp.ooia.gest_academica.dao;

import java.util.ArrayList;
import pe.edu.pucp.ooia.gest_academica.model.Evaluacion;

/**
 *
 * @author DAYANA
 */
public interface EvaluacionDAO {
    public ArrayList<Evaluacion> listar(int id_curso_llevado);
    public int insertar(Evaluacion evaluacion);
    public int modificar(Evaluacion evaluacion);

}
