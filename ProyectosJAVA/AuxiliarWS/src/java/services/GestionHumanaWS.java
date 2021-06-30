/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.ooia.gest_humana.dao.AlumnoDAO;
import pe.edu.pucp.ooia.gest_humana.dao.AutenticarPersonaDAO;
import pe.edu.pucp.ooia.gest_humana.dao.CoordinadorDAO;
import pe.edu.pucp.ooia.gest_humana.dao.EspecialidadDAO;
import pe.edu.pucp.ooia.gest_humana.dao.InicioSesionDAO;
import pe.edu.pucp.ooia.gest_humana.dao.PonenteDao;
import pe.edu.pucp.ooia.gest_humana.dao.ProfesorDAO;
import pe.edu.pucp.ooia.gest_humana.dao.PsicologoDAO;
import pe.edu.pucp.ooia.gest_humana.model.Alumno;
import pe.edu.pucp.ooia.gest_humana.model.Coordinador;
import pe.edu.pucp.ooia.gest_humana.model.Especialidad;
import pe.edu.pucp.ooia.gest_humana.model.Ponente;
import pe.edu.pucp.ooia.gest_humana.model.Profesor;
import pe.edu.pucp.ooia.gest_humana.model.Psicologo;
import pe.edu.pucp.ooia.gest_humana.mysql.AlumnoMySQL;
import pe.edu.pucp.ooia.gest_humana.mysql.AutenticarPersonaMySQL;
import pe.edu.pucp.ooia.gest_humana.mysql.CoordinadorMySQL;
import pe.edu.pucp.ooia.gest_humana.mysql.EspecialidadMySQL;
import pe.edu.pucp.ooia.gest_humana.mysql.PonenteMySQL;
import pe.edu.pucp.ooia.gest_humana.mysql.ProfesorMySQL;
import pe.edu.pucp.ooia.gest_humana.mysql.PsicologoMySQL;
import pe.edu.pucp.ooia.gest_humana.mysql.inicioSesionMySQL;

/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "GestionHumanaWS")
public class GestionHumanaWS {

    /**
     * This is a sample web service operation
     */
    private AlumnoDAO alumno;
    private EspecialidadDAO especialidad;    
    private ProfesorDAO daoProfesor;
    private PonenteDao ponente;   
    private PsicologoDAO psicologo;
    private InicioSesionDAO inicioSesion;
    private CoordinadorDAO coordinador;
    private AutenticarPersonaDAO autenticarPersona;
    
    public GestionHumanaWS() {
        alumno=new AlumnoMySQL();
        especialidad=new EspecialidadMySQL();
        daoProfesor=new ProfesorMySQL();
        ponente =new PonenteMySQL();
        psicologo=new PsicologoMySQL();
        inicioSesion=new inicioSesionMySQL();
        coordinador=new CoordinadorMySQL();    
        autenticarPersona = new AutenticarPersonaMySQL();
    }
    
