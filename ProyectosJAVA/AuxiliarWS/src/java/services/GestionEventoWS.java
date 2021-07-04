/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package services;

import java.sql.Date;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.gestion_eventos.dao.CategoriaEventoDAO;
import pe.edu.pucp.gestion_eventos.dao.EventoAlumnoDAO;
import pe.edu.pucp.gestion_eventos.dao.EventoDAO;
import pe.edu.pucp.gestion_eventos.model.CategoriaEvento;
import pe.edu.pucp.gestion_eventos.model.Evento;
import pe.edu.pucp.gestion_eventos.model.EventoAlumno;
import pe.edu.pucp.gestion_eventos.mysql.CategoriaEventoMySQL;
import pe.edu.pucp.gestion_eventos.mysql.EventoAlumnoMySQL;
import pe.edu.pucp.gestion_eventos.mysql.EventoMySQL;
import pe.edu.pucp.ooia.gest_humana.dao.AlumnoDAO;
import pe.edu.pucp.ooia.gest_humana.dao.AutenticarPersonaDAO;
import pe.edu.pucp.ooia.gest_humana.dao.CoordinadorDAO;
import pe.edu.pucp.ooia.gest_humana.model.Coordinador;
import pe.edu.pucp.ooia.gest_humana.model.Ponente;
import pe.edu.pucp.ooia.gest_humana.mysql.AlumnoMySQL;
import pe.edu.pucp.ooia.gest_humana.mysql.AutenticarPersonaMySQL;
import pe.edu.pucp.ooia.gest_humana.mysql.CoordinadorMySQL;


/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "GestionEventoWS")
public class GestionEventoWS {

    private EventoDAO eventoSQL=new EventoMySQL();
    private EventoAlumnoDAO eventoAl=new EventoAlumnoMySQL();
    private CoordinadorDAO coordinador=new CoordinadorMySQL();;
    private CategoriaEventoDAO categoria=new CategoriaEventoMySQL();
    public GestionEventoWS() {
    eventoSQL=new EventoMySQL();
    eventoAl=new EventoAlumnoMySQL();
    coordinador=new CoordinadorMySQL();
        
    }
    
