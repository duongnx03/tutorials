#include <stdio.h>

int main(){

  int num = 1;

  printf("Input number: \n");
  scanf("%d", &num);

  while (num != 0)
  {
    printf("Input number again: \n");
    scanf("%d", &num);
  }
  printf("Sure!\n");
}



