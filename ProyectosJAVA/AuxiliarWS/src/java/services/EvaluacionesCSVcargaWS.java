/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package services;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.text.ParseException;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.ooia.carga_csv.EvaluacionesParcialesCSV;

/**
 *
 * @author PC
 */
@WebService(serviceName = "EvaluacionesCSVcargaWS")
public class EvaluacionesCSVcargaWS {

    private EvaluacionesParcialesCSV csvEvaluaciones;
    
    @WebMethod(operationName = "CargarCSVevaluaciones")
    public int cargarCSVevaluaciones(@WebParam(name = "RutaArchivo") byte[] ruta) throws FileNotFoundException, ParseException, IOException {
        int resultado = 0;
        csvEvaluaciones = new EvaluacionesParcialesCSV();
        FileOutputStream outputStream = new FileOutputStream("Auxiliar");
        outputStream.write(ruta);
        outputStream.close();
        FileInputStream inputStream = new FileInputStream("Auxiliar");
        csvEvaluaciones.setRutaCSV(inputStream);
        resultado = csvEvaluaciones.cargarDatos();
        inputStream.close();
        return resultado;
    }
    
}
