/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package palabramedio;


import javax.swing.JOptionPane;

/**
 *
 * @author Administrador
 */
public class PalabraMedio {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        String cadena = JOptionPane.showInputDialog("Ingrese la cadena");
        System.out.println(cadena.toUpperCase());
        
        String[] cadenaSeparada =  cadena.split(" ");
        
        if(cadenaSeparada[0].compareTo(cadenaSeparada[2])<0 && cadenaSeparada[0].compareTo(cadenaSeparada[1])<0 && 
           cadenaSeparada[1].compareTo(cadenaSeparada[2])<0){    
            System.out.println("La palabra del medio es correcta");
        } else{
            System.out.println("La palabra del medio no es correcta");
        }
             
    }
}
