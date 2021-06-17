/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.OOIA.services;

import java.sql.Date;
import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.gestion_eventos.dao.EventoDAO;
import pe.edu.pucp.gestion_eventos.model.Evento;
import pe.edu.pucp.gestion_eventos.mysql.EventoMySQL;




/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "EventoWS")
public class EventoWS {

    private EventoDAO evento;
    public EventoWS(){
        evento=new EventoMySQL();
    }

    @WebMethod(operationName = "listarEvento_por_nombre_categoria")
    public ArrayList<Evento> listarEvento_por_nombre_categoria(@WebParam(name = "nombre")String nombreCategoria) {
        ArrayList<Evento> lista= new ArrayList<>();
        try {
            lista=evento.listar(nombreCategoria);

        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    
     @WebMethod(operationName = "listarEvento_por_fecha")
    public ArrayList<Evento> listarEvento_por_fecha(@WebParam(name = "fecha")Date fecha) {
        ArrayList<Evento> lista= new ArrayList<>();
        try {
            lista=evento.listar_x_fecha(fecha);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    
    @WebMethod(operationName = "insertarEvento")
    public int insertarEvento(@WebParam(name = "evento")Evento evento){
        int resultado=0;
        try {
            resultado=this.evento.insertar(evento);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarEvento")
    public int modificarEvento(@WebParam(name = "evento")Evento evento){
        int resultado=0;
        try {
            resultado=this.evento.modificar(evento);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarEvento")
    public int eliminarEvento(@WebParam(name = "evento")Evento evento){
        int resultado=0;
        try {
            resultado=this.evento.eliminar(evento.getId_evento());
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
}
