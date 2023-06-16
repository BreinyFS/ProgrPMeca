#include <stdio.h>
#include <string.h>
#include <ctype.h>

/* Cuenta palabras.
El programa calcula el número de palabras que hay en la cadena de caracteres. */

int cuentap(char *); 

void main(void)
{
    int i;
    char fra[50];

    printf("\nIngrese la linea de texto: ");
    fgets(fra, sizeof(fra), stdin);
    fra[strcspn(fra, "\n")] = '\0';  

    strcat(fra, " "); 

    i = cuentap(fra);
    printf("La linea de texto tiene %d palabras\n", i);
}

int cuentap(char *cad)
{
    
    char *cad0 = "";
    int i = 0;

    cad0 = strstr(cad, " "); 

    while (strcmp(cad, " "))
    {
        strcpy(cad, cad0 + 1);
        i++;
        cad0 = strstr(cad, " ");
       
    }

    return i;
}