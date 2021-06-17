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
import pe.edu.pucp.ooia.gest_atencion.dao.CodigoAtencionDAO;
import pe.edu.pucp.ooia.gest_atencion.mysql.CodigoAtencionMySQL;
import pe.edu.pucp.ooia.gest_atencion.model.CodigoAtencion;

/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "CodigoWS")
public class CodigoAtencionWS {

    /**
     * This is a sample web service operation
     */
    private CodigoAtencionDAO daoCodigo;
    public CodigoAtencionWS(){
        daoCodigo=new CodigoAtencionMySQL();
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

}
