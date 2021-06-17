/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package main;

import java.io.File;
import pe.edu.pucp.gestion_tramites_academicos.model.PreguntaFrecuente;
import pe.edu.pucp.gestion_tramites_academicos.model.Requisito;
import pe.edu.pucp.gestion_tramites_academicos.model.TipoTramite;
import pe.edu.pucp.gestion_tramites_academicos.model.Tramite;
import pe.edu.pucp.gestion_tramites_academicos.mysql.PreguntaFrecuenteMySql;
import pe.edu.pucp.gestion_tramites_academicos.mysql.RequisitoMySql;
import pe.edu.pucp.gestion_tramites_academicos.mysql.TramiteMySql;

/**
 *
 * @author LENOVO
 */
public class Main {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Requisito req1=new Requisito("Craest minimo 10", 10, 0, 0, 0);
        Requisito req2=new Requisito("Creditos minimo 30", 0, 0, 0, 0);
        PreguntaFrecuente preg1=new PreguntaFrecuente(1, "¿Como me retiro?", "Ingresa a la pagina y ve");
        PreguntaFrecuente preg2=new PreguntaFrecuente(2, "¿Donde encuentro los documentos?", "En la pagina de la cato");
        File arch1=new File("Constancia.txt");
        req2.setCreditosMin(30);
        
        Tramite tram=new Tramite();
        tram.setDescripcion("Retiro de todos los cursos");
        tram.setTipoTramite(TipoTramite.MATRICULA);
        tram.agregarRequisito(req2);
        tram.agregarRequisito(req1);
        tram.agregarPreguntaFrecuente(preg2);
        tram.agregarPreguntaFrecuente(preg1);
        tram.agregaArchivo(arch1);
        RequisitoMySql aux=new RequisitoMySql();
        aux.insertar(req2);
        aux.insertar(req1);
        System.out.println(tram.getId_tramite());
        new TramiteMySql().insertar(tram);
        
        
       
    }
    
}
