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
import pe.edu.pucp.ooia.gest_academica.dao.CursoDAO;
import pe.edu.pucp.ooia.gest_academica.model.Curso;
import pe.edu.pucp.ooia.gest_academica.mysql.CursoMySQL;

/**
 *
 * @author DAYANA
 */
@WebService(serviceName = "CursoWS")
public class CursoWS {
    private CursoDAO curso;    

    public CursoWS() {
        curso=new CursoMySQL();
    }
    
    @WebMethod(operationName = "listarCurso")
    public ArrayList<Curso> listarCurso(){
        ArrayList<Curso>listarCurso=new ArrayList<>();
        try {
            listarCurso= this.curso.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return listarCurso;
    }
    @WebMethod(operationName = "insertarrCurso")
    public int insertarrCurso(@WebParam(name = "curso")Curso curso){
        int resultado=0;
        try {
            resultado=this.curso.insertar(curso);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarCurso")
    public int modificarCurso(@WebParam(name = "curso")Curso curso){
        int resultado=0;
        try {
            resultado=this.curso.modificar(curso);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarCurso")
    public int eliminarCurso(@WebParam(name = "id_curso")int id_curso){
        int resultado=0;
        try {
            resultado=this.curso.eliminar(id_curso);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
}
