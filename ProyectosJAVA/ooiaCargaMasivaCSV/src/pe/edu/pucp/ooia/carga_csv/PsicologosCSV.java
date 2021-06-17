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
import pe.edu.pucp.ooia.gest_humana.dao.PsicologoDAO;
import pe.edu.pucp.ooia.gest_humana.model.Psicologo;
import pe.edu.pucp.ooia.gest_humana.mysql.PsicologoMySQL;

/**
 *
 * @author PC
 */
public class PsicologosCSV {
    private Scanner sc;
    private PsicologoDAO daoPsicologo;
    
    public void setRutaCSV(FileInputStream archivo) throws FileNotFoundException{
        sc = new Scanner(archivo);
        daoPsicologo = new PsicologoMySQL();
    }

    
    public int cargarDatos() throws ParseException{
        sc.useDelimiter("\n");
        int cargaCorrecta = 0;
        while(sc.hasNext()){
            Psicologo psicologo = new Psicologo();
            String[] datos = sc.next().split(",");
            String []datosCorrectos = new String[11];
            datosCorrectos[0] = datos[0];
            for(int i = 1; i < 8; i++){
                if(i!=3)
                datosCorrectos[i] = datos[i].replaceAll(" ", "");
            }
            datosCorrectos[3] = datos[3];
            datosCorrectos[8] = datos[8];
            psicologo.setNombre(datosCorrectos[0]);
            psicologo.setDni(datosCorrectos[1]);
            Date date_birth = new SimpleDateFormat("yyyy-MM-dd").parse(datosCorrectos[2]); 
            psicologo.setFecha_nacimiento(date_birth);
            psicologo.setDireccion(datosCorrectos[3]);
            psicologo.setCorreo(datosCorrectos[4]);
            psicologo.setUsuario(datosCorrectos[5]);
            psicologo.setPassword(datosCorrectos[6]);
            
            Date date1=new SimpleDateFormat("yyyy-MM-dd").parse(datosCorrectos[7]); 
            psicologo.setFecha_inclusion(date1);
            psicologo.setRama(datosCorrectos[8]);
            int resultado = daoPsicologo.insertar(psicologo);
            if(resultado == 0){
                cargaCorrecta++;
            }
        }
        return cargaCorrecta;
    }
}
