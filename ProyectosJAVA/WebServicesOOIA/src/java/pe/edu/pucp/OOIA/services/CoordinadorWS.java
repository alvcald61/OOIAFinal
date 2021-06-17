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
import pe.edu.pucp.ooia.gest_humana.model.Coordinador;
import pe.edu.pucp.ooia.gest_humana.mysql.CoordinadorMySQL;
import pe.edu.pucp.ooia.gest_humana.dao.CoordinadorDAO;

/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "CoordinadorWS")
public class CoordinadorWS {

    /**
     * This is a sample web service operation
     */
    private CoordinadorDAO coordinador;
    
    public CoordinadorWS(){
        coordinador=new CoordinadorMySQL();
    }

    @WebMethod(operationName = "listarCoordinador")
    public ArrayList<Coordinador> listarCoordinadorEvento() {
        ArrayList<Coordinador> lista= new ArrayList<>();
        try {
            lista=coordinador.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "insertarCoordinador")
    public int insertarCoordinadorEvento(@WebParam(name = "coordinador")Coordinador coordinador){
        int resultado=0;
        try {
            resultado=this.coordinador.insertar(coordinador);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarCoordinador")
    public int modificarCoordinadorEvento(@WebParam(name = "coordinador")Coordinador coordinador){
        int resultado=0;
        try {
            resultado=this.coordinador.modificar(coordinador);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarCoordinador")
    public int eliminarCoordinadorEvento(@WebParam(name = "id_coordinador")int id_coordinador){
        int resultado=0;
        try {
            resultado=this.coordinador.eliminar(id_coordinador);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
}
