package pe.edu.pucp.gestion_eventos.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_eventos.dao.CategoriaEventoDAO;
import pe.edu.pucp.gestion_eventos.model.CategoriaEvento;

/**
 *
 * @author Gerardo
 */
public class CategoriaEventoMySQL implements CategoriaEventoDAO {
    
    Connection con;
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<CategoriaEvento> listar() {
        ArrayList<CategoriaEvento> categorias = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_CATEGORIA_EVENTO()}");
            rs = cs.executeQuery();
            while(rs.next()){
                CategoriaEvento categoria = new CategoriaEvento();
                categoria.setId_categoria(rs.getInt("id_categoria_evento"));
                categoria.setNombre(rs.getString("nombre"));
                categoria.setActivo(true);
                categorias.add(categoria);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return categorias;
    }

    @Override
    public int insertar(CategoriaEvento categoria) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_CATEGORIA_EVENTO(?,?)}");
            cs.registerOutParameter("_id_categoria", java.sql.Types.INTEGER);
            /*Persona*/
            cs.setString("_nombre", categoria.getNombre());
            cs.executeUpdate();
            categoria.setId_categoria(cs.getInt("_id_categoria"));
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(CategoriaEvento categoria) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_CATEGORIA_EVENTO(?,?)}");
            cs.setInt("_id_categoria",categoria.getId_categoria());
            /*Persona*/
            cs.setString("_nombre", categoria.getNombre());
            cs.executeUpdate();
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int id_categoria) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call ELIMINAR_CATEGORIA_EVENTO(?)}");
            cs.setInt("_id_categoria", id_categoria);
            cs.executeUpdate();
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

}
