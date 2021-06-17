/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pruebaCargaDatosCSV;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.util.Scanner;

/**
 *
 * @author PC
 */

public class CargadeCSV {
    public static void main(String[] args) throws Exception{
        /*Alumnos, ya funciona*/
//        FileInputStream file = new FileInputStream("C:\\7mo ciclo\\LP2\\Proyecto Lp2\\Lab 7\\Archivos de carga\\Alumnos.csv");
//        AlumnosCSV alumnosCsv = new AlumnosCSV();
//        
//        alumnosCsv.setRutaCSV(file);
//        int filasNoInsertadas = alumnosCsv.cargarDatos();
//        if(filasNoInsertadas == 0){
//            System.out.println("Toda la carga fue exitosa");
//        }else{
//            System.out.println("Hubieron " + filasNoInsertadas + " filas que no se pudieron insertar");
//        }
        /*Profesores, ya funciona*/
//        FileInputStream file = new FileInputStream("C:\\7mo ciclo\\LP2\\Proyecto Lp2\\Lab 7\\Archivos de carga\\Profesores.csv");
//        ProfesoresCSV profesores = new ProfesoresCSV();
//        
//        profesores.setRutaCSV(file);
//        int filasNoInsertadas = profesores.cargarDatos();
//        if(filasNoInsertadas == 0){
//            System.out.println("Toda la carga fue exitosa");
//        }else{
//            System.out.println("Hubieron " + filasNoInsertadas + " filas que no se pudieron insertar");
//        }
        /*Psicologos, ya funciona*/
        FileInputStream file = new FileInputStream("C:\\7mo ciclo\\LP2\\Proyecto Lp2\\Lab 7\\Archivos de carga\\Psicologos.csv");
        PsicologosCSV psicologos = new PsicologosCSV();
        
        psicologos.setRutaCSV(file);
        int filasNoInsertadas = psicologos.cargarDatos();
        if(filasNoInsertadas == 0){
            System.out.println("Toda la carga fue exitosa");
        }else{
            System.out.println("Hubieron " + filasNoInsertadas + " filas que no se pudieron insertar");
        }
    }
    
    
}
