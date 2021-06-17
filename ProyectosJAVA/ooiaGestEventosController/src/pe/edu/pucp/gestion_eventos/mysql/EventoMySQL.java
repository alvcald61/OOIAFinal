package pe.edu.pucp.gestion_eventos.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.sql.Time;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import pe.edu.pucp.config.DBManager;

import pe.edu.pucp.gestion_eventos.dao.EventoDAO;
import pe.edu.pucp.gestion_eventos.model.CategoriaEvento;

import pe.edu.pucp.gestion_eventos.model.Evento;
import pe.edu.pucp.ooia.gest_humana.model.Coordinador;
import pe.edu.pucp.ooia.gest_humana.model.Ponente;
import pe.edu.pucp.ooia.gest_humana.mysql.CoordinadorMySQL;

public class EventoMySQL implements EventoDAO{

    Connection con;
    Statement st;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public ArrayList<Evento> listar(String nombreCategoria) {
        ArrayList<Evento> eventos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_EVENTO_X_NOMBRE_CATEGORIA(?)}");
            cs.setString("_nombreCategoria", nombreCategoria);
            rs = cs.executeQuery();
            while(rs.next()){
                Evento evento = new Evento();
                evento.setId_evento(rs.getInt("id_evento"));
                evento.setNombre(rs.getString("nombre"));
                evento.setDescripcion(rs.getString("descripcion"));
                evento.setCategoria(new CategoriaEvento(rs.getInt("fid_categoria_evento"), 
                rs.getString("nombre_categoria")));
                evento.setCoordinador(new Coordinador());
                evento.setCoordinador(obtenerCoordinador(rs.getInt("fid_coordinador")));
                evento.setCapacidad(rs.getInt("capacidad"));
                evento.setCupo(rs.getInt("cupo"));
                evento.setFecha(rs.getDate("fecha"));
                evento.setHoraInicio(rs.getTime("hora_inicio"));
                evento.setHoraFin(rs.getTime("hora_fin"));
                evento.setLugar(rs.getString("lugar"));
                evento.setImagen(rs.getBytes("imagen"));
                evento.setActivo(true);
                evento.setPonentes(listarPonente(evento.getId_evento()));
               // System.out.println(evento.getPonentes().get(0));
                eventos.add(evento);
                
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            Logger.getLogger(EventoMySQL.class.getName()).log(Level.SEVERE, null, ex);
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage()+"El error es aqui");};
            
        }
        return eventos;
    }
    
    @Override
    public ArrayList<Evento> listar_x_fecha(Date fecha) {
        ArrayList<Evento> eventos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_EVENTO_X_FECHA(?)}");
            cs.setDate("_fecha", fecha);
            rs = cs.executeQuery();
            while(rs.next()){
                Evento evento = new Evento();
                evento.setId_evento(rs.getInt("id_evento"));
                evento.setNombre(rs.getString("nombre"));
                evento.setDescripcion(rs.getString("descripcion"));
                evento.setCategoria(new CategoriaEvento(rs.getInt("id_categoria_evento"), 
                rs.getString("nombre_categoria")));
                evento.setCoordinador(new Coordinador());
                evento.setCoordinador(obtenerCoordinador(rs.getInt("fid_coordinador")));
                evento.setCapacidad(rs.getInt("capacidad"));
                evento.setCupo(rs.getInt("cupo"));
                evento.setFecha(rs.getDate("fecha"));
                evento.setHoraInicio(rs.getTime("hora_inicio"));
                evento.setHoraFin(rs.getTime("hora_fin"));
                evento.setLugar(rs.getString("lugar"));
                evento.setImagen(rs.getBytes("imagen"));
                evento.setActivo(true);
                evento.setPonentes(listarPonente(evento.getId_evento()));
                eventos.add(evento);
                
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            
        }
        return eventos;
    }
    
    @Override
    public int insertar(Evento evento) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_EVENTO(?,?,?,?,?,?,?,?,?,?,?)}");
            //SETEAMOS los parametros
            cs.registerOutParameter("_id_evento", java.sql.Types.INTEGER);
            //Insertamos en evento
            cs.setString("_nombre", evento.getNombre());
            cs.setString("_descripcion", evento.getDescripcion());
            cs.setInt("_fid_coordinador", evento.getCoordinador().getId_coordinador());
            cs.setInt("_fid_categoria_evento", evento.getCategoria().getId_categoria());
            cs.setInt("_capacidad", evento.getCapacidad());
            cs.setString("_lugar", evento.getLugar());
            cs.setDate("_fecha", new Date(evento.getFecha().getTime()));
            cs.setTime("_hora_inicio", new Time(evento.getHoraInicio().getTime()));
            cs.setTime("_hora_fin", new Time(evento.getHoraFin().getTime()));
            cs.setBytes("_imagen", evento.getImagen());
            //INSERTAR_EVENTO_PONENTE
            
            //Ejecutamos el procedimiento
            cs.executeUpdate();
            evento.setId_evento(cs.getInt("_id_evento")); 
            for(Ponente ponente : evento.getPonentes()){
                cs=con.prepareCall("{call INSERTAR_EVENTO_PONENTE(?,?,?)}");
                cs.registerOutParameter("_id_evento_ponente", java.sql.Types.INTEGER);
                cs.setInt("_fid_ponente", ponente.getId_ponente());
                cs.setInt("_fid_evento",evento.getId_evento());
                cs.executeUpdate();
            }
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage() + "Clase");
            Logger.getLogger(EventoMySQL.class.getName()).log(Level.SEVERE, null, ex);
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return resultado;
    }

    @Override
    public int modificar(Evento evento) {
        int resultado = 0;
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_EVENTO(?,?,?,?,?,?,?,?,?,?,?,?)}");
            //Modificamos en evento
            cs.setInt("_id_evento", evento.getId_evento());
            cs.setString("_nombre", evento.getNombre());
            cs.setString("_descripcion", evento.getDescripcion());
            cs.setInt("_fid_coordinador", evento.getCoordinador().getId_coordinador());
            cs.setInt("_fid_categoria_evento", evento.getCategoria().getId_categoria());
            cs.setInt("_capacidad", evento.getCapacidad());
            cs.setInt("_cupo", evento.getCupo());
            cs.setString("_lugar", evento.getLugar());
            cs.setDate("_fecha", new Date(evento.getFecha().getTime()));
            cs.setTime("_hora_inicio", new Time(evento.getHoraInicio().getTime()));
            cs.setTime("_hora_fin", new Time(evento.getHoraFin().getTime()));
            cs.setBytes("_imagen", evento.getImagen());
            //Ejecutamos el procedimiento
            cs.executeUpdate();
                cs=con.prepareCall("{call ELIMINAR_EVENTO_PONENTE(?)}");
                cs.setInt("_id_evento", evento.getId_evento());
                cs.executeUpdate();
            
                for(Ponente ponente : evento.getPonentes()){
                cs=con.prepareCall("{call INSERTAR_EVENTO_PONENTE(?,?,?)}");
                cs.registerOutParameter("_id_evento_ponente", java.sql.Types.INTEGER);
                cs.setInt("_fid_ponente", ponente.getId_ponente());
                cs.setInt("_fid_evento",evento.getId_evento());
                cs.executeUpdate();
                
            }
            
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return resultado;
    }

    @Override
    public int eliminar(int id_evento) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("call ELIMINAR_EVENTO(?)");
            //SETEAMOS los parametros
            cs.setInt("_id_evento", id_evento);
            //Hacemos la eliminacion logica
            cs.executeUpdate();
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return resultado;
    }
    
    private Coordinador obtenerCoordinador(int id_coordinador) {
        ArrayList<Coordinador> arrayList=new CoordinadorMySQL().listar();
        for(Coordinador aux:arrayList)
            if(aux.getId_coordinador()==id_coordinador)
                return aux;
        return null;
    }
    
    private ArrayList<Ponente> listarPonente(int id_evento){
           ArrayList<Ponente> lista=new ArrayList<>();
        Connection con1;
        
        ResultSet rs1;
        CallableStatement cs1;       
         try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con1 = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs1 = con1.prepareCall("call LISTAR_EVENTO_PONENTE(?)");
            cs1.setInt("_id_evento", id_evento);
            rs1=cs1.executeQuery();
            while(rs1.next()){
                Ponente ponente=new Ponente();
                ponente.setId_ponente(rs1.getInt("id_ponente"));
                ponente.setNombre(rs1.getString("nombre_ponente"));
                lista.add(ponente);
            }
        } catch (Exception e) {
             System.out.println(e.getMessage() + "Aqui");
        }
            
           
           return lista;
           
    }

 
    
}