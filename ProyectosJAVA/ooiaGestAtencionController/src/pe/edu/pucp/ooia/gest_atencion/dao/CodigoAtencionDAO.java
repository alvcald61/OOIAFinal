package pe.edu.pucp.ooia.gest_atencion.dao;

import java.util.ArrayList;
import pe.edu.pucp.ooia.gest_atencion.model.CodigoAtencion;

/**
 *
 * @author DAYANA
 */
public interface CodigoAtencionDAO {
    public ArrayList<CodigoAtencion> listar();
    public int insertar(CodigoAtencion codigo);
    public int modificar(CodigoAtencion codigo);
    public int eliminar(int id_codigo_atencion);
}
