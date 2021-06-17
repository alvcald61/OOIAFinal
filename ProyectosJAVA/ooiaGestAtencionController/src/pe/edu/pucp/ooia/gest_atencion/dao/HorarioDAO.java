package pe.edu.pucp.ooia.gest_atencion.dao;

import java.util.ArrayList;
import pe.edu.pucp.ooia.gest_atencion.model.Horario;

/**
 *
 * @author DAYANA
 */
public interface HorarioDAO {
    public ArrayList<Horario> listar();
    public int insertar(Horario horario);
    public int modificar(Horario horario);
    public int eliminar(int idHorario);
}
