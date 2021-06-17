/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package services;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.text.ParseException;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.ooia.carga_csv.ProfesoresCSV;

/**
 *
 * @author PC
 */
@WebService(serviceName = "ProfesoresCSVcargaWS")
public class ProfesoresCSVcargaWS {

    /**
     * This is a sample web service operation
     */
    private ProfesoresCSV csvProfesores;
    @WebMethod(operationName = "CargarCSVprofesores")
    public int cargarCSVProfesores(@WebParam(name = "RutaArchivo") byte[] ruta) throws FileNotFoundException, ParseException, IOException {
        int resultado = 0;
        csvProfesores = new ProfesoresCSV();
        FileOutputStream outputStream = new FileOutputStream("Auxiliar");
        outputStream.write(ruta);
        outputStream.close();
        FileInputStream inputStream = new FileInputStream("Auxiliar");
        csvProfesores.setRutaCSV(inputStream);
        resultado = csvProfesores.cargarDatos();
        inputStream.close();
        return resultado;
    }
}
