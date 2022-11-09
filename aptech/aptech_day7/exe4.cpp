#include <stdio.h>

// funcion
int sum(int a, int b){
  return a + b;
  // int result;
  // result = a + b;
  // return result;
}
  

int sub(int a, int b){
  return a - b;
 // int result;
 //  result = a - b;
 //  return result;
}
 
int mul(int a, int  b){
  return a * b;
// int result;
//   result = a * b;
//   return result;
}

float dev(float a, float b){
  return a / b;
// float result;
//   result = a / b;
//   return result;
}

int main(){
  int a, b;
  printf("Input a: \n");
  scanf("%d", &a);
  printf("Input b: \n");
  scanf("%d", &b);

  printf("%d + %d = %d\n", a, b, sum(a, b));
  printf("%d - %d = %d\n", a, b, sub(a, b));
  printf("%d * %d = %d\n", a, b, mul(a, b));
  printf("%d / %d = %f\n", a, b, dev(a, b));
  // int result = sum(a, b);
  // printf("Result: %d\n", result);
  //
  // int result1 = sub(a, b);
  // printf("Result: %d\n", result1);
  //
  // int result2 = mul(a, b);
  // printf("Result: %d\n", result2);
  //
  // float result3 = dev(a, b);
  // printf("Result: %f\n", result3);
}
