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
import pe.edu.pucp.ooia.gest_atencion.dao.HorarioDAO;
import pe.edu.pucp.ooia.gest_atencion.mysql.HorarioMySQL;
import pe.edu.pucp.ooia.gest_atencion.model.Horario;

/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "HorarioWS")
public class HorarioWS {
    private HorarioDAO horario;

    public HorarioWS() {
        horario=new HorarioMySQL();
    }
    
    /**
     * This is a sample web service operation
     */
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
    
}
