/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servicios;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.text.ParseException;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.ooia.carga_csv.PsicologosCSV;

/**
 *
 * @author PC
 */
@WebService(serviceName = "PsicologosCSVcargaWS")
public class PsicologosCSVcargaWS {

    /**
     * This is a sample web service operation
     */
    private PsicologosCSV csvPsicologos;
    @WebMethod(operationName = "CargarCSVpsicologos")
    public int cargarCSVProfesores(@WebParam(name = "RutaArchivo") byte[] ruta) throws FileNotFoundException, ParseException, IOException {
        int resultado = 0;
        csvPsicologos = new PsicologosCSV();
        FileOutputStream outputStream = new FileOutputStream("Auxiliar");
        outputStream.write(ruta);
        outputStream.close();
        FileInputStream inputStream = new FileInputStream("Auxiliar");
        csvPsicologos.setRutaCSV(inputStream);
        resultado = csvPsicologos.cargarDatos();
        inputStream.close();
        return resultado;
    }
    
}
