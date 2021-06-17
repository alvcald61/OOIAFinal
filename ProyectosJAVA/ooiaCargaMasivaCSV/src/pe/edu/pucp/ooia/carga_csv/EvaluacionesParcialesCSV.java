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
import pe.edu.pucp.ooia.gest_academica.dao.EvaluacionDAO;
import pe.edu.pucp.ooia.gest_academica.model.CursoLlevado;
import pe.edu.pucp.ooia.gest_academica.model.Evaluacion;
import pe.edu.pucp.ooia.gest_academica.mysql.EvaluacionMySQL;

/**
 *
 * @author PC
 */
public class EvaluacionesParcialesCSV {
    private Scanner sc;
    private EvaluacionDAO daoEvaluacion;
    
    public void setRutaCSV(FileInputStream archivo) throws FileNotFoundException{
        sc = new Scanner(archivo);
        daoEvaluacion = new EvaluacionMySQL();
    }
    
    public int cargarDatos()throws ParseException{
        sc.useDelimiter("\n");
        
        int cargaCorrecta = 0;
        while(sc.hasNext()){
            Evaluacion evaluacion = new Evaluacion();
            String[] datosCorrectos = sc.next().split(",");
            //se que son solo 4 datos
            CursoLlevado cursoLlevado = new CursoLlevado();
            cursoLlevado.setId_curso_llevado(Integer.parseInt(datosCorrectos[0]));
            
            evaluacion.setCursoLlevado(cursoLlevado);
            evaluacion.setTipo(datosCorrectos[1]);
            evaluacion.setNombre(datosCorrectos[2]);
            datosCorrectos[3] = datosCorrectos[3].replaceAll("\r", "");
            evaluacion.setNota(Integer.parseInt(datosCorrectos[3]));
            
            int resultado = daoEvaluacion.insertar(evaluacion);
            if(resultado == 0){
                cargaCorrecta++;
            }
        }
        return cargaCorrecta;
    }
}
