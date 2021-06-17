/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.ooia.gest_humana.dao;

/**
 *
 * @author LENOVO
 */
public interface InicioSesionDAO {
    public int inicioSesion(String usuario, String password);
    public int tipoUsuario(int id_persona);
    
}
