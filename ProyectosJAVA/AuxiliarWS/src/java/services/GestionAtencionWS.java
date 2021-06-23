/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.ooia.gest_atencion.dao.CitaDAO;
import pe.edu.pucp.ooia.gest_atencion.dao.CodigoAtencionDAO;
import pe.edu.pucp.ooia.gest_atencion.dao.EncuestaDAO;
import pe.edu.pucp.ooia.gest_atencion.dao.HorarioDAO;
import pe.edu.pucp.ooia.gest_atencion.model.Cita;
import pe.edu.pucp.ooia.gest_atencion.model.CodigoAtencion;
import pe.edu.pucp.ooia.gest_atencion.model.Encuesta;
import pe.edu.pucp.ooia.gest_atencion.model.Horario;
import pe.edu.pucp.ooia.gest_atencion.mysql.CitaMySQL;
import pe.edu.pucp.ooia.gest_atencion.mysql.CodigoAtencionMySQL;
import pe.edu.pucp.ooia.gest_atencion.mysql.EncuestaMySQL;
import pe.edu.pucp.ooia.gest_atencion.mysql.HorarioMySQL;


/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "GestionAtencionWS")
public class GestionAtencionWS {
    private HorarioDAO horario;
    private CitaDAO cita;
    private CodigoAtencionDAO daoCodigo;
        private EncuestaDAO daoEncuesta;
    
    
    
    
    
    public GestionAtencionWS() {
            cita=new CitaMySQL();
            daoCodigo=new CodigoAtencionMySQL();
            horario=new HorarioMySQL();
            daoEncuesta = new EncuestaMySQL();
    }
   @WebMethod(operationName = "listarCitaHistorico")
    public ArrayList<Cita> listarCitaHistorico(@WebParam(name = "id_alumno" )int id_alumno) {
        ArrayList<Cita>lista=new ArrayList<>();
        try {
            lista=cita.listarHistorico(id_alumno);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    
    @WebMethod(operationName = "listarCitaHistoricoXNombre")
    public ArrayList<Cita> listarCitaHistoricoXNombre(@WebParam(name = "id_alumno" )int id_alumno,
            @WebParam(name = "nombre_profesor" )String nombre) {
        ArrayList<Cita>lista=new ArrayList<>();
        try {
            lista=cita.listarHistoricoXNombre(id_alumno,nombre);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    
    @WebMethod(operationName = "listarCitaPendiente")
    public ArrayList<Cita> listarCitaPendiente(@WebParam(name = "id_alumno" )int id_alumno) {
        ArrayList<Cita>lista=new ArrayList<>();
        try {
            lista=cita.listarPendiente(id_alumno);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    
    @WebMethod(operationName = "insertarCita")
   public int insertarCita(@WebParam(name = "cita")Cita cita){
       int resultado=0;
        try {
            resultado=this.cita.insertar(cita);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
   }
    @WebMethod(operationName = "modificarCita")
   public int modificarCita(@WebParam(name = "cita")Cita cita){
       int resultado=0;
        try {
            resultado=this.cita.modificar(cita);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
   }
    @WebMethod(operationName = "eliminarCita")
   public int eliminarCita(@WebParam(name = "cita")Cita cita){
       int resultado=0;
        try {
            resultado=this.cita.eliminar(cita.getId_cita());
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
   }
    
   @WebMethod(operationName = "listarCodigo")
    public ArrayList<CodigoAtencion> listarCodigo() {
        ArrayList<CodigoAtencion>lista=new ArrayList<>();
        try {
            lista=daoCodigo.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "insertarCodigo")
    public int insertarCodigo(@WebParam(name = "codigo") CodigoAtencion codigo){
        int resultado=0;
        try {
            resultado=this.daoCodigo.insertar(codigo);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
                return resultado;
    }
    @WebMethod(operationName = "modificarCodigo")
    public int modificarCodigo(@WebParam(name = "codigo") CodigoAtencion codigo){
        int resultado=0;
        try {
            resultado=this.daoCodigo.modificar(codigo);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
                return resultado;
    } 
  
    
    @WebMethod(operationName = "listarHorario")
    public ArrayList<Horario> listarHorario(){
        ArrayList<Horario >lista=new ArrayList<>();
        try {
            lista=this.horario.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "insertarHorario")
    public int insertarHorario(@WebParam(name = "horario")Horario horario){
        int resultado=0;
        
        try {
            resultado=this.horario.insertar(horario);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    @WebMethod(operationName = "modificarHorario")
    public int modificarHorario(@WebParam(name = "horario")Horario horario){
        int resultado=0;
        
        try {
            resultado=this.horario.modificar(horario);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    @WebMethod(operationName = "eliminarHorario")
    public int eliminarHorario(@WebParam(name = "horario")Horario horario){
        int resultado=0;
        
        try {
            resultado=this.horario.eliminar(horario.getId_horario());
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    
    
    
    @WebMethod(operationName = "listarEncuestaxAsesor")
    public ArrayList<Encuesta> listarEncuestaxAsesor(@WebParam(name = "idAsesor") int idAsesor){
        ArrayList<Encuesta> encuestas = new ArrayList<>();
        try{
            encuestas = daoEncuesta.listarXAsesor(idAsesor);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return encuestas;
    }
    
    @WebMethod(operationName = "insertarEncuesta")
    public int insertarEncuesta(@WebParam(name = "encuesta") Encuesta encuesta){
        int resultado = 0;
        try{
            resultado = daoEncuesta.insertar(encuesta);//insertamos la encuesta
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    
    
    
    
}
