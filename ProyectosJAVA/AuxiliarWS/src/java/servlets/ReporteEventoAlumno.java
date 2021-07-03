package servlets;

import config.DBManager;
import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.util.HashMap;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;

/**
 *
 * @author Gerardo
 */
public class ReporteEventoAlumno extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        try{
            JasperReport reporte = (JasperReport) 
                    JRLoader.loadObject(ReporteEventoAlumno.class.getResource(
                            "/reportes/ReporteEvento.jasper"));
            //
            Connection con = DBManager.getInstance().getConnection();
            
            String rutaSubreporte = ReporteEventoAlumno.class.getResource("/reportes/SubReporteEvento.jasper").getPath();
            rutaSubreporte = rutaSubreporte.replaceAll("%20", " ");
            
            String rutaValoracionPonentes = ReporteEventoAlumno.class.getResource("/reportes/ValoracionPonentes.jasper").getPath();
            rutaValoracionPonentes = rutaValoracionPonentes.replaceAll("%20", " ");
            
            String rutaValoracionEvento = ReporteEventoAlumno.class.getResource("/reportes/ValoracionEvento.jasper").getPath();
            rutaValoracionEvento = rutaValoracionEvento.replaceAll("%20", " ");
            
            String rutaValoracionUtilidad = ReporteEventoAlumno.class.getResource("/reportes/ValoracionUtilidad.jasper").getPath();
            rutaValoracionUtilidad = rutaValoracionUtilidad.replaceAll("%20", " ");
            
           
            HashMap hm = new HashMap();
            hm.put("IdEvento", 1);
            hm.put("RutaSubreporte", rutaSubreporte);
            hm.put("RutaValoracionPonentes", rutaValoracionPonentes);
            hm.put("RutaValoracionEvento", rutaValoracionEvento);
            hm.put("RutaValoracionUtilidad", rutaValoracionUtilidad);
            JasperPrint jp = JasperFillManager.fillReport(reporte, hm, con);
            con.close();
            
            //Mostramos el reporte 
            JasperExportManager.exportReportToPdfStream(jp, response.getOutputStream());
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
