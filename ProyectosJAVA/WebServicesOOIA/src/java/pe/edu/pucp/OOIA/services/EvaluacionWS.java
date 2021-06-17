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
import pe.edu.pucp.ooia.gest_academica.dao.EvaluacionDAO;
import pe.edu.pucp.ooia.gest_academica.model.Evaluacion;
import pe.edu.pucp.ooia.gest_academica.mysql.EvaluacionMySQL;

/**
 *
 * @author DAYANA
 */
@WebService(serviceName = "EvaluacionWS")
public class EvaluacionWS {
    private EvaluacionDAO evaluacion;    

    public EvaluacionWS() {
        evaluacion=new EvaluacionMySQL();
    }
    
    @WebMethod(operationName = "listarEvaluacion")
    public ArrayList<Evaluacion> listarEvaluacion(@WebParam(name = "id_curso_llevado")int id_curso_llevado){
        ArrayList<Evaluacion> evaluaciones=new ArrayList<>();
        try {
            evaluaciones= this.evaluacion.listar(id_curso_llevado);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return evaluaciones;
    }
    @WebMethod(operationName = "insertarEvaluacion")
    public int insertarEvaluacion(@WebParam(name = "evaluacion")Evaluacion evaluacion){
        int resultado=0;
        try {
            resultado=this.evaluacion.insertar(evaluacion);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarEvaluacion")
    public int modificarEvaluacion(@WebParam(name = "evaluacion")Evaluacion evaluacion){
        int resultado=0;
        try {
            resultado=this.evaluacion.modificar(evaluacion);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
}
