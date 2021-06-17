/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.gestion_eventos.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_eventos.model.EventoAlumno;

/**
 *
 * @author PC
 */
public interface EventoAlumnoDAO {
    public ArrayList<EventoAlumno> listar();
    public int insertar(EventoAlumno eventoAlumno);
    public int modificar(EventoAlumno eventoAlumno);
    public int eliminar(int id_evento_alumno);
}
