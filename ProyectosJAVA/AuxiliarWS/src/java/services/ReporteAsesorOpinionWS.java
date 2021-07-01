/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package services;

import config.DBManager;
import java.sql.Connection;
import java.util.HashMap;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import servlets.ReporteOpinionesTutor;

/**
 *
 * @author PC
 */
@WebService(serviceName = "ReporteAsesorOpinionWS")
public class ReporteAsesorOpinionWS {

    /**
     * This is a sample web service operation
     */
   
    
    @WebMethod(operationName = "generarReporteAsesor")
    public byte[] generarReporteAsesor(int idAsesor){
        byte[]arreglo = null;
        try{
            //Referencia al reporte
            JasperReport reporte  = 
                    (JasperReport)JRLoader.loadObject(ReporteOpinionesTutor.class.getResource(
                            "/reportes/ReporteTutoresOpinion.jasper"));
            String rutaSubreporte1 = ReporteOpinionesTutor.class.getResource("/reportes/SubDatosAsesor.jasper").getPath();
            
            //Arreglo de parametros
            HashMap hm = new HashMap();
//            hm.put("IdAsesor", idAsesor);//cambiar el 7
            hm.put("IdAsesor", idAsesor);//cambiamos el 7 por id Asesor
            hm.put("Ruta_subreporte", rutaSubreporte1);
            //Objeto de Conexion
            Connection con = DBManager.getInstance().getConnection();        
            //poblamos el reporte
            JasperPrint jp = JasperFillManager.fillReport(reporte, hm, con);
            //Cerramos la conexion
            con.close();          
            //Cargamos el documento
            arreglo = JasperExportManager.exportReportToPdf(jp); 
        }catch(Exception ex){
            System.out.println(ex.getMessage());//el error aparece en el glassfish
        }
        return arreglo;
    }
}
