#include <iostream>

int main(){
  int num;

  printf("Input num: \n");
  scanf("%d", &num);

  if(num <= 0 || num % 2 == 0){
    printf("Num la 1 so am hoac so chan\n");
  }
}
