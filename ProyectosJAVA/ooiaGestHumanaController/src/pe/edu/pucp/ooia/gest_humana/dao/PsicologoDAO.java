package pe.edu.pucp.ooia.gest_humana.dao;

import java.util.ArrayList;
import pe.edu.pucp.ooia.gest_humana.model.Psicologo;

/**
 *
 * @author Gerardo
 */
public interface PsicologoDAO {
    public ArrayList<Psicologo> listar();
    public Psicologo listar_x_id(int id);
    public int insertar(Psicologo psicologo);
    public int modificar(Psicologo psicologo);
    public int eliminar(int id_psicologo);
    
}
