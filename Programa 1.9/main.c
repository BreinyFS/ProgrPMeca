#include <stdio.h>

/* Estancia
ECA: variable de tipo real. */

int main()
{
  float ECA;
  printf("Ingrese la extencion de la estancia: ");
  scanf("%f", &ECA);
  ECA = ECA * 4047 / 10000;
  printf("\nExtension de la estancia en hectarias: %5.2f", ECA);
}