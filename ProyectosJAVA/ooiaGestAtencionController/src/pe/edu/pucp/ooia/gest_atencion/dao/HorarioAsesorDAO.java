
package pe.edu.pucp.ooia.gest_atencion.dao;

import java.util.ArrayList;
import pe.edu.pucp.ooia.gest_atencion.model.HorarioAsesor;

/**
 *
 * @author DAYANA
 */
public interface HorarioAsesorDAO {
      public ArrayList<HorarioAsesor> listar(int idAsesor);
    public int insertar(HorarioAsesor horario);
    public int modificar(HorarioAsesor horario);
    public int eliminar(int idHorarioAsesor);  
}
