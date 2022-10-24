#include <iostream>

int main(){
  int num, result;
  printf("Input number to check: ");
  scanf("%d", &num);

  result = num % 2;
  if(result == 0){
    printf("%d is even number", num);
  }
}
