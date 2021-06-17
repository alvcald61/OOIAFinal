/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.ooia.carga_csv;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.text.ParseException;
import java.util.Scanner;
import pe.edu.pucp.ooia.gest_academica.dao.CursoLlevadoDAO;
import pe.edu.pucp.ooia.gest_academica.model.Curso;
import pe.edu.pucp.ooia.gest_academica.model.CursoLlevado;
import pe.edu.pucp.ooia.gest_academica.mysql.CursoLlevadoMySQL;
import pe.edu.pucp.ooia.gest_humana.model.Alumno;

/**
 *
 * @author PC
 */
public class CursosLlevadosCSV {
    
    private Scanner sc;
    private CursoLlevadoDAO daoCursoLlevado;
    
    public CursosLlevadosCSV(){
        daoCursoLlevado = new CursoLlevadoMySQL();
    }
    public void asignarRutaCSV(FileInputStream archivo) throws FileNotFoundException{
        sc = new Scanner(archivo);
        daoCursoLlevado = new CursoLlevadoMySQL();
    }
    
    public int cargarDatos()throws ParseException{
        sc.useDelimiter("\n");
        
        int cargaCorrecta = 0;
        while(sc.hasNext()){
            CursoLlevado cursoLlevado = new CursoLlevado();
            String[] datos = sc.next().split(",");
            String []datosCorrectos = new String[7];
            for(int i = 0; i < 6 ; i++){
                datosCorrectos[i] = datos[i].replaceAll(" ", "");
            }
            datosCorrectos[6] = datos[6];
            Alumno alumno = new Alumno();
            alumno.setId_alumno(Integer.parseInt(datosCorrectos[0]));
            cursoLlevado.setAlumno(alumno);
            
            Curso curso = new Curso();
            curso.setId_curso(Integer.parseInt(datosCorrectos[1]));
            cursoLlevado.setCurso(curso);
            
            cursoLlevado.setCiclo(datosCorrectos[2]);
            cursoLlevado.setVez(Integer.parseInt(datosCorrectos[3]));
            cursoLlevado.setNotaFinal(Double.parseDouble(datosCorrectos[4]));
            cursoLlevado.setRetirado(Boolean.parseBoolean(datosCorrectos[5]));
            cursoLlevado.setFormulaCalificacion(datosCorrectos[6]);
            
            int resultado = daoCursoLlevado.insertar(cursoLlevado);
            if(resultado == 0){
                cargaCorrecta++;
            }
        }
        return cargaCorrecta;
    }
}
