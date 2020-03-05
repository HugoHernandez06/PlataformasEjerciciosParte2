/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cifrado;

import java.util.Scanner;

/**
 *
 * @author Administrador
 */
public class Cifrado {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);
        String cadena, cadenaCifrada = "";
        int desplazamiento;
        
        String abecedario = "abcdefghijklmnopqrstuwvyz";
        String abecedario1 = abecedario.toUpperCase();

        System.out.println("Ingrese la frase a cifrar");
        cadena = sc.nextLine();
        String cadenaMayus = cadena.toUpperCase();
        
        System.out.println("Ingrese el numero de cifrado");
        desplazamiento = sc.nextInt();
       
        for(int i=0;i<cadenaMayus.length();i++){
            for(int j=0; j<abecedario1.length();j++){
                if(cadenaMayus.charAt(i)==abecedario1.charAt(j)){
                    if(j + desplazamiento >= abecedario1.length()){
                        cadenaCifrada += abecedario1.charAt((j+desplazamiento)%abecedario1.length());
                    }
                    else{
                        cadenaCifrada += abecedario1.charAt(j+desplazamiento);
                    }
                }
            }
        }
            System.out.println("Su cadena ingresada es: " + cadena.toUpperCase());
            System.out.println("Su cadena cifrada con " + desplazamiento + " es : " + cadenaCifrada);
    }

   
}