    @WebMethod(operationName = "listarEvento_por_nombre_categoria")
    public ArrayList<Evento> listarEvento_por_nombre_categoria(@WebParam(name = "nombre")String nombreCategoria) {
        ArrayList<Evento> lista= new ArrayList<>();
        try {
            lista=eventoSQL.listar(nombreCategoria);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "listar_tres_eventos_proximos")
    public ArrayList<Evento> listar_tres_eventos_proximos() {
        ArrayList<Evento> lista= new ArrayList<>();
        try {
            lista=eventoSQL.listar_tres_eventos_proximos();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    
     @WebMethod(operationName = "listarEvento_por_fecha")
    public ArrayList<Evento> listarEvento_por_fecha(@WebParam(name = "fecha")Date fecha) {
        ArrayList<Evento> lista= new ArrayList<>();
        try {
            lista=eventoSQL.listar_x_fecha(fecha);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "insertarEvento")
    public int insertarEvento(@WebParam(name = "evento")Evento evento){
        int resultado=0;
        try {
          
            resultado=this.eventoSQL.insertar(evento);
        } catch (Exception e) {
            System.out.println(e.getMessage());
           
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarEvento")
    public int modificarEvento(@WebParam(name = "evento")Evento evento){
        int resultado=0;
        try {
            resultado=this.eventoSQL.modificar(evento);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarEvento")
    public int eliminarEvento(@WebParam(name = "evento")Evento evento){
        int resultado=0;
        try {
            resultado=this.eventoSQL.eliminar(evento.getId_evento());
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "reducir_cupo")
    public int reducirCupo(@WebParam(name = "evento")Evento evento){
        int resultado=0;
        try {
            resultado=this.eventoSQL.reducir_cupo(evento.getId_evento());
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarEncuestaEvento")
    public ArrayList<EventoAlumno> listarEncuestaEvento() {
        ArrayList<EventoAlumno> lista= new ArrayList<>();
        try {
            lista=eventoAl.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "insertarEncuestaEvento")
    public int insertarEncuestaEvento(@WebParam(name = "eventoAl")EventoAlumno eventoAl){
        int resultado=0;
        try {
            resultado=this.eventoAl.insertar(eventoAl);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarEncuestaEvento")
    public int modificarEncuestaEvento(@WebParam(name = "eventoAl")EventoAlumno eventoAl){
        int resultado=0;
        try {
            resultado=this.eventoAl.modificar(eventoAl);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarEncuestaEvento")
    public int eliminarEncuestaEvento(@WebParam(name = "eventoAl")EventoAlumno eventoAl){
        int resultado=0;
        try {
            resultado=this.eventoAl.eliminar(eventoAl.getId_encuesta());
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarCoordinadorEvento")
    public ArrayList<Coordinador> listarCoordinador(@WebParam(name = "nombre")String nombre) {
        ArrayList<Coordinador> lista= new ArrayList<>();
        try {
            lista=coordinador.listar(nombre);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "insertarCoordinadorEvento")
    public int insertarCoordinadorEvento(@WebParam(name = "coordinador")Coordinador coordinador){
        int resultado=0;
        try {
            resultado=this.coordinador.insertar(coordinador);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarCoordinadorEvento")
    public int modificarCoordinadorEvento(@WebParam(name = "coordinador")Coordinador coordinador){
        int resultado=0;
        try {
            resultado=this.coordinador.modificar(coordinador);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarCoordinadorEvento")
    public int eliminarCoordinadorEvento(@WebParam(name = "coordinador")Coordinador coordinador){
        int resultado=0;
        try {
            resultado=this.coordinador.eliminar(coordinador.getId_coordinador());
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
     
    @WebMethod(operationName = "listarCategoriaEvento")
    public ArrayList<CategoriaEvento> listarCategoriaEvento(){
        ArrayList<CategoriaEvento>lista=new ArrayList<>();
        try {
            lista=categoria.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        
        return lista;
    }
    @WebMethod(operationName = "insertarCategoriaEvento")
    public int insertarCategoriaEvento(@WebParam(name="categoria")CategoriaEvento categoria){
           int resultado=0;
        try {
            resultado=this.categoria.insertar(categoria);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarCategoriaEvento")
    public int modificarCategoriaEvento(@WebParam(name="categoria")CategoriaEvento categoria){
           int resultado=0;
        try {
            resultado=this.categoria.modificar(categoria);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarCategoriaEvento")
    public int eliminarCategoriaEvento(@WebParam(name="categoria")CategoriaEvento categoria){
           int resultado=0;
        try {
            resultado=this.categoria.eliminar(categoria.getId_categoria());
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarPonenteXEvento")
    public ArrayList<Ponente> listarPonenteXEvento(@WebParam(name="id_evento")int id_evento) {
        ArrayList<Ponente> lista= new ArrayList<>();
        try {
            lista = eventoSQL.listarPonente(id_evento);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
        @WebMethod(operationName = "listar_eventos_inscritos")
    public ArrayList<Evento> listarEventosInscritos(@WebParam(name="id_alumno")int idAlumno){
        ArrayList<Evento> lista= new ArrayList<>();
        try {
            lista=eventoSQL.listar_eventos_inscritos(idAlumno);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    
    @WebMethod(operationName = "listar_eventos_pasados")
    public ArrayList<Evento> listarEventosPasados(@WebParam(name="id_alumno")int idAlumno){
        ArrayList<Evento> lista= new ArrayList<>();
        try {
            lista=eventoSQL.listar_eventos_pasados(idAlumno);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    private AlumnoDAO alumno;
        
    
        @WebMethod(operationName = "obtener_estado")
    public boolean obtener_estado(@WebParam(name = "id_evento")int evento,@WebParam(name = "id_alumno")int alumno){
        boolean retorno=false;
        this.alumno=new AlumnoMySQL();
        try{
            retorno=this.alumno.obtenerEstadoEventoAlumno(evento, alumno);

        }
        catch(Exception e){
            System.out.println(e.getMessage());
        }
        return retorno;
    }
    
    
    
}
