#include <stdio.h>


int sum(){
  int a, b, result;
  printf("Input a: \n");
  scanf("%d", &a);
  printf("Input b: \n");
  scanf("%d", &b);
  result = a + b;
  return result;
}

 int mul(int a, int b){
   int result;
     result = a * b;
  return result;
}

int main(){
  // int x;
  // x = sum();
  // printf("x:%d\n", x);
  int a, b;
  printf("Input a: \n");
  scanf("%d", &a);
  printf("Input b: \n");
  scanf("%d", &b);

  int result = mul(a, b);
  printf("Result: %d\n", result);
}
