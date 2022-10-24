#include <stdio.h>
int main() {
  float a, b, num1 ,num2 , num3 , num4;

  printf("Input a: \n");
  scanf("%f", &a);
  printf("Input b: \n");
  scanf("%f", &b);

  num1 = a + b;
  num2 = a - b;
  num3 = a/b ;
  num4 = a *b;
  printf ("TONG : %.2f \nHIEU : %.2f \nTHUONG : %.2f \nTICH : %.2f ", num1 , num2 , num3 , num4) ;
}
