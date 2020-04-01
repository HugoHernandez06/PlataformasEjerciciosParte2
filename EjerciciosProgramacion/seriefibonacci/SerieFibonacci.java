/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package seriefibonacci;

import java.util.Scanner;

/**
 *
 * @author Administrador
 */
public class SerieFibonacci {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        int num;
        Scanner sc = new Scanner(System.in);      
        System.out.println("Ingrese la posicion del numero : "); 
        num = sc.nextInt(); 
        
        int almacenar[]; 
        almacenar=numAnteriores(num);
        StringBuilder cadena = new StringBuilder();
        
        for(int i=0;i<almacenar.length;i++)
        {
            cadena.append(almacenar[i]); 
            if(i!=almacenar.length-1) 
                cadena.append(","); 
        }
        
       System.out.println("Serie Fibonacci: ["+ cadena+"]");
       
    }
    
    public static int[] numAnteriores(int num) 
    {
        int[] numeros = new int[num]; 
        int[] numerosAnteriores = new int[num];
        
        // Condiciones Iniciales
        int i; 
        int j=0;
        numeros[0]=0; 
        numeros[1]=1;
        
        for(i=2;i<num;i++)
        {
            numeros[i]=numeros[i-1]+numeros[i-2];
        }
        
        for(i=numeros.length-1;i>=0;i--) 
        {
            numerosAnteriores[j++]=numeros[i];
        }
        
        return numerosAnteriores; 
    }
    
}
