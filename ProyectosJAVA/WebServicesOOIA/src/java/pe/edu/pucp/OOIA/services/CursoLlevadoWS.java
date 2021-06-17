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
import pe.edu.pucp.ooia.gest_academica.dao.CursoLlevadoDAO;
import pe.edu.pucp.ooia.gest_academica.model.CursoLlevado;
import pe.edu.pucp.ooia.gest_academica.mysql.CursoLlevadoMySQL;

/**
 *
 * @author DAYANA
 */
@WebService(serviceName = "CursoLlevadoWS")
public class CursoLlevadoWS {

    private CursoLlevadoDAO curso;    

    public CursoLlevadoWS() {
        curso=new CursoLlevadoMySQL();
    }
    
    @WebMethod(operationName = "listarCursoLlevado")
    public ArrayList<CursoLlevado> listarCursoLlevado(@WebParam(name = "id_alumno")int id_alumno){
        ArrayList<CursoLlevado> cursos=new ArrayList<>();
        try {
            cursos= this.curso.listar(id_alumno);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return cursos;
    }
    @WebMethod(operationName = "insertarCursoLlevado")
    public int insertarCursoLlevado(@WebParam(name = "curso")CursoLlevado curso){
        int resultado=0;
        try {
            resultado=this.curso.insertar(curso);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarCursoLlevado")
    public int modificarCursoLlevado(@WebParam(name = "curso")CursoLlevado curso){
        int resultado=0;
        try {
            resultado=this.curso.modificar(curso);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
}
