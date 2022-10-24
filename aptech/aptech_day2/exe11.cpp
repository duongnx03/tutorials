#include <iostream>

int main(){
 // int a, b, aconvertb, bconverta;
  int a, b, temp;

  printf("Input a: \n");
  scanf("%d", &a);
  printf("Input b: \n");
  scanf("%d", &b);

  temp = b;
  b = a;
  a = temp;

  printf("value of a: %d\n", a);
  printf("value of b: %d\n", b);
/*
  aconvertb = a + b - a; 
  printf("a is: %d\n", aconvertb);

  bconverta = a + b - b;
  printf("b is: %d\n", bconverta);
*/
}