    @WebMethod(operationName = "listarAlumno")
    public ArrayList<Alumno> listarAlumno(){
        ArrayList<Alumno> lista= new ArrayList<>();
        try {
            lista=alumno.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
        
    }
    @WebMethod(operationName = "insertarAlumno")
    public int insertarAlumno(@WebParam(name = "alumno")Alumno alumno){
        int resultado=0;
        try {
            resultado=this.alumno.insertar(alumno);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarAlumno")
    public int modificarAlumno(@WebParam(name = "alumno")Alumno alumno){
        int resultado=0;
        try {
            resultado=this.alumno.modificar(alumno);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarAlumno")
    public int eliminarAlumno(@WebParam(name = "id_alumno")int id_alumno){
        int resultado=0;
        try {
            resultado=this.alumno.eliminar(id_alumno);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
  
    @WebMethod(operationName = "listarEspecialidad")
    public ArrayList<Especialidad> listarEspecialidad(){
        ArrayList<Especialidad>listaEspecialidad=new ArrayList<>();
        try {
            listaEspecialidad= this.especialidad.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return listaEspecialidad;
    }
    @WebMethod(operationName = "insertarEspecialidad")
    public int insertarEspecialidad(@WebParam(name = "especialidad")Especialidad especialidad){
        int resultado=0;
        try {
            resultado=this.especialidad.insertar(especialidad);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarEspecialidad")
    public int modificarEspecialidad(@WebParam(name = "especialidad")Especialidad especialidad){
        int resultado=0;
        try {
            resultado=this.especialidad.modificar(especialidad);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarEspecialidad")
    public int eliminarEspecialidad(@WebParam(name = "id_especialidad")int id_especialidad){
        int resultado=0;
        try {
            resultado=this.especialidad.eliminar(id_especialidad);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
 
    @WebMethod(operationName = "listarProfesor")
    public ArrayList <Profesor>listarProfesores(){
        ArrayList<Profesor> empleador=new ArrayList<>();
        try {
            empleador= daoProfesor.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return empleador;
    }
    @WebMethod(operationName = "insertarProfesor")
    public int insertarProfesores( @WebParam(name="profesor") Profesor profesor){
        int resultado=0;
        try {
            resultado=daoProfesor.insertar(profesor);
            
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        
        return resultado;
    }
    @WebMethod(operationName = "modificarProfesores")
    public int modificarProfesores(@WebParam(name = "profesor")Profesor profesor){
        int resultado=0;
        try {
            resultado=daoProfesor.modificar(profesor);
            
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        
        return resultado;
    }
    @WebMethod(operationName = "eliminarProfesor")
    public int eliminarProfesor(@WebParam(name = "id_profesor")int id_profesor){
        int resultado=0;
        try {
            resultado=daoProfesor.eliminar(id_profesor);
            
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        
        return resultado;
    }
    
    @WebMethod(operationName = "listarPonente")
    public ArrayList<Ponente> listarPonente(){
        ArrayList<Ponente> lista=new ArrayList<>();
        try {
            lista=ponente.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "insertarPonente")
    public int insertarInvitado(@WebParam(name = "ponente")Ponente ponente){
        int resultado=0;
        try {
            resultado=this.ponente.insertar(ponente);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    @WebMethod(operationName = "modificarPonente")
    public int modificarInvitado(@WebParam(name = "ponente")Ponente ponente){
        int resultado=0;
        try {
            resultado=this.ponente.modificar(ponente);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    @WebMethod(operationName = "eliminarPonente")
    public int eliminarInvitado(@WebParam(name = "id_ponente")int id_ponente){
        int resultado=0;
        try {
            resultado=this.ponente.eliminar(id_ponente);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    
    @WebMethod(operationName = "listarPsicologo")
    public ArrayList<Psicologo> listarPsicologo(){
        ArrayList<Psicologo> lista=new ArrayList<>();
        try {
            lista=psicologo.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "insertarPsicologo")
    public int insertarPsicologo(@WebParam(name = "invitado")Psicologo psicologo){
        int resultado=0;
        try {
            resultado=this.psicologo.insertar(psicologo);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    @WebMethod(operationName = "modificarPsicologo")
    public int modificarPsicologo(@WebParam(name = "invitado")Psicologo psicologo){
        int resultado=0;
        try {
            resultado=this.psicologo.modificar(psicologo);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    @WebMethod(operationName = "eliminarPsicologo")
    public int eliminarPsicologo(@WebParam(name = "id_psicologo")int id_psicologo){
        int resultado=0;
        try {
            resultado=this.psicologo.eliminar(id_psicologo);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
        @WebMethod(operationName = "autenticarUsuario")
    public int autenticarUsuario(@WebParam(name = "usuario")String usuario,@WebParam(name = "password")String password){
        int resultado=0;
        try {
            resultado=this.inicioSesion.inicioSesion(usuario,password);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;//se devuelve el id persona
    }
    
//    @WebMethod(operationName = "autenticar_persona_dni")
//    public int autenticarPersona(@WebParam(name = "dni_persona") int dni){
//        int resultado = 0;
//        try{
//            resultado = autenticarPersona.autenticarPersona(dni);
//        }catch(Exception ex){
//            System.out.println(ex.getMessage());
//        }
//        return resultado;
//    }


    @WebMethod(operationName = "tipoUsuario")

    public int tipoUsuario(@WebParam(name = "id_persona")int id_persona ){
        int resultado=0;
        try {
            resultado=this.inicioSesion.tipoUsuario(id_persona);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;//se devuelve el id persona
    }
    @WebMethod(operationName = "listar_alumno_x_id")
    public Alumno listar_alumno_x_id(@WebParam(name = "id_persona")int id_persona ){
        Alumno resultado=null;
        try {
            resultado=alumno.listar_x_id(id_persona);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;//se devuelve el id persona
    }
    @WebMethod(operationName = "listarProfesorId")
    public Profesor listarProfesorId(@WebParam(name = "id_persona")int id_persona ){
        Profesor resultado=null;
        try {
            resultado=this.daoProfesor.listar_x_id(id_persona);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;//se devuelve el id persona
    }
    @WebMethod(operationName = "listar_coordinador_x_id")
    public Coordinador listar_coordinador_x_id(@WebParam(name = "id_persona")int id_persona ){
        Coordinador resultado=null;
        try {
            resultado=this.coordinador.listar_x_id(id_persona);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;//se devuelve el id persona
    }
    @WebMethod(operationName = "listar_psicologo_x_id")
    public Psicologo listar_psicologo_x_id(@WebParam(name = "id_persona")int id_persona ){
        Psicologo resultado=null;
        try {
            resultado=this.psicologo.listar_x_id(id_persona);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;//se devuelve el id persona
    }
    
    
    
    

    @WebMethod(operationName = "listarCoordinador")
    public ArrayList<Coordinador> listarCoordinadorEvento() {
        ArrayList<Coordinador> lista= new ArrayList<>();
        try {
            lista=coordinador.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "insertarCoordinador")
    public int insertarCoordinadorEvento(@WebParam(name = "coordinador")Coordinador coordinador){
        int resultado=0;
        try {
            resultado=this.coordinador.insertar(coordinador);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarCoordinador")
    public int modificarCoordinadorEvento(@WebParam(name = "coordinador")Coordinador coordinador){
        int resultado=0;
        try {
            resultado=this.coordinador.modificar(coordinador);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarCoordinador")
    public int eliminarCoordinadorEvento(@WebParam(name = "coordinador")Coordinador coordinador){
        int resultado=0;
        try {
            resultado=this.coordinador.eliminar(coordinador.getId_coordinador());
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "listar_usuario_correo")
    public Object[] listar_usuario_correo(@WebParam(name = "usuario")String usuario){
        Object []lista=new Object[2];
        try {
            lista=this.inicioSesion.listar_usuario_correo(usuario);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    
    @WebMethod(operationName = "cambiar_password")
    public int cambiar_password(@WebParam(name = "id")int id,@WebParam(name = "password")String password){
        int resultado=0;
        try {
            resultado=this.inicioSesion.cambiar_password(id, password);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listar_alumno_x_evento")
    public ArrayList<Alumno> listar_alumno_x_evento(@WebParam(name = "id_evento")int evento){
        ArrayList<Alumno>retorno=null;
        try{
            retorno=alumno.listar_x_evento(evento);
        }
        catch(Exception e){
            System.out.println(e.getMessage());
        }
        return retorno;
   }
    
    @WebMethod(operationName = "obtener_estado")
    public boolean obtener_estado(@WebParam(name = "id_evento")int evento,@WebParam(name = "id_alumno")int alumno){
        boolean retorno=false;
        try{
//            
//            if(this.alumno.obtenerEstadoEventoAlumno(evento, alumno))
//            retorno=1;
//            else retorno=0;
            retorno=this.alumno.obtenerEstadoEventoAlumno(evento, alumno);

        }
        catch(Exception e){
            System.out.println(e.getMessage());
        }
        return retorno;
    }
    
    
    @WebMethod(operationName = "modifcar_asistencia")
    public int modifcar_asistencia(@WebParam(name = "id_evento")int evento,@WebParam(name = "id_alumno")int alumno,@WebParam(name = "estado")boolean estado){
        int retorno=0;
        try{
           retorno=this.alumno.MODIFIACR_ASISTENCIA(evento, alumno, estado);
        }
        catch(Exception e){
            System.out.println(e.getMessage());
        }
        return retorno;
    }
    
    
    
}



   