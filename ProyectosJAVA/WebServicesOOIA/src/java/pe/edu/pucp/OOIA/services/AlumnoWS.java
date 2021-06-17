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
import pe.edu.pucp.ooia.gest_humana.dao.AlumnoDAO;
import pe.edu.pucp.ooia.gest_humana.mysql.AlumnoMySQL;
import pe.edu.pucp.ooia.gest_humana.model.Alumno;

/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "AlumnoWS")
public class AlumnoWS {
    
    private AlumnoDAO alumno;

    public AlumnoWS() {
            alumno=new AlumnoMySQL();
    }
    
    
    @WebMethod(operationName = "listarAlumno")
    public ArrayList<Alumno> listarAlumno(){
        ArrayList<Alumno> lista= new ArrayList<>();
        try {
            lista=alumno.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
        
    }
    @WebMethod(operationName = "insertarAlumno")
    public int insertarAlumno(@WebParam(name = "alumno")Alumno alumno){
        int resultado=0;
        try {
            resultado=this.alumno.insertar(alumno);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarAlumno")
    public int modificarAlumno(@WebParam(name = "alumno")Alumno alumno){
        int resultado=0;
        try {
            resultado=this.alumno.modificar(alumno);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarAlumno")
    public int eliminarAlumno(@WebParam(name = "id_alumno")int id_alumno){
        int resultado=0;
        try {
            resultado=this.alumno.eliminar(id_alumno);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
}
