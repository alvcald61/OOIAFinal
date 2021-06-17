/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.OOIA.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.gestion_eventos.dao.EventoAlumnoDAO;
import pe.edu.pucp.gestion_eventos.model.EventoAlumno;
import pe.edu.pucp.gestion_eventos.model.EventoAlumno;
import pe.edu.pucp.gestion_eventos.mysql.EventoAlumnoMySQL;

/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "EventoAlumno")
public class EventoAlumnoWS {
    private EventoAlumnoDAO evento;
    /**
     * This is a sample web service operation
     */
    
    public EventoAlumnoWS() {
        evento=new EventoAlumnoMySQL();
        
    }

    @WebMethod(operationName = "listarEncuestaEvento")
    public ArrayList<EventoAlumno> listarEncuestaEvento() {
        ArrayList<EventoAlumno> lista= new ArrayList<>();
        try {
            lista=evento.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "insertarEncuestaEvento")
    public int insertarEncuestaEvento(@WebParam(name = "evento")EventoAlumno evento){
        int resultado=0;
        try {
            resultado=this.evento.insertar(evento);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarEncuestaEvento")
    public int modificarEncuestaEvento(@WebParam(name = "evento")EventoAlumno evento){
        int resultado=0;
        try {
            resultado=this.evento.modificar(evento);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarEncuestaEvento")
    public int eliminarEncuestaEvento(@WebParam(name = "evento")EventoAlumno evento){
        int resultado=0;
        try {
            resultado=this.evento.eliminar(evento.getId_encuesta());
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
}
