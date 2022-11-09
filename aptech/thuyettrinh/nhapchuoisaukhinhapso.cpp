#include <stdio.h>
#include <string.h>

int main(){
  char str[100] = "";
  int num;
  
  printf("Input num: \n");
  scanf("%d", &num);
  printf("Input string: \n");
  fflush(stdin);
  scanf("%s", str);

  printf("Num: %d\n", num);
  printf("String: %s\n", str);
}
