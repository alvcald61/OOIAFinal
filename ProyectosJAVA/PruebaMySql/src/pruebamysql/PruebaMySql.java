/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pruebamysql;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.Date;
import java.util.GregorianCalendar;
import java.util.logging.Level;
import java.util.logging.Logger;
import pe.edu.pucp.gestion_eventos.model.Evento;
import pe.edu.pucp.gestion_eventos.mysql.EventoMySQL;
import pe.edu.pucp.ooia.gest_humana.model.Alumno;
import pe.edu.pucp.ooia.gest_humana.model.Persona;
import pe.edu.pucp.ooia.gest_humana.mysql.PonenteMySQL;


/**
 *
 * @author LENOVO
 */
public class PruebaMySql {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
    }
/*    
    private static void pruebaCursoLlevado(){
        CursoLlevado curso=new CursoLlevado();
        CursoLlevadoMySQL cursoMySQL=new CursoLlevadoMySQL();
        Alumno alumno=new Alumno();
        alumno.setId_alumno(1);
        curso.setAlumno(alumno);
        //solo se necesita el id hacereferencia a lp2
        curso.setCurso(new Curso(2, "", "", 1));
        curso.setCiclo("2020-0");
        curso.setFormulaDeCalificacion("4EX1 +  3 LAB + 3EX2 ");
        curso.setNotaFinal(15);
        curso.setRetirado(false);
        curso.setVez(1);
        //cursoMySQL.insertar(curso);
        Prueba prueba=new Prueba();
        prueba.impresion(cursoMySQL.listar(alumno.getId_alumno()));
    }
    
    private static void pruebaPsicologo(){
        Psicologo psicologo=new Psicologo();
        PsicologoMySQL psicologoMySQL=new PsicologoMySQL();
        Prueba prueba=new Prueba();
        psicologo.setNombre("Psicologo 1");
                psicologo.setDni("98765432");
                psicologo.setEdad(40);
                psicologo.setDireccion("En algun lugar de Lima");
                psicologo.setUsuario_pucp("25896314");
                psicologo.setFecha_inclusion(new Date());
               psicologo.setCorreo("Rony@pucp.edu.pe");
               psicologo.setId_psicologo(3);
               psicologo.setNombre("Psicologo 3");
                //psicologoMySQL.insertar(psicologo);
              // psicologoMySQL.modificar(psicologo);
                prueba.impresion(psicologoMySQL.listar());
                
               
    }
    
    private static void pruebaCategoria(){
        CategoriaMySQL categoriaMySQL=new CategoriaMySQL();
        Categoria categoria=new Categoria();
        Prueba prueba=new Prueba();
        categoria.setNombre_categoria("Bica");
        categoriaMySQL.insertar( categoria);
        System.out.println(categoria);
        prueba.impresion(categoriaMySQL.listar());
        //categoriaMySQL.modificar(new Categoria(1, "Demasiado alto rendimiento"));
    }
    private static void pruebaCurso(){
        Prueba prueba=new Prueba();
        Curso curso= new Curso("INF281", "Lenguajes de Programación 1", 1);
        CursoMySQL cursoMySQL=new CursoMySQL();
        cursoMySQL.insertar(curso);
        //cambiar Lenguaje de programacion 2 a ingeco
        cursoMySQL.modificar(new Curso(1,"IND135","Ingenieria Economica",1));
        
        prueba.impresion(cursoMySQL.listar());
        cursoMySQL.eliminar(1);
}
    private static void pruebaCodigoAtencion(){
        Prueba prueba = new Prueba();
        CodigoAtencion codigoAtencion=new CodigoAtencion();
        codigoAtencion.setCodigo("EX123");
        codigoAtencion.setDescripcion("Carta de permanencia");
        CodigoAtencionMySQL codigoAtencionMySQL=new CodigoAtencionMySQL();
        codigoAtencionMySQL.insertar(codigoAtencion);
        System.out.println(codigoAtencion);
        //codigoAtencionMySQL.modificar(new CodigoAtencion(1, "MMM999", "Codigo cambiado"));
        prueba.impresion(codigoAtencionMySQL.listar());
    }
    private static void pruebaProfesor() {
                Prueba prueba = new Prueba();
                Profesor profesor= new Profesor();
                ProfesorMySQL profesorMySQL=new ProfesorMySQL();
                profesor.setId_profesor(1);
                profesor.setNombre("Miguel Guanira");
                profesor.setDni("98765432");
                profesor.setEdad(40);
                profesor.setDireccion("En algun lugar de Lima");
                profesor.setUsuario_pucp("25896314");
                profesor.setFecha_inclusion(new Date());
               profesor.setCorreo("Rony@pucp.edu.pe");
                profesor.setEspecialidad(new Especialidad(3, ""));
                profesor.setFacultad("Ciencias e Ingenieria");
                profesor.setCategoria("Contratado");
                profesorMySQL.insertar(profesor);
         
                
                
                //profesorMySQL.modificar(profesor);
                //profesorMySQL.eliminar(profesor);
                prueba.impresion(profesorMySQL.listar());
    } 
    
    
    
    private static class Prueba<T>{
        public void impresion(ArrayList<T> imprime){
            for(T aux:imprime){
                System.out.println(aux);
            }
        }
        
    }
    
    */
}
