/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.ooia.carga_csv;


import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Scanner;
import pe.edu.pucp.ooia.gest_humana.dao.AlumnoDAO;
import pe.edu.pucp.ooia.gest_humana.model.Alumno;
import pe.edu.pucp.ooia.gest_humana.model.Especialidad;
import pe.edu.pucp.ooia.gest_humana.mysql.AlumnoMySQL;

/**
 *
 * @author PC
 */
public class AlumnosCSV {
    
    private Scanner sc;
    private AlumnoDAO daoAlumno;
    
    public void setRutaCSV(FileInputStream archivo) throws FileNotFoundException{
        sc = new Scanner(archivo);
        daoAlumno = new AlumnoMySQL();
    }
    public int cargarDatos() throws ParseException{
        sc.useDelimiter("\n");
        
        int cargaCorrecta = 0;//indica el numero de filas malas
        while(sc.hasNext()){
            Alumno alumno = new Alumno();
            String[] datos = sc.next().split(",");
            String []datosCorrectos = new String[16];
            datosCorrectos[0] = datos[0];
            for(int i = 1; i < 12 ; i++){
                if(i !=3)
                    datosCorrectos[i] = datos[i].replaceAll(" ", "");
            }
            datosCorrectos[3] = datos[3];
            alumno.setNombre(datosCorrectos[0]);
            alumno.setDni(datosCorrectos[1]);
            Date date_birth = new SimpleDateFormat("yyyy-MM-dd").parse(datosCorrectos[2]); 
            alumno.setFecha_nacimiento(date_birth);
            alumno.setDireccion(datosCorrectos[3]);
            alumno.setCorreo(datosCorrectos[4]);
            alumno.setUsuario(datosCorrectos[5]);
            alumno.setPassword(datosCorrectos[6]);
            Date date_inclusion = new SimpleDateFormat("yyyy-MM-dd").parse(datosCorrectos[7]); 
            alumno.setFecha_inclusion(date_inclusion);
            alumno.setCodigo(datosCorrectos[8]);
            Especialidad especialidad = new Especialidad();
            especialidad.setId_especialidad(Integer.parseInt(datosCorrectos[9]));
            alumno.setEspecialidad(especialidad);
            alumno.setCraest(Double.parseDouble(datosCorrectos[10]));
            alumno.setCreditos_aprobados(Double.parseDouble(datosCorrectos[11]));
            
            int resultado = daoAlumno.insertar(alumno);
            if(resultado == 0){
                cargaCorrecta++;
            }
        }
        return cargaCorrecta;
    }
}
