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
import pe.edu.pucp.ooia.gest_atencion.dao.CitaDAO;
import pe.edu.pucp.ooia.gest_atencion.mysql.CitaMySQL;
import pe.edu.pucp.ooia.gest_atencion.model.Cita;

/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "CitaWS")
public class CitaWS {

    /**
     * This is a sample web service operation
     */
    private CitaDAO cita;
    public CitaWS(){
        cita=new CitaMySQL();
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
}
