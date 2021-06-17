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
import pe.edu.pucp.ooia.gest_humana.dao.EspecialidadDAO;
import pe.edu.pucp.ooia.gest_humana.mysql.EspecialidadMySQL;
import pe.edu.pucp.ooia.gest_humana.model.Especialidad;

/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "EspecialidadWS")
public class EspecialidadWS {

    /**
     * This is a sample web service operation
     */
    private EspecialidadDAO especialidad;    

    public EspecialidadWS() {
        especialidad=new EspecialidadMySQL();
    }
    
    @WebMethod(operationName = "listarEspecialidad")
    public ArrayList<Especialidad> listarEspecialidad(){
        ArrayList<Especialidad>listaEspecialidad=new ArrayList<>();
        try {
            listaEspecialidad= this.especialidad.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return listaEspecialidad;
    }
    @WebMethod(operationName = "insertarEspecialidad")
    public int insertarEspecialidad(@WebParam(name = "especialidad")Especialidad especialidad){
        int resultado=0;
        try {
            resultado=this.especialidad.insertar(especialidad);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarEspecialidad")
    public int modificarEspecialidad(@WebParam(name = "especialidad")Especialidad especialidad){
        int resultado=0;
        try {
            resultado=this.especialidad.modificar(especialidad);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarEspecialidad")
    public int eliminarEspecialidad(@WebParam(name = "id_especialidad")int id_especialidad){
        int resultado=0;
        try {
            resultado=this.especialidad.eliminar(id_especialidad);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
}
