/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.ooia.carga_csv;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Scanner;
import pe.edu.pucp.ooia.gest_humana.dao.ProfesorDAO;
import pe.edu.pucp.ooia.gest_humana.model.Especialidad;
import pe.edu.pucp.ooia.gest_humana.model.Profesor;
import pe.edu.pucp.ooia.gest_humana.mysql.ProfesorMySQL;


/**
 *
 * @author PC
 */
public class ProfesoresCSV {
    private Scanner sc;
    private ProfesorDAO daoProfesor;
    
    public void setRutaCSV(FileInputStream archivo) throws FileNotFoundException{
        sc = new Scanner(archivo);
        daoProfesor = new ProfesorMySQL();
    }
    
    public int cargarDatos() throws ParseException{
        sc.useDelimiter("\n");
        int cargaCorrecta = 0;
        while(sc.hasNext()){
            Profesor profesor = new Profesor();
            String[] datos = sc.next().split(",");
            String []datosCorrectos = new String[11];
            datosCorrectos[0] = datos[0];
            for(int i = 1; i < 9; i++){
                if(i !=3)
                    datosCorrectos[i] = datos[i].replaceAll(" ", "");
            }
            datosCorrectos[3] = datos[3];
            profesor.setNombre(datosCorrectos[0]);
            profesor.setDni(datosCorrectos[1]);
            Date date_birth = new SimpleDateFormat("yyyy-MM-dd").parse(datosCorrectos[2]); 
            profesor.setFecha_nacimiento(date_birth);
            profesor.setDireccion(datosCorrectos[3]);
            profesor.setCorreo(datosCorrectos[4]);
            profesor.setUsuario(datosCorrectos[5]);
            profesor.setPassword(datosCorrectos[6]);
            Date date1=new SimpleDateFormat("yyyy-MM-dd").parse(datosCorrectos[7]); 
            profesor.setFecha_inclusion(date1);
            Especialidad especialidad = new Especialidad();
            especialidad.setId_especialidad(Integer.parseInt(datosCorrectos[8]));
            profesor.setEspecialidad(especialidad);
            datosCorrectos[9] = datos[9]; datosCorrectos[10] = datos[10];
            profesor.setFacultad(datosCorrectos[9]);
            profesor.setCategoria(datosCorrectos[10]);
           
            
            int resultado = daoProfesor.insertar(profesor);
            if(resultado == 0){
                cargaCorrecta++;
            }
        }
        return cargaCorrecta;
    }
}
