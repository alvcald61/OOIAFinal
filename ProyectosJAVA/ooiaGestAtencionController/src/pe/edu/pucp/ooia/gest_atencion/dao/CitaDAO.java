package pe.edu.pucp.ooia.gest_atencion.dao;

import java.util.ArrayList;
import pe.edu.pucp.ooia.gest_atencion.model.Cita;

/**
 *
 * @author DAYANA
 */
public interface CitaDAO {
    public ArrayList<Cita> listarPendiente(int id_alumno);
    public ArrayList<Cita> listarHistorico(int id_alumno);
    public ArrayList<Cita> listarHistoricoXNombre(int id_alumno, String nombre);
    public int insertar(Cita cita);
    public int modificar(Cita cita);
    public int eliminar(int id_ita);
    public ArrayList<Cita> listar_proximas_cita_profesor(int id_profesor);
}
