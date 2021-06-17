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
import pe.edu.pucp.ooia.gest_humana.dao.PsicologoDAO;
import pe.edu.pucp.ooia.gest_humana.mysql.PsicologoMySQL;
import pe.edu.pucp.ooia.gest_humana.model.Psicologo;

/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "PsicologoWS")
public class PsicologoWS {

    /**
     * This is a sample web service operation
     */
   private PsicologoDAO psicologo;

    public PsicologoWS() {
        psicologo=new PsicologoMySQL();
    }
   @WebMethod(operationName = "listarPsicologo")
    public ArrayList<Psicologo> listarPsicologo(){
        ArrayList<Psicologo> lista=new ArrayList<>();
        try {
            lista=psicologo.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "insertarPsicologo")
    public int insertarPsicologo(@WebParam(name = "invitado")Psicologo psicologo){
        int resultado=0;
        try {
            resultado=this.psicologo.insertar(psicologo);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    @WebMethod(operationName = "modificarPsicologo")
    public int modificarPsicologo(@WebParam(name = "invitado")Psicologo psicologo){
        int resultado=0;
        try {
            resultado=this.psicologo.modificar(psicologo);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    @WebMethod(operationName = "eliminarPsicologo")
    public int eliminarPsicologo(@WebParam(name = "id_psicologo")int id_psicologo){
        int resultado=0;
        try {
            resultado=this.psicologo.eliminar(id_psicologo);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    
}
