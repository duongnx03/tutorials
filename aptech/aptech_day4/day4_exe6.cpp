#include <stdio.h>

int main(){
  int i, num;

  printf("Input num: ");
  scanf("%d", &num);

  for (i = 0; i < num; i++) {
    printf("%d\n", i);
  }
}
