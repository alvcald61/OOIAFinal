package pe.edu.pucp.ooia.gest_humana.dao;

import java.util.ArrayList;
import pe.edu.pucp.ooia.gest_humana.model.Ponente;

/**
 *
 * @author Gerardo
 */
public interface PonenteDao {
    public ArrayList<Ponente> listar();
    public int insertar(Ponente ponente);
    public int modificar(Ponente ponente);
    public int eliminar(int id_ponente);
}
