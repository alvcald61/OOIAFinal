/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package services;

import config.DBManager;
import java.awt.Image;
import java.sql.Connection;
import java.util.HashMap;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.swing.ImageIcon;
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
             //Referencias a los subreportes 
            String rutaSubreporte1 = ReporteOpinionesTutor.class.getResource("/reportes/SubDatosAsesor.jasper").getPath();
            rutaSubreporte1 = rutaSubreporte1.replaceAll("%20", " ");     
            String rutaSubreporteGrafico = ReporteOpinionesTutor.class.getResource("/reportes/ReporteGrafico.jasper").getPath();
            rutaSubreporteGrafico = rutaSubreporteGrafico.replaceAll("%20", " ");         
            //Referencia a la imagen
            String rutaImagen = ReporteOpinionesTutor.class.getResource("/imagenes/cabeceraPUCP.jpg").getPath();
            rutaImagen = rutaImagen.replaceAll("%20", " ");
            Image cabecera = (new ImageIcon(rutaImagen)).getImage();       
            //Arreglo de parametros que ingresan al reporte
            HashMap hm = new HashMap();
            hm.put("IdAsesor", idAsesor);//cambiamos el 7 por id Asesor
            hm.put("Ruta_subreporte", rutaSubreporte1);
            hm.put("Ruta_grafico", rutaSubreporteGrafico);
            hm.put("Imagen", cabecera);
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
