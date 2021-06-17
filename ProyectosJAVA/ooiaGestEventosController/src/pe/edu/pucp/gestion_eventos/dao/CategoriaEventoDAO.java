package pe.edu.pucp.gestion_eventos.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_eventos.model.CategoriaEvento;

/**
 *
 * @author Gerardo
 */
public interface CategoriaEventoDAO {
    public ArrayList<CategoriaEvento> listar();
    public int insertar(CategoriaEvento categoria);
    public int modificar(CategoriaEvento categoria);
    public int eliminar(int id_categoria);
}
