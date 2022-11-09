#include <stdio.h>
#include <string.h>

int main(){
  char str1[50];
  // char str2[50];
  int num;

  printf("Input num: \n"); 
  scanf("%d", &num);
  printf("Input str1: \n");
  fflush(stdin);
  gets(str1);

  printf("%s\n", str1);
}
