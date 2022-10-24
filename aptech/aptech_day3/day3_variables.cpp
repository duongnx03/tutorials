#include <stdio.h>

int main (int argc, char *argv[])
{
  int num;  //Integer
  float num2;  // so thuc
  double num3;  //so thuc
  char gender;  // ki tu

  printf("Input Integer number: \n");
  scanf("%d", &num);
  printf("Input float number:\n");
  scanf("%f", &num2);
  printf("Input double number: \n ");
  scanf("%lf", &num3);
  printf("Input gender: \n");
  fflush(stdin); //xoa bo nho dem
  scanf("%c", &gender);

  printf(" Integer: %d\n float: %f\n double: %lf\n char: %c \n", num, num2, num3, gender);

  return 0;
}
