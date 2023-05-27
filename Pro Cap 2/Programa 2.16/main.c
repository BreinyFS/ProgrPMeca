#include <stdio.h>

/* Empresa textil
CLA, CAT, ANT, RES: variables de tipo entero.
SAL: variables de tipo real. */

int main()
{
  int CLA, CAT, ANT, RES;
  printf("\nIngrese la clave, categoria y antigüedad del trabajador: ");
  scanf("%d %d %d", &CLA, &CAT, &ANT);
  switch(CAT)
    {
      case 3:
      case 4: if (ANT >= 5)
        RES = 1;
      else 
        RES = 0;
      break;
      case 2: if (ANT >= 7)
        RES = 1;
      else
        RES = 0;
      break; 
      default: RES = 0;
      break;
    }
  if (RES)
    printf("\nEl trabajador con clave %d reune las condiciones para el puesto", CLA); 
  else 
    printf("\nEl trabajdor con clave %d no reune las condiciones para el puesto", CLA); 
}