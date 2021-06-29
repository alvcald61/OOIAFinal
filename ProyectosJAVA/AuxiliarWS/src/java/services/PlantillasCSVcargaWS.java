/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package services;

import java.io.File;
import java.nio.file.Files;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author PC
 */
@WebService(serviceName = "PlantillasCSVcargaWS")
public class PlantillasCSVcargaWS {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "obtenerPlantillaCSV")
    public byte[] obtenerPlantillaCSV() {
        byte[] arreglo = null;
        try{
            File archivo = new File("/plantillas/Plantillas de carga masiva por archivos CSV.pdf");
            arreglo = Files.readAllBytes(archivo.toPath());
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return arreglo;
    }
}
