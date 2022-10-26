#include <stdio.h>

int main(){

  int num = 1;

  while (num != 0)
  {
    printf("Input number: \n");
    fflush(stdin);
    scanf("%d", &num);
  }
  printf("Sure!\n");
}
