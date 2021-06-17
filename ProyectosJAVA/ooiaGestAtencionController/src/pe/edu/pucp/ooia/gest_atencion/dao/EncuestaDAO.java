package pe.edu.pucp.ooia.gest_atencion.dao;

import java.util.ArrayList;
import pe.edu.pucp.ooia.gest_atencion.model.Encuesta;


/**
 *
 * @author DAYANA
 */
public interface EncuestaDAO {
    public ArrayList<Encuesta> listar();
    public ArrayList<Encuesta> listarXAsesor(int id_asesor);
    public ArrayList<Encuesta> listarXAlumno(int id_alumno);
    public int insertar(Encuesta encuesta);
    public int modificar(Encuesta encuesta);
    public int eliminar(int id_encuesta);
}
