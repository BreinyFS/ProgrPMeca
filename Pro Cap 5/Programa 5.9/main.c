#include <stdio.h>
#include <math.h>

/* Búsqueda secuencial en arreglos desordenados. */
const int MAX = 100;

void Lectura(int *, int); /* Prototipos de funciones. */
int Busca(int *, int, int);

int main(void)
{
    int RES, ELE, TAM, VEC[MAX];

    do
    {
        printf("Ingrese el tamano del arreglo: ");
        scanf("%d", &TAM);
    }
    while (TAM > MAX || TAM < 1); /* Se verifica que el tamano del arreglo sea correcto. */

    Lectura(VEC, TAM);

    printf("Ingrese el elemento a buscar: ");
    scanf("%d", &ELE);

    RES = Busca(VEC, TAM, ELE); /* Se llama a la funcion que busca en el arreglo. */

    if (RES != -1)
    {
        printf("El elemento se encuentra en la posicion %d\n", RES);
    }
    else
    {
        printf("El elemento no se encuentra en el arreglo\n");
    }

    return 0;
}

void Lectura(int A[], int T)
/* La funcion Lectura se utiliza para leer un arreglo unidimensional de T elementos de tipo entero. */
{
    int I;
    for (I = 0; I < T; I++)
    {
        printf("Ingrese el elemento %d: ", I + 1);
        scanf("%d", &A[I]);
    }
}

int Busca(int A[], int T, int K)
/* Esta función localiza en el arreglo un elemento determinado.
   Si el elemento es encontrado, regresa la posicion correspondiente.
   En caso contrario, regresa -1. */
{
    int I;
    for (I = 0; I < T; I++)
    {
        if (A[I] == K)
        {
            return I + 1; /* Se asigna I+1 dado que las posiciones en el arreglo comienzan desde cero. */
        }
    }

    return -1; /* El elemento no fue encontrado */
}