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
import pe.edu.pucp.ooia.gest_humana.mysql.PonenteMySQL;
import pe.edu.pucp.ooia.gest_humana.model.Ponente;
import pe.edu.pucp.ooia.gest_humana.dao.PonenteDao;

/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "PonenteWS")
public class PonenteWS {

    /**
     * This is a sample web service operation
     */
    private PonenteDao ponente;

    public PonenteWS() {
        ponente=new PonenteMySQL();
    }
    
    @WebMethod(operationName = "listarPonente")
    public ArrayList<Ponente> listarPonente(){
        ArrayList<Ponente> lista=new ArrayList<>();
        try {
            lista=ponente.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "insertarPonente")
    public int insertarPonente(@WebParam(name = "invitado")Ponente ponente){
        int resultado=0;
        try {
            resultado=this.ponente.insertar(ponente);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    @WebMethod(operationName = "modificarPonente")
    public int modificarPonente(@WebParam(name = "invitado")Ponente ponente){
        int resultado=0;
        try {
            resultado=this.ponente.modificar(ponente);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    @WebMethod(operationName = "eliminarPonente")
    public int eliminarPonente(@WebParam(name = "id_ponente")int id_ponente){
        int resultado=0;
        try {
            resultado=this.ponente.eliminar(id_ponente);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }

    
}
