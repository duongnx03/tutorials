#include <stdio.h>

int main(){
  float a, b, sum, tru, nhan, chia;

  printf("Input num1: \n");
  scanf("%f", &a);

  printf("Input num2: \n");
  scanf("%f", &b);

  sum = a + b;
  tru = a - b;
  nhan = a * b;
  chia = a / b;

  printf("Tong: %.2f \n Hieu: %.2f \n Tich: %.2f \n Thuong: %.2f \n", sum, tru, nhan, chia);
}
